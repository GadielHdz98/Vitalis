using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsPacientesRecientes
    {
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Unimos las 4 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid
                    string sql = "SELECT P.matricula AS Matricula, " +
                                 "P.nombre AS Nombre, " +
                                 "P.apellidoPaterno AS 'A. Paterno', " +
                                 "P.apellidoMaterno AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "P.tipoPaciente AS Tipo, " +
                                 "p.grado AS Grado, " +
                                 "P.grupo AS Grupo, " +
                                 "E.sexo AS Sexo, " +
                                 "E.fechaNacimiento AS 'FechaNacimiento', " +
                                 "E.peso AS Peso, " +
                                 "E.temperatura AS Temperatura, " +
                                 "E.presionArterial as 'Presion' " +
                                 "FROM pacientes P " +
                                 "INNER JOIN expediente E ON P.Matricula = E.Matricula " +
                                 "INNER JOIN carreras C ON P.id_carrera = C.id_carrera;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexión al cargar catalogo de alumnos " + ex.Message);
            }
            return tabla;
        }

    }
}
