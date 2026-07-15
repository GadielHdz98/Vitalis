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
        public frnPacientesBuscar()
        {
            InitializeComponent();
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            txtApellidoMaternoPaciente.Text = string.Empty;
            txtApellidoPaternoPaciente.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
        }
    }
}
