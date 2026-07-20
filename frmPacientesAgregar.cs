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



namespace Vitalis
{
    public partial class frmPacientesAgregar : Form
    {

        clsPacientes paciente = new clsPacientes();
        clsCarreras carreras = new clsCarreras();

        public frmPacientesAgregar()
        {
            InitializeComponent();
            CargarCarreras();
            CargarComboBox();
            HabilitarControles();
        }



        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
        public void CargarComboBox()
        {
            cmbTipoPaciente.Items.Clear();
            cmbSexo.Items.Clear();
            cmbGrado.Items.Clear();

            cmbTipoPaciente.Items.Add("");
            cmbTipoPaciente.Items.Add("Alumno");
            cmbTipoPaciente.Items.Add("Docente");

            cmbSexo.Items.Add("");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");

            cmbGrado.Items.Add("");

            for (int i = 1; i <= 11; i++)
            {
                cmbGrado.Items.Add(i.ToString());
            }

            cmbTipoPaciente.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
            cmbGrado.SelectedIndex = 0;
        }
        public void CargarCarreras()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_carrera, nombreCarrera FROM carreras ORDER BY nombreCarrera;";

                    MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    consulta.Fill(tabla);

                    DataRow fila = tabla.NewRow();
                    fila["id_carrera"] = DBNull.Value;
                    fila["nombreCarrera"] = "";
                    tabla.Rows.InsertAt(fila, 0);

                    cmbCarrera.DataSource = tabla;
                    cmbCarrera.DisplayMember = "nombreCarrera";
                    cmbCarrera.ValueMember = "id_carrera";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void HabilitarControles()
        {
            bool esAlumno = cmbTipoPaciente.Text == "Alumno";

            cmbCarrera.Enabled = esAlumno;
            cmbGrado.Enabled = esAlumno;
            txtGrupo.Enabled = esAlumno;

            if (!esAlumno)
            {
                cmbCarrera.SelectedIndex = 0;
                cmbGrado.SelectedIndex = 0;
                txtGrupo.Clear();
            }
        }
        private void cmbTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarControles();
        }
        public void VaciarCampos()
        {
            foreach (Control c in pnlAgregarPacientes.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is ComboBox combo)
                {
                    combo.SelectedIndex = 0;
                }
                else if (c is DateTimePicker datePicker)
                {
                    datePicker.Value = DateTime.Now;
                }

                HabilitarControles();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaNoTrab.Text != null || txtMatriculaNoTrab.Text != "")
                {
                    paciente = new clsPacientes();

                    paciente.Matricula = Convert.ToInt32(txtMatriculaNoTrab.Text);
                    paciente.Nombre = txtNombre.Text.Trim();
                    paciente.ApellidoPaterno = txtPacienteApellidoPaterno.Text.Trim();
                    paciente.ApellidoMaterno = txtPacienteApellidoMaterno.Text.Trim();

                    paciente.TipoPaciente = cmbTipoPaciente.Text;

                    //Si es alumno se guardan los datos escolares
                    if (cmbTipoPaciente.Text == "Alumno")
                    {
                        paciente.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                        paciente.Grado = cmbGrado.Text;
                        paciente.Grupo = txtGrupo.Text.Trim();
                    }
                    else
                    {
                        paciente.IdCarrera = null;
                        paciente.Grado = "";
                        paciente.Grupo = "";
                    }

                    paciente.Sexo = cmbSexo.Text;
                    paciente.Peso = Convert.ToDouble(txtPeso.Text);
                    paciente.Altura = Convert.ToDouble(txtAltura.Text);
                    paciente.Temperatura = Convert.ToDouble(txtUltimaTemperatura.Text);
                    paciente.PresionArterial = txtUltimaPresionArt.Text;
                    paciente.FechaNacimiento = dtmpFechaNaciPaciente.Value.Date;

                    string msg = paciente.GuardarPaciente();

                    MessageBox.Show(msg);

                    VaciarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
