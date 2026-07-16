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
    public partial class frmConsultas : Form
    {
        private clsConsultas consultas = new clsConsultas();

        public frmConsultas()
        {
            InitializeComponent();
            consultas.AgregarAlContenedor(new frmConsultasRecientes(), pnlContenedorConsultas);
        }

        private void btnConsultasRecientesTopBar_Click(object sender, EventArgs e)
        {
            consultas.AgregarAlContenedor(new frmConsultasRecientes(), pnlContenedorConsultas);
        }

        private void btnBuscarConsultasTopBar_Click(object sender, EventArgs e)
        {
            consultas.AgregarAlContenedor(new frmConsultasBuscar(), pnlContenedorConsultas);
        }

        private void btnAgregarConsultasTopBar_Click(object sender, EventArgs e)
        {
            consultas.AgregarAlContenedor(new frmAgregarConsulta(), pnlContenedorConsultas);
        }
    }
}
