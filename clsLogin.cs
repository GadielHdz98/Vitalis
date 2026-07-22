using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsLogin
    {
        
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //atributo estatico.
        
        private static bool esEnfermero;
        private static bool esDoctor;
        private static bool esAdministrador;
        public static string nombreUsuarioLogeado;
        public static string apellidoPaUsuarioLogeado;
        public static string apellidoMaUsuarioLogeado;
        public static string perfil;
        public static int idUsuarioLogeado;

        //Propiedad estatica
        public static bool EsEnfermero { get => esEnfermero; private set => esEnfermero = value; }
        public static bool EsDoctor { get => esDoctor; private set => esDoctor = value; }
        public static bool EsAdministrador { get => esAdministrador; set => esAdministrador = value; }

        public void asignarPermisos()
        {
            switch (perfil)
            {
                case "Enfermera":
                    esEnfermero = true;
                    esDoctor = false;
                    esAdministrador = false;
                    break;
                case "Medico":
                    esEnfermero = false;
                    esDoctor = true;
                    esAdministrador = false;
                    break;
                case "Administrador":
                    esEnfermero = false;
                    esDoctor = false;
                    esAdministrador = true;
                    break;
                default:
                    esEnfermero = false;
                    esDoctor = false;
                    esAdministrador = false;
                    break;
            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "SELECT id_ServicioMedico,nombre,apellidoPaterno,apellidoMaterno,perfil FROM serviciosmedicos " +
                                 "WHERE nombreUsuario = @usuario AND contrasena = @password;";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);                       


                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                idUsuarioLogeado = resultado.GetInt32("id_ServicioMedico");
                                nombreUsuarioLogeado = resultado.GetString("nombre");
                                apellidoPaUsuarioLogeado = resultado.GetString("apellidoPaterno");
                                apellidoMaUsuarioLogeado = resultado.GetString("apellidoMaterno");                                
                                asignarPermisos();

                                if (!esEnfermero && !esDoctor && !esAdministrador)
                                {
                                    throw new Exception($"El perfil ingresado no tiene permiso para acceder");
                                }

                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.");
                            }
                        }
                    }
                }
            }  //Cerrar el Try Catch

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
