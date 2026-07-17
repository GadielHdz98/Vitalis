using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalis
{
    internal class clsAdministracion
    {
        Form misFormsAbiertos = null;
        
        public void AgregarAlContenedor(Form formulario, Panel panel)
        {
            //Verifica que no este abierto ningun form, y si lo hay, lo cierre
            if (misFormsAbiertos != null)
            {
                misFormsAbiertos.Close();
                misFormsAbiertos.Dispose();
            }
            //Guardamos la referencia del formulario nuevo a mostrar
            misFormsAbiertos = formulario;

            //Configurar propiedades de comportamiento y visualizacion del form
            formulario.TopLevel = false; //Le quitamos el comportamiento de una ventana normal de windows
            formulario.FormBorderStyle = FormBorderStyle.None; //sin bordes
            formulario.Dock = DockStyle.Fill; //Llenar todo el espacio sin usar del panel

            //Incrustar en el panel donde se mostrara segun el parametro del metodo
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            panel.BringToFront();

            //Mostrar formulario
            formulario.Show();
        }
    }
}
