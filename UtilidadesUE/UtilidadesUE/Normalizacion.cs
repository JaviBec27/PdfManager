using System.Collections.Generic;
using System.Collections;

namespace UtilidadesUE
{
    public class Normalizacion
    {
        /// <summary>
        /// Permite dividir un string en una estructura definida en una lista generica de enteros
        /// </summary>
        /// <param name="cadena"> texto con el contenido de informacion a dividir</param>
        /// <param name="paramDivision">lista de enteros con los limites superiores como se dividira el texto</param>
        /// <remarks>
        ///         cadena=122334
        ///         paramDivision=[2 2 2]
        ///         retorno = [12 23 34]
        /// </remarks>
        /// <returns>retorna un arreglo con la estructura dividida, Nota: No tiene eliminacion de espacios</returns>
        static public ArrayList DividirEstructura(string cadena, IEnumerable<int> paramDivision)
        {
            var data = new ArrayList();
            var acum = 0;
            foreach (int i in paramDivision)
            {
                var newString = cadena.Substring(acum, i);
                acum += i;
                data.Add(newString);
            }

            return data;
        }
    }
}
