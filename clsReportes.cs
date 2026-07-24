using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar los using de la libreria questPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;



namespace Vitalis
{
    internal class clsReportes
    {
        // Usamos una tabla temporal y un adaptador
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        //Usamos command para insertar o actualizar
        private MySqlCommand comando;

        public DataTable ConsultarPorCantDiagnostio()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.nombreDiagnostico AS 'Nombre Diagnostico', " +
                                 "COUNT(*) AS Total " +
                                 "FROM consultas C " +
                                 "INNER JOIN diagnosticos D ON C.id_Diagnostico = D.id_Diagnostico " +
                                 "GROUP BY D.nombreDiagnostico " +
                                 "ORDER BY Total DESC;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos y tutores" + ex.Message);
            }
            return tabla;
        }

        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //abre la ventana para guardar el archivo pdf
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (.pdf |*pdf)";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.Letter.Landscape());
                            page.Margin(1.5f, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontFamily(Fonts.Arial));

                            // Esto es para poner un título al reporte
                            page.Header().Row(row =>
                            {
                                row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("UNIVERSIDAD TECNOLÓGICA DE LA HUASTECA HIDALGUENSE")
                                        .FontSize(18)
                                        .Bold()
                                        .FontColor("#10407A");

                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                                });

                                /* if (Properties.Resources.uthhLogo != null)
                                {
                                    byte[] bytesLogo = Properties.Resources.uthhLogo;
                                    row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                                } 
                                */
                            });

                            // --- PARTE 2: CONTENIDO CENTRAL ---
                            page.Content().PaddingTop(20).Column(column =>
                            {
                                // AQUÍ SE IMPRIME EL TÍTULO QUE LE PASES POR PARÁMETRO
                                column.Item().PaddingBottom(15).Text(tituloReporte) // <-- DINÁMICO
                                    .FontSize(12).Bold().FontColor(Colors.Black);

                                // La tabla se construye sola según las columnas que traiga el DataTable
                                column.Item().Table(table =>
                                {
                                    int totalColumnas = tabla.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            if (i > 0 && i < totalColumnas - 1)
                                                columns.RelativeColumn(2f);
                                            else
                                                columns.RelativeColumn(1.2f);
                                        }
                                    });

                                    // Nombres de las columnas en automatico de acuerdo a la tabla
                                    foreach (DataColumn columnaObj in tabla.Columns)
                                    {
                                        table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                            .Text(columnaObj.ColumnName).FontSize(10).Bold().FontColor(Colors.White);
                                    }

                                    // Filas automáticas
                                    bool alternarFila = true;
                                    foreach (DataRow fila in tabla.Rows)
                                    {
                                        string colorFondo = alternarFila ? "#E6EBF5" : "#FFFFFF";

                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            var celda = table.Cell().Background(colorFondo)
                                                .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                .Padding(7).AlignMiddle();

                                            if (i == 0 || i == (totalColumnas - 1))
                                                celda.AlignCenter();
                                            else
                                                celda.AlignLeft();

                                            celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                        }
                                        alternarFila = !alternarFila;
                                    }
                                });
                            });

                            // Este es el pie de página
                            page.Footer().AlignRight().Text(x =>
                            {
                                x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.CurrentPageNumber().FontSize(9).Bold();
                                x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.TotalPages().FontSize(9).Bold();
                            });
                        });
                    }).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
