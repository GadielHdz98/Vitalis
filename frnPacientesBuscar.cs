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
    public partial class frnPacientesBuscar : Form
    {
        clsPacientes paciente = new clsPacientes();

        public frnPacientesBuscar()
        {
            InitializeComponent();
            paciente.CargarCarreras(cmbCarrera);
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }
        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            paciente.VaciarCampos(pnlBuscarPaciente);
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }
        private void cmbTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                clsPacientes paciente = new clsPacientes();

                paciente.Nombre = txtNombrePaciente.Text.Trim();

                paciente.ApellidoPaterno = txtApellidoPaPaciente.Text.Trim();

                paciente.ApellidoMaterno = txtApellidoMaPaciente.Text.Trim();

                paciente.TipoPaciente = cmbTipoPaciente.Text;

                if (cmbCarrera.SelectedIndex > 0)
                {
                    paciente.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                }
                else
                {
                    paciente.IdCarrera = null;
                }

                paciente.Grado = cmbGrado.Text;

                paciente.Grupo = txtGrupo.Text.Trim().ToUpper();

                dgvPacientesBuscar.DataSource = paciente.ConsultarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
