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
    public partial class frmPacientesAgregar : Form
    {
        public frmPacientesAgregar()
        {
            InitializeComponent();
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            txtMatriculaNoTrab.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPacienteApellidoMaterno.Text = string.Empty;
            txtPacienteApellidoPaterno.Text = string.Empty;
            txtPeso.Text = string.Empty;   
            txtUltimaPresionArt.Text = string.Empty;
            txtUltimaTemperatura.Text = string.Empty;
            txtGrupo.Text= string.Empty;
        }
    }
}
