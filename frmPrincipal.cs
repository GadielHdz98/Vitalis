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
    public partial class frmPrincipal : Form
    {
        private clsPrincipal principal = new clsPrincipal();

        public frmPrincipal()
        {
            InitializeComponent();           
                      
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            int altura_max = this.Height;
            int ancho_max = this.Width;

            // MessageBox.Show($"Altura: {altura_max}, Ancho: {ancho_max}");
            
            this.Height = altura_max;
            this. Width = ancho_max;

            principal.AgregarAlContenedor(new frmInicio(), pnlContenedor);
        }
    }
}
