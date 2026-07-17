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
    public partial class frmDiagnosticos : Form
    {
        public int idDiagnostico;

        clsDiagnosticos diagnosticos = new clsDiagnosticos();

        public frmDiagnosticos()
        {
            InitializeComponent();
            CargarTablaConLosDatos();
        }
        //Funcion para actualizar los datos de DGV segun la BD.
        public void CargarTablaConLosDatos()
        {
            diagnosticos = new clsDiagnosticos();

            dgvDiagnosticos.DataSource = null;
            dgvDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Carga inicial de todos los datos en el DataGridView
                dgvDiagnosticos.DataSource = diagnosticos.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarDiagnostico_TextChanged(object sender, EventArgs e)
        {
            diagnosticos = new clsDiagnosticos();

            try
            {
                diagnosticos.NombreDiagnostico =
                    txtBuscarDiagnostico.Text;

                dgvDiagnosticos.DataSource =
                    diagnosticos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDiagnosticos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiagnosticos.CurrentRow == null)
            {
                return;
            }

            idDiagnostico = Convert.ToInt32(dgvDiagnosticos.CurrentRow.Cells[0].Value);

            txtNombreDiagnostico.Text = dgvDiagnosticos.CurrentRow.Cells[1].Value.ToString();

            rchtxtSintomas.Text = dgvDiagnosticos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Operacion de tipo ternario: condición ? valorSiVerdadero : valorSiFalso;
                int tipoDeOperacion = idDiagnostico == 0 ? 0 : 1;

                diagnosticos.IdDiagnostico = idDiagnostico;
                diagnosticos.NombreDiagnostico = txtNombreDiagnostico.Text;
                diagnosticos.Sintomas = rchtxtSintomas.Text;

                string msg = "";

                if (tipoDeOperacion != 0)
                {
                    //Se le pregunta al usuario si desea actualizar el registro antes de continuar
                    var resp = MessageBox.Show("Confirma si se desea actualizar el registro seleccionado: ", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resp == DialogResult.Yes)
                    {
                        msg = diagnosticos.GuardarActualizar(tipoDeOperacion);
                        MessageBox.Show(msg);
                    }
                }
                //En cualquier otro caso que el tipo de operacion no sea actualizar no hara falta preguntar por confirmacion.
                //Y se ejecuta el metodo GuardarActualizar directamente.
                else
                {
                    msg = diagnosticos.GuardarActualizar(tipoDeOperacion);
                    MessageBox.Show(msg);
                }

                CargarTablaConLosDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idDiagnostico = 0;
            txtNombreDiagnostico.Clear();
            rchtxtSintomas.Clear();
            txtNombreDiagnostico.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = MessageBox.Show("Confirma si se desea eliminar el dato seleccionado: ", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resp == DialogResult.Yes)
                {
                    diagnosticos.IdDiagnostico = idDiagnostico;

                    string msg = diagnosticos.Eliminar();

                    MessageBox.Show(msg);

                    CargarTablaConLosDatos();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }    
}
