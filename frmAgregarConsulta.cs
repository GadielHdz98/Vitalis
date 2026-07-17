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
    public partial class frmAgregarConsulta : Form
    {
        public frmAgregarConsulta()
        {
            InitializeComponent();
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlAgregarConsultas.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is ComboBox combo)
                {
                    //combo.SelectedIndex = 0;
                }
                else if (c is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (c is RadioButton rdbtn)
                {
                    rdbtn.Checked = false;
                }
            }
        }
    }
}
