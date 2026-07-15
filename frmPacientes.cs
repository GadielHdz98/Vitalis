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
    public partial class frmPacientes : Form
    {
        private clsPacientes pacientes = new clsPacientes();

        public frmPacientes()
        {
            InitializeComponent();
            MessageBox.Show($"Size: {this.Width}, {this.Height}");
        }

        private void btnPacientesRecientesTopBar_Click(object sender, EventArgs e)
        {
            pacientes.AgregarAlContenedor(new frmPacientesRecientes(), pnlContenedorPacientes);
        }

        private void btnBuscarPacientesTopBar_Click(object sender, EventArgs e)
        {
            pacientes.AgregarAlContenedor(new frnPacientesBuscar(), pnlContenedorPacientes);
        }

        private void btnAgregarPacientesTopBar_Click(object sender, EventArgs e)
        {
            pacientes.AgregarAlContenedor(new frmPacientesAgregar(), pnlContenedorPacientes);
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.Height}, {this.Width}");
        }
    }
}
