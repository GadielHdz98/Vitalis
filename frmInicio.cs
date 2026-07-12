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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            MostrarSaludo("Luis Gadiel", "Doctor");
            
        }
        private void MostrarSaludo(string nombreUsuario, string rolUsuario)
        {
            int hora = DateTime.Now.Hour;
            string saludo;
            string nombreCompleto;

            if (hora < 12)
            {
                saludo = "Buenos días";
            }
            else if (hora < 20)
            {
                saludo = "Buenas tardes";
            }
            else
            {
                saludo = "Buenas noches";
            }

            switch (rolUsuario)
            {
                case "Doctor":
                    nombreCompleto = $"Dr. {nombreUsuario}";
                    break;

                case "Enfermero":
                    nombreCompleto = $"Enf. {nombreUsuario}";
                    break;

                default:
                    nombreCompleto = nombreUsuario;
                    break;
            }
            
            lblMensajeBienvenidaInicio.Text = $"{saludo}, {nombreCompleto}";
            
        }
    }
}
