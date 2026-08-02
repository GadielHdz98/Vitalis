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
    }
}
