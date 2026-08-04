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
    public partial class frmConsultasBuscar : Form
    {
        public frmConsultasBuscar()
        {
            InitializeComponent();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmConsultaEditar ventanEmergenteEditar = new frmConsultaEditar();
            ventanEmergenteEditar.ShowDialog();
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlBuscarPaciente.Controls)
            {
                if (c is TextBox text)
                {
                    text.Clear();
                }
                else if (c is ComboBox combo)
                {
                    combo.SelectedIndex = 0;
                }
                else if (c is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (c is RadioButton rdbtn)
                {
                    rdbtn.Checked = false;
                }
            }
        }
        private void actualizarBusquedaDinamica (object sender, EventArgs e)
        {
            try
            {
                clsConsultas consulta = new clsConsultas();

                consulta.Nombre = txtNombre.Text.Trim();
                consulta.ApellidoPaterno = txtApellidoPa.Text.Trim();
                consulta.ApellidoMaterno = txtApellidoMa.Text.Trim();
                consulta.TipoPaciente = cmbTipoPaciente.Text;

                if (cmbCarrera.SelectedValue != null &&
                    cmbCarrera.SelectedValue != DBNull.Value)
                {
                    consulta.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                }
                else
                {
                    consulta.IdCarrera = null;
                }

                consulta.Grado = cmbGrado.Text;

                if (cmbDiagnostico.SelectedValue != null &&
                    cmbDiagnostico.SelectedValue != DBNull.Value)
                {
                    consulta.IdDiagnostico = Convert.ToInt32(cmbDiagnostico.SelectedValue);
                }
                else
                {
                    consulta.IdDiagnostico = 0;
                }

                consulta.CIR = chkCIR.Checked;

                consulta.Cita = chkCita.Checked;

                dgvConsultasBuscar.DataSource = consulta.ConsultarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
