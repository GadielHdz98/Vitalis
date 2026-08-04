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
        }
        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            paciente.VaciarCampos(pnlBuscarPaciente);
            txtBuscarMatricula.Clear();
        }
        private void cmbTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }

        private void RealizarBusquedaFiltros(object sender, EventArgs e)
        {
            try
            {
                // uso un constructor y le envio datos a los atributos de paciente.
                clsPacientes paciente = new clsPacientes();
                paciente.Nombre = txtNombrePaciente.Text.Trim();
                paciente.ApellidoPaterno = txtApellidoPaPaciente.Text.Trim();
                paciente.ApellidoMaterno = txtApellidoMaPaciente.Text.Trim();
                paciente.TipoPaciente = cmbTipoPaciente.Text;

                // si hay algo seleccionado se envia
                if (cmbCarrera.SelectedIndex > 0)
                {
                    paciente.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                }
                else
                {
                    paciente.IdCarrera = null; //de lo contrario se queda en null.
                }
                paciente.Grado = cmbGrado.Text;
                paciente.Grupo = txtGrupo.Text.Trim().ToUpper();

                //rellenamos la tabla con los datos obtenidos de la consulta.
                dgvPacientesBuscar.DataSource = paciente.ConsultarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientesBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcbBuscarIcon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarMatricula.Text))
                {
                    MessageBox.Show("Ingrese una matrícula.",
                                    "Búsqueda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtBuscarMatricula.Focus();
                    return;
                }

                clsPacientes paciente = new clsPacientes();

                paciente.Matricula = Convert.ToInt32(txtBuscarMatricula.Text);

                dgvPacientesBuscar.DataSource = paciente.ConsultarMatricula();

                if (dgvPacientesBuscar.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún paciente con esa matrícula.",
                                    "Búsqueda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
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
