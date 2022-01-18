using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrónicos.Jupiter
{
    class Funciones
    {
        internal static string variableMensaje, variableConsola;

        private void MensajeError(string mensaje)
        {         

            Form frm = new Mensajes(mensaje);

            frm.ShowDialog();
        }
       
    }
}
