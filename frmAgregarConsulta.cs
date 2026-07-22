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
        clsDiagnosticos diagnosticos;

        public frmAgregarConsulta()
        {
            InitializeComponent();
            CargarDiagnosticos();
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

        public void CargarDiagnosticos()
        {
            diagnosticos = new clsDiagnosticos();

            try
            {
                cmbDiagnostico.DataSource = diagnosticos.CargarCombo();
                cmbDiagnostico.DisplayMember = "nombreDiagnostico";
                cmbDiagnostico.ValueMember = "id_Diagnostico";
                cmbDiagnostico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                try
                {
                    int tipoOperacion = 0;

                    clsConsultas consultas = new clsConsultas();

                    consultas.Matricula = int.Parse(txtMatriculaPaciente.Text);

                    consultas.IdServicioMedico = clsLogin.idUsuarioLogeado;
                    consultas.Tratamiento = rchtxtTratamiento.Text;
                    consultas.CIR = chkCIR.Checked;
                    consultas.Cita = chkCita.Checked;
                    consultas.HoraInicio = dtmpHoraInicioConsulta.Value.TimeOfDay;
                    consultas.HoraFinal = dtmpHoraFinConsulta.Value.TimeOfDay;
                    consultas.IdDiagnostico = Convert.ToInt32(cmbDiagnostico.SelectedValue);
                    consultas.FechaConsulta = dtmpFechaConsulta.Value.Date;

                    if (chkCita.Checked)
                    {
                        consultas.CitaProgramada = dtmpFechaCita.Value.Date;
                        consultas.CitaHora = dtmpHoraCita.Value.TimeOfDay;
                    }

                    string msg = consultas.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public bool ValidarCamposVacios()
        {
            string mensajeError = "Asegurese de llenar todos los campos correctamente.";
            bool esValido = true;


            //Uso un linq en este foreach para pasar unicamente por los controles de tipo comboBox 
            foreach (ComboBox combo in pnlAgregarConsultas.Controls.OfType<ComboBox>())
            {
                //solo aplica para comboBox que esten enabled=true y combo.
                if (combo.SelectedIndex < 1)
                {
                    combo.Focus();
                    esValido = false;
                    break;
                }
            }
            //Uso un linq en este foreach para pasar unicamente por los controles de tipo textBox
            foreach (TextBox txt in pnlAgregarConsultas.Controls.OfType<TextBox>())
            {
                //solo aplica a txt que esten en enabled=true y vacios.
                if (txt.Text.Trim() == "")
                {
                    txt.Focus();
                    esValido = false;
                    break;
                }
            }
            if (!esValido)
            {
                MessageBox.Show(mensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return esValido;
        }
    }
}
    

