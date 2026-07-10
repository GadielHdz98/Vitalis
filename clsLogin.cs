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
        private static string perfil;
        private static bool esEnfermero;
        private static bool esDoctor;

        //Propiedad estatica
        public static bool EsEnfermero { get => esEnfermero; private set => esEnfermero = value; }
        public static bool EsDoctor { get => esDoctor; private set => esDoctor = value; }
        public void asignarPermisos()
        {
            switch (perfil)
            {
                case "Enfermero":
                    esEnfermero = true;
                    esDoctor = false;
                    break;
                case "Doctor":
                    esEnfermero = false;
                    esDoctor = true;
                    break;
                default:
                    esEnfermero = false;
                    esDoctor = false;
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

                    string sql = "SELECT perfil FROM usuarios " +
                                 "WHERE nombreUsuario = @usuario AND contrasena;";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                asignarPermisos();

                                if (!esEnfermero && !esDoctor)
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
