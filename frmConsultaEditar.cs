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
    public partial class frmConsultaEditar : Form
    {
        public frmConsultaEditar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnlEditarConsulta.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox combo)
                {
                    //combo.SelectedIndex = 0;
                }
                else if (control is CheckBox check)
                {
                    check.Checked = false;
                }
               
            }
        }
    }
}
