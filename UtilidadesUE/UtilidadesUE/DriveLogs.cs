using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtilidadesUE
{
    public class DriveLogs
    {
        public string ErrorMensaje;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="fileName"></param>
        /// <param name="title"></param>
        public static void EscrituraLogs(string mensaje, string fileName, string title)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE");
            path += "/" + fileName + ".txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("******* ").Append(title).Append(" - ").Append(DateTime.Now.ToString("dd/MM/yy hh:mm:ss")).Append(" *******");
                    sw.WriteLine(sb.ToString());
                    sw.WriteLine(mensaje);
                    sw.WriteLine(Environment.NewLine);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Permite la escritura de logs, enviando una ruta completa
        /// </summary>
        /// <param name="mensaje">mensaje que se logueará</param>
        /// <param name="fullpath">directorio completo con nombre del archivo donde se guardará el log</param>
        /// <param name="title">titulo que llevará el log</param>
        /// <param name="append">determina si se sobreescribirá el archivo o se anexará en la siguiente línea</param>
        public static void EscrituraLogs(string mensaje, string fullpath, string title, bool append)
        {
            FileInfo finfo = new FileInfo(fullpath);
            if (string.IsNullOrEmpty(finfo.Extension))
            {
                fullpath += ".txt";    
            }

            using (StreamWriter sw = new StreamWriter(fullpath, append))
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("******* ").Append(title).Append(" - ").Append(DateTime.Now.ToString("dd/MM/yy hh:mm:ss")).Append(" *******");
                    sw.WriteLine(sb.ToString());
                    sw.WriteLine(mensaje);
                    sw.WriteLine(Environment.NewLine);
                }
                finally
                {
                    sw.Close();
                }
            }
        }
    }
}
