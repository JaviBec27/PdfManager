using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UtilidadesUE
{
    /// <summary>
    /// Clase para gestionar la escritura de archivos
    /// </summary>
    public class EscrituraArchivos
    {
        /// <summary>
        /// Permite escribir Texto en cualquier formato aceptado por StreamWriter, hay que tener en cuenta que si el archivo no existe, se crea y este se sobreescribirá
        /// </summary>
        /// <param name="fullpath">Ruta física donde se encuentra el archivo, debe contener el nombre del archivo y su extension ejemplo: C:/ User/Texto.txt </param>
        /// <param name="data">información que se guardará en el archivo</param>
        /// <param name="isLine">permite definir si se escribirá una nueva linea de texto o se escribirá justo al final de la ultima cadena escrita en el texto</param>
        /// <param name="overWrite">permite definir si se sobreescribitá el texto, o se reemplazara la información por lo que contenga el parametro data</param>
        public static async void EscribirTexto(string fullpath, string data, bool isLine, bool overWrite)
        {
            if (string.IsNullOrEmpty(data))
                return;

            //Si la direccion o el arhivo no existe, se crean
            //CrearArchivoConDirectorio(fullpath);
          
            using (var sw = new StreamWriter(fullpath, overWrite, Encoding.Default))
            {
                try
                {
                    if (isLine)
                    {
                        await sw.WriteLineAsync(data);
                    }
                    else
                    {
                        await sw.WriteAsync(data);
                    }
                }
                catch
                {

                }
                finally
                {
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Permite escribir Texto en cualquier formato aceptado por StreamWriter, hay que tener en cuenta que si el archivo no existe, se crea y este se sobreescribirá
        /// </summary>
        /// <param name="fullpath">Ruta física donde se encuentra el archivo, debe contener el nombre del archivo y su extension ejemplo: C:/ User/Texto.txt </param>
        /// <param name="data">información que se guardará en el archivo</param>
        /// <param name="isLine">permite definir si se escribirá una nueva linea de texto o se escribirá justo al final de la ultima cadena escrita en el texto</param>
        /// <param name="overWrite">permite definir si se sobreescribirá el texto, o se reemplazara la información por lo que contenga el parametro data</param>
        /// <param name="encoder">permite definir el tipo de codificación de caracteres para el archivo</param>
        public static void EscribirTexto(string fullpath, string data, bool isLine, bool overWrite, Encoding encoder)
        {
            if (string.IsNullOrEmpty(data))
                return;

            using (var sw = new StreamWriter(fullpath, overWrite, encoder))
            {
                try
                {
                    if (isLine)
                        sw.WriteLine(data);
                    else
                        sw.Write(data);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Permite crear un arhivo
        /// </summary>
        /// <param name="fullpath">Ruta física donde debe construirse el archivo, debe contener el nombre del archivo y su extension ejemplo: C:/ User/Texto.txt </param>
        public static void CrearArchivoConDirectorio(string fullpath)
        {
            FileInfo fi = new FileInfo(fullpath);
            if (!fi.Exists)
            {
                DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
                if (!di.Exists)
                {
                    di.Create();
                }

                var o = File.Create(fullpath);
                o.Close();
            }
        }
    }
}
