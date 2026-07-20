using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsConsultasRealizadas
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
                    string sql = "SELECT C.id_Consulta AS 'No. Consulta', " +
                                 "P.Matricula AS Matricula, " +
                                 "CONCAT(P.nombre, ' ', P.apellidoPaterno, ' ', P.apellidoMaterno) AS 'Nombre Completo', " +
                                 "CA.nombreCarrera AS Carrera, " +
                                 "P.grado AS Grado, " +
                                 "P.grupo AS Grupo, " +
                                 "P.tipoPaciente AS Tipo, " +
                                 "CONCAT(SM.nombre, ' ', SM.apellidoPaterno, ' ', SM.apellidoMaterno) AS Consultor, " +
                                 "SM.perfil AS Rol, " +
                                 "D.nombreDiagnostico AS Diagnostico, " +
                                 "C.tratamiento AS Tratamiento, " +
                                 "C.CIR AS CIR, " +                                 
                                 "C.citaProgramada AS Cita, " +
                                 "C.citaHora AS 'Hora Cita', " +
                                 "C.FechaConsulta AS 'Fecha Consulta', " +
                                 "C.horaInicio AS 'Hora Inicio', " +
                                 "C.horaFinal AS 'Hora Final' " +
                                 "FROM consultas C " +
                                 "INNER JOIN pacientes P ON C.Matricula = P.Matricula " +
                                 "INNER JOIN carreras CA ON P.id_carrera = CA.id_carrera " +
                                 "INNER JOIN serviciosmedicos SM ON C.id_ServicioMedico = SM.id_ServicioMedico " +
                                 "INNER JOIN diagnosticos D ON C.id_Diagnostico = D.id_Diagnostico;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión al cargar catalogo de alumnos " + ex.Message);
            }
            return tabla;
        }
    }
}
