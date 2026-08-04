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
            paciente.CargarCarreras(cmbCarrera);
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }
        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            paciente.VaciarCampos(pnlAgregarPacientes);
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado, txtGrupo);
        }
        //Metodo para cargar carreras en comboBox
        
        //metodo para ver que no se vaya ningun campo requerido vacio 
        private void cmbTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            paciente.HabilitarControles(cmbTipoPaciente, cmbCarrera, cmbGrado,txtGrupo);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Primero se valida si hay campos vacios
                if (paciente.ValidarCamposVacios(pnlAgregarPacientes))
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
                        paciente.Grado = string.Empty;
                        paciente.Grupo = string.Empty;
                    }
                    //se inicia el metodo de guardar datos y en caso de no funcionar los datos se manda un mensaje
                    string msg = paciente.GuardarPaciente();
                    //Se muestra el mensaje diciendo el resultado.
                    MessageBox.Show(msg);
                    //se vacian los campos para un nuevo registro
                    paciente.VaciarCampos(pnlAgregarPacientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
