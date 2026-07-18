using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Vitalis;

namespace Vitalis
{
    public partial class frmConsultasRecientes : Form
    {
        clsConsultasRealizadas consultasR;

        public frmConsultasRecientes()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            consultasR = new clsConsultasRealizadas();
            dgvConsultasRealizadas.DataSource = null;
            dgvConsultasRealizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvConsultasRealizadas.DataSource = consultasR.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}