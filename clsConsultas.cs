using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsConsultas
    {
        //
        private int matricula;
        private int idServicioMedico;
        private string tratamiento;
        private bool cir;
        private bool cita;
        private DateTime citaProgramada;
        private TimeSpan citaHora;
        private TimeSpan horaInicio;
        private TimeSpan horaFinal;
        private int idDiagnostico;
        private DateTime fechaConsulta;
        private int idConsulta;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string tipoPaciente;
        private int? idCarrera;
        private string grado;
        //                                      
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;
        private Form misFormsAbiertos;

        public int Matricula { get => matricula; set => matricula = value; }
        public int IdServicioMedico { get => idServicioMedico; set => idServicioMedico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public bool CIR { get => cir; set => cir = value; }
        public bool Cita { get => cita; set => cita = value; }
        public DateTime CitaProgramada { get => citaProgramada; set => citaProgramada = value; }
        public TimeSpan CitaHora { get => citaHora; set => citaHora = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFinal { get => horaFinal; set => horaFinal = value; }
        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string TipoPaciente { get => tipoPaciente; set => tipoPaciente = value; }
        public int? IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void AgregarAlContenedor(Form formulario, Panel panel)
        {
            //Verifica que no este abierto ningun form, y si lo hay, lo cierre
            if (misFormsAbiertos != null)
            {
                misFormsAbiertos.Close();
                misFormsAbiertos.Dispose();
            }
            //Guardamos la referencia del formulario nuevo a mostrar
            misFormsAbiertos = formulario;

            //Configurar propiedades de comportamiento y visualizacion del form
            formulario.TopLevel = false; //Le quitamos el comportamiento de una ventana normal de windows
            formulario.FormBorderStyle = FormBorderStyle.None; //sin bordes
            formulario.Dock = DockStyle.Fill; //Llenar todo el espacio sin usar del panel

            //Incrustar en el panel donde se mostrara segun el parametro del metodo
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            panel.BringToFront();

            //Mostrar formulario
            formulario.Show();
        }
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0:
                                    string sqlInsert = "INSERT INTO consultas " +
                                                       "(Matricula,id_ServicioMedico,tratamiento,CIR,cita,citaProgramada,citaHora,horaInicio,horaFinal,id_Diagnostico,FechaConsulta) " +
                                                       "VALUES(@matricula,@servicio,@tratamiento,@cir,@cita,@fechaCita,@horaCita,@horaInicio,@horaFinal,@diagnostico,@fechaConsulta);";

                                    using (comando = new MySqlCommand(sqlInsert, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", Matricula);
                                        comando.Parameters.AddWithValue("@servicio", IdServicioMedico);
                                        comando.Parameters.AddWithValue("@tratamiento", Tratamiento);
                                        comando.Parameters.AddWithValue("@cir", CIR);
                                        comando.Parameters.AddWithValue("@horaInicio", HoraInicio);
                                        comando.Parameters.AddWithValue("@horaFinal", HoraFinal);
                                        comando.Parameters.AddWithValue("@diagnostico", IdDiagnostico);
                                        comando.Parameters.AddWithValue("@fechaConsulta", FechaConsulta);
                                        comando.Parameters.AddWithValue("@cita", cita);
                                        if (!cita)
                                        {
                                            comando.Parameters.AddWithValue("@fechaCita", null);
                                            comando.Parameters.AddWithValue("@horaCita", null);
                                        }
                                        else
                                        {
                                            comando.Parameters.AddWithValue("@fechaCita", citaProgramada);
                                            comando.Parameters.AddWithValue("@horaCita", citaHora);
                                        }
                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "La consulta se registró correctamente.";
                                    break;

                                case 1:
                                    string sqlUpdate = "UPDATE consultas SET " +
                                                       "Matricula=@matricula," +
                                                       "id_ServicioMedico=@servicio," +
                                                       "tratamiento=@tratamiento," +
                                                       "CIR=@cir," +
                                                       "cita=@cita," +
                                                       "citaProgramada=@fechaCita," +
                                                       "citaHora=@horaCita," +
                                                       "horaInicio=@horaInicio," +
                                                       "horaFinal=@horaFinal," +
                                                       "id_Diagnostico=@diagnostico," +
                                                       "FechaConsulta=@fechaConsulta " +
                                                       "WHERE id_Consulta=@idConsulta;";
                                    using (comando = new MySqlCommand(sqlUpdate, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idConsulta", IdConsulta);
                                        comando.Parameters.AddWithValue("@matricula", Matricula);
                                        comando.Parameters.AddWithValue("@servicio", IdServicioMedico);
                                        comando.Parameters.AddWithValue("@tratamiento", Tratamiento);
                                        comando.Parameters.AddWithValue("@cir", CIR);
                                        comando.Parameters.AddWithValue("@cita", Cita);
                                        comando.Parameters.AddWithValue("@horaInicio", HoraInicio);
                                        comando.Parameters.AddWithValue("@horaFinal", HoraFinal);
                                        comando.Parameters.AddWithValue("@diagnostico", IdDiagnostico);
                                        comando.Parameters.AddWithValue("@fechaConsulta", FechaConsulta);
                                        if (!cita)
                                        {
                                            comando.Parameters.AddWithValue("@fechaCita", null);
                                            comando.Parameters.AddWithValue("@horaCita", null);
                                        }
                                        else
                                        {
                                            comando.Parameters.AddWithValue("@fechaCita", citaProgramada);
                                            comando.Parameters.AddWithValue("@horaCita", citaHora);
                                        }
                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "La consulta se actualizó correctamente.";
                                    break;
                            }
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operación, se cancelan los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
            return msg;
        }

        public DataTable ConsultarFiltros()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql =
                    @"SELECT
            C.id_Consulta AS 'Consulta',
            C.FechaConsulta AS 'Fecha',
            P.Matricula AS 'Matrícula',
            CONCAT(P.nombre,' ',P.apellidoPaterno,' ',P.apellidoMaterno)
            AS 'Paciente',
            P.tipoPaciente AS 'Tipo',
            CA.nombreCarrera AS 'Carrera',
            P.grado AS 'Grado',
            E.sexo AS 'Sexo',
            TIMESTAMPDIFF(YEAR,E.fechaNacimiento,CURDATE())
            AS 'Edad',
            D.nombreDiagnostico AS 'Diagnóstico',
            CONCAT
            (
                S.nombre,' ',
                S.apellidoPaterno,' ',
                S.apellidoMaterno
            )
            AS 'Consultor',
            C.tratamiento AS 'Tratamiento',
            C.horaInicio AS 'Hora Inicio',
            C.horaFinal AS 'Hora Final',
            CASE
                WHEN C.CIR = 1 THEN 'Sí'
                ELSE 'No'
            END AS 'CIR',
            CASE
                WHEN C.cita = 1 THEN 'Sí'
                ELSE 'No'
            END AS 'Cita',
            C.citaProgramada AS 'Fecha Cita',
            C.citaHora AS 'Hora Cita'
            FROM consultas C
            INNER JOIN pacientes P
                ON C.Matricula = P.Matricula
            INNER JOIN expediente E
                ON P.Matricula = E.Matricula
            INNER JOIN serviciosmedicos S
                ON C.id_ServicioMedico = S.id_ServicioMedico
            INNER JOIN diagnosticos D
                ON C.id_Diagnostico = D.id_Diagnostico
            LEFT JOIN carreras CA
                ON P.id_carrera = CA.id_carrera
            WHERE 1 = 1 ";

                    comando = new MySqlCommand();
                    comando.Connection = conexion;

                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sql += " AND P.nombre LIKE @Nombre";
                        comando.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(apellidoPaterno))
                    {
                        sql += " AND P.apellidoPaterno LIKE @ApellidoPaterno";
                        comando.Parameters.AddWithValue("@ApellidoPaterno", "%" + apellidoPaterno + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(apellidoMaterno))
                    {
                        sql += " AND P.apellidoMaterno LIKE @ApellidoMaterno";
                        comando.Parameters.AddWithValue("@ApellidoMaterno", "%" + apellidoMaterno + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(tipoPaciente))
                    {
                        sql += " AND P.tipoPaciente = @TipoPaciente";
                        comando.Parameters.AddWithValue("@TipoPaciente", tipoPaciente);
                    }

                    if (idCarrera.HasValue)
                    {
                        sql += " AND P.id_carrera = @IdCarrera";
                        comando.Parameters.AddWithValue("@IdCarrera", idCarrera.Value);
                    }

                    if (!string.IsNullOrWhiteSpace(grado))
                    {
                        sql += " AND P.grado = @Grado";
                        comando.Parameters.AddWithValue("@Grado", grado);
                    }

                    if (idDiagnostico > 0)
                    {
                        sql += " AND C.id_Diagnostico = @IdDiagnostico";
                        comando.Parameters.AddWithValue("@IdDiagnostico", idDiagnostico);
                    }

                    if (cir)
                    {
                        sql += " AND C.CIR = @CIR";
                        comando.Parameters.AddWithValue("@CIR", true);
                    }

                    if (cita)
                    {
                        sql += " AND C.cita = @Cita";
                        comando.Parameters.AddWithValue("@Cita", true);
                    }

                    sql += " ORDER BY C.FechaConsulta DESC;";

                    comando.CommandText = sql;

                    consulta = new MySqlDataAdapter(comando);

                    consulta.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos: " + ex.Message);
            }

            return tabla;
        }
        
    }
}
