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
            mostrarDatosUsuario(clsLogin.nombreUsuarioLogeado, clsLogin.apellidoPaUsuarioLogeado, clsLogin.apellidoMaUsuarioLogeado, clsLogin.perfil);
            principal.AgregarAlContenedor(new frmInicio(), pnlContenedor);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmInicio(), pnlContenedor);
        }

        private void btnInicioSideBar_Click(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmInicio(), pnlContenedor);
        }

        private void btnPacientesSideBar_Click(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmPacientes(), pnlContenedor);
        }

        private void btnConsultasSideBar_Click(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmConsultas(), pnlContenedor);
        }

        private void btnAdministracionSideBar_Click(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmAdministracion(), pnlContenedor);
        }

        private void mostrarDatosUsuario(string nombre, string apellidoP, string apellidoM, string perfil)
        {
            lblNombreUsuarioSideBar.Text = $"{nombre} {apellidoP} {apellidoM}";
            lblRolUsuarioSideBar.Text = $"{perfil}";
        }

        private void button2_Click(object sender, EventArgs e)

        {

        }

        private void btnCerrarSesionSideBar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReortes_Click(object sender, EventArgs e)
        {
            principal.AgregarAlContenedor(new frmReportes(), pnlContenedor);

        }
    }
}