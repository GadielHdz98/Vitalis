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
    public partial class frmPacientesRecientes : Form
    {
        clsPacientesRecientes pacientesR;

        public frmPacientesRecientes()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            pacientesR = new clsPacientesRecientes();
            dgvPacientesRegistradosRecientemente.DataSource = null;
            dgvPacientesRegistradosRecientemente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvPacientesRegistradosRecientemente.DataSource = pacientesR.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
