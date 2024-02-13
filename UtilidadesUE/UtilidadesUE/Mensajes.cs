using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidadesUE
{
    /// <summary>
    /// 
    /// </summary>
    public static class Mensajes
    {
        public enum Tipos { Error, Info, Alerta }
        public enum Visualizacion { PopUp, Label }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje">mensaje a visualizar</param>
        /// <param name="tipo">determina el tipo de mensaje. Ejemplo: Error, información..</param>
        /// <param name="vista">Determina el tipo de visualizacion, si es una aventana emergente, o un mensaje de tipo </param>
        public static void Mostrar(string mensaje, Tipos tipo)
        {
            PopUp(ref mensaje, tipo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje">mensaje a visualizar</param>
        /// <param name="tipo">determina el tipo de mensaje. Ejemplo: Error, información..</param>
        /// <param name="vista">Determina el tipo de visualizacion, si es una aventana emergente, o un mensaje de tipo </param>
        public static void Mostrar(string mensaje, Tipos tipo, Visualizacion vista)
        {
            switch (vista)
            {
                case Visualizacion.PopUp:
                    PopUp(ref mensaje, tipo);
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="tipo"></param>
        /// <param name="ion"></param>
        private static void PopUp(ref string mensaje, Tipos tipo)
        {
            switch (tipo)
            {
                case Tipos.Error:
                    MessageBox.Show(mensaje, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Tipos.Info:
                    MessageBox.Show(mensaje, "Información!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification);
                    break;
                case Tipos.Alerta:
                    MessageBox.Show(mensaje, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }



    }
}
