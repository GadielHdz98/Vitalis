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
            HabilitarControles();
        }
        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
        //Metodo para cargar carreras en comboBox
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
                    //
                    DataRow fila = tabla.NewRow();
                    fila["id_carrera"] = DBNull.Value;
                    fila["nombreCarrera"] = "";
                    tabla.Rows.InsertAt(fila, 0);
                    //
                    cmbCarrera.DataSource = tabla;
                    cmbCarrera.DisplayMember = "nombreCarrera";
                    cmbCarrera.ValueMember = "id_carrera";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las carreras.  " + ex.Message);
            }
        }
        //metodo para ver que no se vaya ningun campo requerido vacio
        public bool ValidarCamposVacios()
        {
            string mensajeError = "Asegurese de llenar todos los campos correctamente.";
            bool esValido = true;

            //Uso un linq en este foreach para pasar unicamente por los controles de tipo textBox
            foreach (TextBox txt in pnlAgregarPacientes.Controls.OfType<TextBox>())
            {
                //solo aplica a txt que esten en enabled=true y vacios.
                if (txt.Enabled && txt.Text.Trim() == "")
                {
                    txt.Focus();
                    esValido = false;
                    break;
                }
            }
            //Uso un linq en este foreach para pasar unicamente por los controles de tipo comboBox 
            foreach (ComboBox combo in pnlAgregarPacientes.Controls.OfType<ComboBox>())
            {
                //solo aplica para comboBox que esten enabled=true y combo.
                if (combo.Enabled && combo.SelectedIndex < 1)
                {
                    combo.Focus();
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

        public void HabilitarControles()
        { 
            //Variable de tipo bool que depende de si se ha seleccionado a un alumno o no.
            bool esAlumno = cmbTipoPaciente.Text == "Alumno";

            //dependiendo de si es bool o no
            cmbCarrera.Enabled = esAlumno;
            cmbGrado.Enabled = esAlumno;
            txtGrupo.Enabled = esAlumno;

            //si no es alumno, los campos academicos de desactivan.
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
            //  Vacia los campos
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
            }
            HabilitarControles();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Primero se valida si hay campos vacios
                if (ValidarCamposVacios())
                {
                    paciente = new clsPacientes();

                    //se guardan los valores de cada campo en las propiedades de pacientes.
                    paciente.Matricula = Convert.ToInt32(txtMatriculaNoTrab.Text);
                    //uso el trim() para que se guarde sin espacios en blanco.
                    paciente.Nombre = txtNombre.Text.Trim();
                    paciente.ApellidoPaterno = txtPacienteApellidoPaterno.Text.Trim();
                    paciente.ApellidoMaterno = txtPacienteApellidoMaterno.Text.Trim();
                    paciente.TipoPaciente = cmbTipoPaciente.Text;
                    paciente.Sexo = cmbSexo.Text;
                    paciente.Peso = Convert.ToDouble(txtPeso.Text);
                    paciente.Altura = Convert.ToDouble(txtAltura.Text);
                    paciente.Temperatura = Convert.ToDouble(txtUltimaTemperatura.Text);
                    paciente.PresionArterial = txtUltimaPresionArt.Text;
                    paciente.FechaNacimiento = dtmpFechaNaciPaciente.Value.Date;

                    //Si es alumno se guardan los datos escolares
                    if (cmbTipoPaciente.Text == "Alumno")
                    {
                        paciente.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                        paciente.Grado = cmbGrado.Text;
                        paciente.Grupo = txtGrupo.Text.Trim().ToUpper();
                    }
                    //de no ser alumno, datos academicos exclusivos de alumno seran null
                    else
                    {
                        paciente.IdCarrera = null;
                        paciente.Grado = "";
                        paciente.Grupo = "";
                    }
                    //se inicia el metodo de guardar datos y en caso de no funcionar los datos se manda un mensaje
                    string msg = paciente.GuardarPaciente();
                    //Se muestra el mensaje diciendo el resultado.
                    MessageBox.Show(msg);
                    //se vacian los campos para un nuevo registro
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
