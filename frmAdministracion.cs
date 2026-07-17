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
    public partial class frmAdministracion : Form
    {
        private clsAdministracion administracion = new clsAdministracion();

        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            administracion.AgregarAlContenedor(new frmDiagnosticos(), pnlContenedorAdministracion);
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            administracion.AgregarAlContenedor(new frmCarreras(), pnlContenedorAdministracion);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            administracion.AgregarAlContenedor(new frmUsuarios(), pnlContenedorAdministracion);
        }
    }
}
