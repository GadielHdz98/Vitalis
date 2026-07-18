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
    public partial class frmUsuarios : Form
    {
        public int idServicioM;
        clsUsuarios trabajador;

        public frmUsuarios()
        {
            InitializeComponent();
            CargarGrid();
        }

        //Funcion para actualizar los datos de DGV segun la BD.
        public void CargarGrid()
        {
            trabajador = new clsUsuarios();
            dgvServiciosMedicos.DataSource = null;
            dgvServiciosMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Carga inicial de todos los datos en el DataGridView
                dgvServiciosMedicos.DataSource = trabajador.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarServicioMedico_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarServicioMedico.Text))
            {
                CargarGrid();
                return;
            }

            trabajador = new clsUsuarios();
            dgvServiciosMedicos.DataSource = null;
            dgvServiciosMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Asigna el texto del filtro a la propiedad de la clase
                trabajador.Nombre = txtBuscarServicioMedico.Text;

                // Actualiza el DataGridView con los resultados filtrados
                dgvServiciosMedicos.DataSource = trabajador.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvServiciosMedicos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Esto es para poder saber si es nuevo o vamos a actualizar
                idServicioM = int.Parse(dgvServiciosMedicos.CurrentRow.Cells["Trabajador"].Value.ToString());

                //Esto es para la tabla alumnos
                txtNombreServicioMedico.Text = dgvServiciosMedicos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidoPaternoServicio.Text = dgvServiciosMedicos.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                txtApellidMaternoServicio.Text = dgvServiciosMedicos.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                txtNombreUsuario.Text = dgvServiciosMedicos.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtContrasenia.Text = dgvServiciosMedicos.CurrentRow.Cells["Contrasena"].Value.ToString();
                cmbPerfil.Text = dgvServiciosMedicos.CurrentRow.Cells["Perfil"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinamos el tipo de operación
                int tipoOperacion = idServicioM == 0 ? 0 : 1;

                trabajador = new clsUsuarios();

                // 1. Llenamos las propiedades del bloque Alumno
                trabajador.Nombre = string.IsNullOrEmpty(txtNombreServicioMedico.Text) ? null : txtNombreServicioMedico.Text;
                trabajador.ApellidoP = string.IsNullOrEmpty(txtApellidoPaternoServicio.Text) ? null : txtApellidoPaternoServicio.Text;
                trabajador.ApellidoM = string.IsNullOrEmpty(txtApellidMaternoServicio.Text) ? null : txtApellidMaternoServicio.Text;
                trabajador.Usuario = string.IsNullOrEmpty(txtNombreUsuario.Text) ? null : txtNombreUsuario.Text;
                trabajador.Password = string.IsNullOrEmpty(txtContrasenia.Text) ? null : txtContrasenia.Text;
                trabajador.Perfil = cmbPerfil.Text;

                string msg = "";

                // Si es una modificación (tipoOperacion = 1), pedimos confirmación como en carreras
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este trabajador?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = trabajador.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // Si es nuevo (tipoOperacion = 0), se guarda directo
                {
                    msg = trabajador.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrid(); // Refrescamos la tabla del formulario para ver los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Concatenación del mensaje de confirmación largo que se muestra en las capturas
            var respuesta = MessageBox.Show($"¿Estás completamente seguro de eliminar al trabajador: {idServicioM}?\nEsta acción borrará también su cuenta de usuario.", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    trabajador = new clsUsuarios();

                    trabajador.IdServicioM = idServicioM;

                    string resultado = trabajador.Eliminar();

                    MessageBox.Show(resultado, "El Trabajador y Usuario fueron eliminados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message, "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idServicioM = 0;

            trabajador.LimpiarPanel(pnlDiagnosticos);
        }
    }
}
