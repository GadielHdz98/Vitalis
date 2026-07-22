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
    }
}
