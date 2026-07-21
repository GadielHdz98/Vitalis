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
        clsPacientes pacientes;

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
                    combo.SelectedIndex = 0;
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

        private void chcbxCita_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCita.Checked)
            {
                dtmpHoraCita.Enabled = false;
                dtmpFechaCita.Enabled = false;
            }
            else
            {
                dtmpHoraCita.Enabled = true;
                dtmpFechaCita.Enabled = true;
            }
        }

        private void pcbIconBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatriculaPaciente.Text))
            {
                MessageBox.Show("Ingrese una matrícula.");
                txtMatriculaPaciente.Focus();
                return;
            }

            pacientes = new clsPacientes();

            try
            {
                pacientes.Matricula = int.Parse(txtMatriculaPaciente.Text);

                DataTable tabla = pacientes.Consultar();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún paciente con esa matrícula.");

                    //se limpian los datos que hayan antes de realizar una busqueda fallida.
                    txtTipo.Clear();
                    txtNombre.Clear();
                    txtApellidoPaterno.Clear();
                    txtCarrera.Clear();
                    txtGrado.Clear();
                    txtGrupo.Clear();

                    return;
                }

                txtTipo.Text = tabla.Rows[0]["Tipo"].ToString();
                txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
                txtApellidoPaterno.Text = tabla.Rows[0]["ApellidoPaterno"].ToString();                
                txtApellidoMaterno.Text = tabla.Rows[0]["ApellidoMaterno"].ToString();

                txtCarrera.Text = tabla.Rows[0]["Carrera"].ToString();
                txtGrado.Text = tabla.Rows[0]["Grado"].ToString();
                txtGrupo.Text = tabla.Rows[0]["Grupo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
