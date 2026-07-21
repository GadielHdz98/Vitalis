using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsPacientes
    {
        private Form misFormsAbiertos;
        private int matricula;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string tipoPaciente;

        private int? idCarrera;
        private string grado;
        private string grupo;

        private string sexo;
        private double peso;
        private double altura;
        private double temperatura;
        private string presionArterial;
        private DateTime fechaNacimiento;

        //Adaptador y tabla virtuales de la clase
        

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

        //Objetos para consultas     
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string TipoPaciente { get => tipoPaciente; set => tipoPaciente = value; }
        public int? IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Temperatura { get => temperatura; set => temperatura = value; }
        public string PresionArterial { get => presionArterial; set => presionArterial = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public string GuardarPaciente()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    string sqlPaciente =
                    @"INSERT INTO pacientes
                    (
                        Matricula,
                        nombre,
                        apellidoPaterno,
                        apellidoMaterno,
                        tipoPaciente,
                        id_carrera,
                        grado,
                        grupo
                    )
                    VALUES
                    (
                        @Matricula,
                        @Nombre,
                        @ApellidoPaterno,
                        @ApellidoMaterno,
                        @TipoPaciente,
                        @IdCarrera,
                        @Grado,
                        @Grupo
                    );";
                    using (comando = new MySqlCommand(sqlPaciente, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@Matricula", matricula);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                        comando.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                        comando.Parameters.AddWithValue("@TipoPaciente", tipoPaciente);

                        if (idCarrera.HasValue)
                            comando.Parameters.AddWithValue("@IdCarrera", idCarrera.Value);
                        else
                            comando.Parameters.AddWithValue("@IdCarrera", DBNull.Value);

                        if (string.IsNullOrWhiteSpace(grado))
                            comando.Parameters.AddWithValue("@Grado", DBNull.Value);
                        else
                            comando.Parameters.AddWithValue("@Grado", grado);

                        if (string.IsNullOrWhiteSpace(grupo))
                            comando.Parameters.AddWithValue("@Grupo", DBNull.Value);
                        else
                            comando.Parameters.AddWithValue("@Grupo", grupo);

                        comando.ExecuteNonQuery();
                    }
                    string sqlExpediente =
                    @"INSERT INTO expediente
                    (
                        sexo,
                        peso,
                        altura,
                        temperatura,
                        presionArterial,
                        foto,
                        fechaNacimiento,
                        Matricula
                    )
                    VALUES
                    (
                        @Sexo,
                        @Peso,
                        @Altura,
                        @Temperatura,
                        @PresionArterial,
                        NULL,
                        @FechaNacimiento,
                        @Matricula
                    );";
                    using (comando = new MySqlCommand(sqlExpediente, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@Sexo", sexo);
                        comando.Parameters.AddWithValue("@Peso", peso);
                        comando.Parameters.AddWithValue("@Altura", altura);
                        comando.Parameters.AddWithValue("@Temperatura", temperatura);
                        comando.Parameters.AddWithValue("@PresionArterial", presionArterial);
                        comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        comando.Parameters.AddWithValue("@Matricula", matricula);

                        comando.ExecuteNonQuery();
                    }
                    transaccion.Commit();

                    msg = "El paciente se guardó correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al guardar el paciente: " + ex.Message);
                }
            }

            return msg;
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT P.tipoPaciente AS Tipo, " +
                                 "P.nombre AS Nombre, " +
                                 "P.apellidoPaterno AS ApellidoPaterno, " +
                                 "P.apellidoMaterno AS ApellidoMaterno, " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "P.grado AS Grado, " +
                                 "P.grupo AS Grupo " +
                                 "FROM pacientes P " +
                                 //Usamos left join para cuando llamemos a un paciente de tipo trabajador, se llamen bien todos los datos, sin perder alguno
                                 //priorizando la tabla izquierda
                                 "LEFT JOIN carreras C ON P.id_carrera = C.id_carrera " +
                                 "WHERE P.Matricula = @matricula;";

                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@matricula", Matricula);

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }

            return tabla;
        }  
    }
}
