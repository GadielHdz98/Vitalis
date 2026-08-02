using MySqlConnector;
//agregar los using de la libreria questPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;
using static System.ComponentModel.Design.ObjectSelectorEditor;



namespace Vitalis
{
    internal class clsReportes
    {
        // Usamos una tabla temporal y un adaptador
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        //Usamos command para insertar o actualizar
        private MySqlCommand comando;

        private string mes;

        public DataTable ConsultarPorCantDiagnostico()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT * FROM ( " +
                                    "SELECT D.nombreDiagnostico AS Diagnostico, " +
                                    "CA.nombreCarrera AS Carrera, " +
                                    "COUNT(*) AS 'Total Casos', " +
                                    "0 AS Orden " +
                                    "FROM consultas C " +
                                    "INNER JOIN diagnosticos D ON C.id_Diagnostico = D.id_Diagnostico " +
                                    "INNER JOIN pacientes P ON C.Matricula = P.Matricula " +
                                    "INNER JOIN carreras CA ON P.id_carrera = CA.id_carrera " +
                                    "GROUP BY D.nombreDiagnostico, CA.nombreCarrera " +
                                    "UNION ALL SELECT 'TOTAL GENERAL', '', COUNT(*), 1 FROM consultas " +
                                  " ) AS Reporte ORDER BY Orden, Diagnostico, Carrera;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar el total de diagnosticos por consulta" + ex.Message);
            }
            return tabla;
        }

        // Reporte de consultas mensuales.
        public DataTable ConsultarConsultasMensuales(int mes)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT C.FechaConsulta AS 'Fecha', " +
                                 "P.Matricula AS 'Matrícula', " +
                                 "CONCAT(P.nombre, ' ', P.apellidoPaterno, ' ', P.apellidoMaterno) AS 'Paciente', " +
                                 "P.tipoPaciente AS 'Tipo Paciente', " +
                                 "CA.nombreCarrera AS 'Carrera', " +
                                 "P.grado AS 'Grado', " +
                                 "P.grupo AS 'Grupo', " +
                                 "D.nombreDiagnostico AS 'Diagnóstico', " +
                                 "CONCAT(SM.nombre, ' ', SM.apellidoPaterno, ' ', SM.apellidoMaterno) AS 'Atendido por' " +
                                 "FROM consultas C " +
                                 "INNER JOIN pacientes P ON C.Matricula = P.Matricula " +
                                 "INNER JOIN carreras CA ON P.id_carrera = CA.id_carrera " +
                                 "INNER JOIN diagnosticos D ON C.id_Diagnostico = D.id_Diagnostico " +
                                 "INNER JOIN serviciosmedicos SM ON C.id_ServicioMedico = SM.id_ServicioMedico " +
                                 "WHERE MONTH(C.FechaConsulta) = @mes " +
                                 "AND YEAR(C.FechaConsulta) = YEAR(CURDATE()) " +
                                 "ORDER BY C.FechaConsulta DESC, C.horaInicio DESC; ";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.SelectCommand.Parameters.AddWithValue("@mes", mes);
                        consulta.Fill(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las consultas mensuales" + ex.Message);
            }
            return tabla;
        }

        public DataTable ReporteSemanaActual()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT C.FechaConsulta AS 'Fecha', " +
                                 "P.Matricula AS 'Matrícula', " +
                                 "CONCAT(P.nombre, ' ', P.apellidoPaterno, ' ', P.apellidoMaterno) AS 'Paciente', " +
                                 "P.tipoPaciente AS 'Tipo Paciente', " +
                                 "CA.nombreCarrera AS 'Carrera', " +
                                 "P.grado AS 'Grado', " +
                                 "P.grupo AS 'Grupo', " +
                                 "D.nombreDiagnostico AS 'Diagnóstico', " +
                                 "CONCAT(SM.nombre, ' ', SM.apellidoPaterno, ' ', SM.apellidoMaterno) AS 'Atendido por' " +
                                 "FROM consultas C " +
                                 "INNER JOIN pacientes P ON C.Matricula = P.Matricula " +
                                 "INNER JOIN carreras CA ON P.id_carrera = CA.id_carrera " +
                                 "INNER JOIN diagnosticos D ON C.id_Diagnostico = D.id_Diagnostico " +
                                 "INNER JOIN serviciosmedicos SM ON C.id_ServicioMedico = SM.id_ServicioMedico " +
                                 "WHERE C.FechaConsulta BETWEEN DATE_SUB(CURDATE(), INTERVAL 7 DAY) AND CURDATE() " +
                                 "ORDER BY C.FechaConsulta DESC, C.horaInicio DESC;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar el total de diagnosticos por consulta" + ex.Message);
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

                    MessageBox.Show("Reporte generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
