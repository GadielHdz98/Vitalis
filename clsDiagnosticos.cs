using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsDiagnosticos
    {
        private int idDiagnostico;
        private string nombreDiagnostico;
        private string descripcion;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public string NombreDiagnostico { get => nombreDiagnostico; set => nombreDiagnostico = value; }
        public string Sintomas { get => descripcion; set => descripcion = value; }

        //Metodo para cargar dgv
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT id_diagnostico AS Clave,
                            nombreDiagnostico AS Diagnostico,
                            Descripcion
                            FROM Diagnosticos;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion a la base de datos" + ex.Message);
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
                    string sql = @"SELECT id_Diagnostico AS Clave, nombreDiagnostico AS Diagnostico, Descripcion FROM Diagnosticos WHERE nombreDiagnostico LIKE @nombre;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", "%" + nombreDiagnostico + "%");

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tabla;
        }
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0: //Insertar nuevo registro

                            string sqlN = "INSERT INTO Diagnosticos (nombreDiagnostico, Descripcion) VALUES (@nombreDiagnostico, @descripcion)";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreDiagnostico", nombreDiagnostico);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los datos";
                                }
                            }
                            break;

                        case 1: //Actualizar registro

                            string sqlA = "UPDATE Diagnosticos D SET D.nombreDiagnostico = @nombreDiagnostico, D.Descripcion = @descripcion WHERE D.id_Diagnostico = @idDiagnostico";

                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreDiagnostico", nombreDiagnostico);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@idDiagnostico", idDiagnostico);

                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se actualizo correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se pudieron actualizar los datos";
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }

            return msg;
        }
        public string Eliminar()
        {
            string msg = "";

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlE = "DELETE FROM Diagnosticos WHERE id_Diagnostico = @idDiagnostico;";

                    using (comando = new MySqlCommand(sqlE, conexion))
                    {
                        comando.Parameters.AddWithValue("@idDiagnostico", idDiagnostico);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar correctamente";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }

            return msg;
        }


    }
}
