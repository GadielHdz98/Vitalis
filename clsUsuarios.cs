using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsUsuarios
    {
        // Usamos una tabla temporal y un adaptador
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        //Usamos command para insertar o actualizar
        private MySqlCommand comando;

        private int idServicioM;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string usuario;
        private string password;
        private string perfil;

        public int IdServicioM { get => idServicioM; set => idServicioM = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }


        //Cargar la Base de datos
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_ServicioMedico AS Trabajador, " +
                                 "nombre AS Nombre, " +
                                 "apellidoPaterno AS ApellidoPaterno, " +
                                 "apellidoMaterno AS ApellidoMaterno, " +
                                 "nombreUsuario AS NombreUsuario, " +
                                 "contrasena AS Contrasena, " +
                                 "perfil AS Perfil " +
                                 "FROM serviciosmedicos;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        // Método para consultar por coincidencias (Búsqueda en tiempo real, Busqueda tipo Like)
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Consulta SQL usando el operador LIKE para coincidencias parciales
                    string sql = "SELECT id_ServicioMedico AS Trabajador, " +
                                 "nombre AS Nombre, " +
                                 "apellidoPaterno AS ApellidoPaterno, " +
                                 "apellidoMaterno AS ApellidoMaterno, " +
                                 "nombreUsuario AS NombreUsuario, " +
                                 "contrasena AS Contrasena, " +
                                 "perfil AS Perfil " +
                                 "FROM serviciosmedicos WHERE nombre LIKE @Trabajador;";
                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        // Se agregan los comodines '%' para buscar cualquier coincidencia que contenga el texto
                        comando.Parameters.AddWithValue("@Trabajador ", "%" + nombre + "%");

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    } // Libera el comando automáticamente
                } // Libera la conexión automáticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        //METODO CREADO PARA GUARDAR Y ACTUALIZAR CAMBIOS DENTRO DE LA BD.
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    try
                    {
                        switch (tipoOperacion)
                        {
                            case 0: //NUEVO E INSERTAR
                                    //insertamos en la tabla tblusuarios
                                string sqlInsUser = "INSERT INTO serviciosmedicos (nombre, apellidoPaterno, apellidoMaterno, nombreUsuario, contrasena, perfil)" +
                                                    "VALUES(@nombre, @apellidoP, @apellidoM, @nombreU, @password, @perfil); SELECT LAST_INSERT_ID();";

                                //Se recupera el ultimo ID insertado
                                int nuevoIdUsuario = 0;
                                using (comando = new MySqlCommand(sqlInsUser, conexion))
                                {
                                    comando.Parameters.AddWithValue("@nombre", nombre);
                                    comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                                    comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                                    comando.Parameters.AddWithValue("@nombreU", usuario);
                                    comando.Parameters.AddWithValue("@password", password);
                                    comando.Parameters.AddWithValue("@perfil", perfil);
                                    nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                }
                                msg = "El trabajador y su usuario se guardaron correctamente.";
                                break;
                            case 1: // ACTUALIZAR
                                    // Paso A: Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic del Grid
                                string sqlUpdUser = "UPDATE serviciosmedicos SET nombre = @nombre, apellidoPaterno = @apellidoP, apellidoMaterno = @apellidoM, " +
                                                    "nombreUsuario = @nombreU, perfil = @perfil " +
                                                    "WHERE id_ServicioMedico = @idServicioM;";

                                using (comando = new MySqlCommand(sqlUpdUser, conexion))
                                {
                                    comando.Parameters.AddWithValue("@idServicioM", idServicioM);
                                    comando.Parameters.AddWithValue("@nombre", nombre);
                                    comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                                    comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                                    comando.Parameters.AddWithValue("@nombreU", usuario);
                                    comando.Parameters.AddWithValue("@perfil", perfil);

                                    comando.ExecuteNonQuery();
                                }
                                msg = "Los datos del docente se actualizaron correctamente.";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en la operacion. Se cancelan los cambios: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion: " + ex.Message);
            }

            return msg;
        } //Finaliza el metodo

        //METODO PARA ELIMINAR ALGUN REGISTRO
        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlE = "DELETE FROM serviciosmedicos WHERE id_ServicioMedico = @idTrabajador;";
                    using (comando = new MySqlCommand(sqlE, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTrabajador", idServicioM);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            msg = "Los datos se eliminaron correctamente, Eliminacion Completa";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar correctamente, Error al eliminar";
                        }
                    } //Libera la eliminacion
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return msg;
        }

        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;

                }
            }
        }
    }
}