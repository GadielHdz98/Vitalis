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
        private DataTable tabla;

        public frmReportes()
        {
            InitializeComponent();
        }

        public void cargarGridCantDiagnostico()
        {
            reportes = new clsReportes();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tabla = reportes.ConsultarPorCantDiagnostico();
                dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReportes.DataSource = tabla;
                dgvReportes.Columns["Orden"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarGridMensual()
        {
            int mes = cmbReporteMensual.SelectedIndex + 1;
            reportes = new clsReportes();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tabla = reportes.ConsultarConsultasMensuales(mes);
                dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReportes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarGrindSemanal()
        {
            reportes = new clsReportes();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tabla = reportes.ReporteSemanaActual();
                dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReportes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarGrindDiario()
        {
            reportes = new clsReportes();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                tabla = reportes.ReporteDelDia(dtmpConsultaDelDia.Value.Date);
                dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReportes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbReporteCantDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            dtmpConsultaDelDia.Enabled = false;
            cmbReporteMensual.Enabled = false;
            cargarGridCantDiagnostico();
        }

        private void rbReportePacientesMensuales_CheckedChanged(object sender, EventArgs e)
        {
            cargarGridMensual();
            dtmpConsultaDelDia.Enabled = false;
            cmbReporteMensual.Enabled = true;
            cmbReporteMensual.SelectedIndex = DateTime.Now.Month - 1; // Selecciona el mes actual
        }

        private void cmbReporteMensual_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtmpConsultaDelDia.Enabled = false;
            int mes = cmbReporteMensual.SelectedIndex + 1;
            clsReportes reporte = new clsReportes();
            dgvReportes.DataSource = reporte.ConsultarConsultasMensuales(mes);
        }

        private void rbReporteSemanal_CheckedChanged(object sender, EventArgs e)
        {
            dtmpConsultaDelDia.Enabled = false;
            cmbReporteMensual.Enabled = false;
            cargarGrindSemanal();
        }

        private void rbReportesDiarios_CheckedChanged(object sender, EventArgs e)
        {
            cmbReporteMensual.Enabled = false;
            cargarGrindDiario();
            dtmpConsultaDelDia.Enabled = true;
            clsReportes reporte = new clsReportes();

            // Coloca la fecha actual
            dtmpConsultaDelDia.Value = DateTime.Today;
            // Muestra las consultas del día de hoy
            tabla = reporte.ReporteDelDia(DateTime.Today);
            dgvReportes.DataSource = tabla;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            if (rbReporteCantDiagnostico.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de la cantidad de diagnosticos por carrera.", "ReporteCantidadDiagnosticosPorCarrera.pdf");
            }
            else if (rbReportePacientesMensuales.Checked == true || cmbReporteMensual.Enabled == true)
            {
                DataTable tabla = (DataTable)dgvReportes.DataSource;

                reportes.ExportarPDF(tabla, "Reporte de las consultas del mes de " + cmbReporteMensual.Text, "ReporteConsultasMensual.pdf");
            }
            else if (rbReporteSemanal.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de las consultas de la semana.", "ReporteConsultasSemanal.pdf");
            }
            else if (rbReportesDiarios.Checked == true || dtmpConsultaDelDia.Enabled == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de consultas del " + dtmpConsultaDelDia.Value.ToString("dd/MM/yyyy"), "ReporteConsultasPorFecha.pdf");
            }

        }

        private void dtmpConsultaDelDia_ValueChanged(object sender, EventArgs e)
        {
            cmbReporteMensual.Enabled = false;
            cargarGrindDiario();
            clsReportes reporte = new clsReportes();
            dgvReportes.DataSource = tabla;
        }
    }
}
