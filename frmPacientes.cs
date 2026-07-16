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
            pacientes.AgregarAlContenedor(new frmPacientesRecientes(), pnlContenedorPacientes);
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
    }
}
