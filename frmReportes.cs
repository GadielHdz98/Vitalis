using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitalis
{
    public partial class frmReportes : Form
    {
        clsReportes reportes;
        private object tabla;

        public frmReportes()
        {
            InitializeComponent();
            rbReporteCantDiagnostico.Checked = true;
        }

        public void cargarGridAlumnosRiesgo()
        {
            reportes = new clsReportes();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tabla = reportes.ConsultarPorCantDiagnostio();
                dgvReportes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblVitalisInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void rbReporteCantDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            cargarGridAlumnosRiesgo();
        }

        /*private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rb.Checked == true)
            {
                reportes.GenerarPDF(tabla, "Reporte de alumnos con promedio de bachillerato <=8", "AlumnosTuto");
            }
            else if (rdbtntAlumBuenaCalif.Checked == true)
            {
                reportes.GenerarPDF(tabla, "Reporte de alumnos con sus tutores con promedio de bachillerato >=9", "AlumnosEnRiesgo");
            }
        }*/
    }
}
