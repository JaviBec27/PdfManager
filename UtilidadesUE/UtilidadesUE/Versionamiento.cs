using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtilidadesUE
{
    public class Versionamiento
    {
        /// <summary>
        /// Especifica los tipos de complementos de nombres de archivos usados para versionamiento de los mismos  
        /// </summary>
        public enum VersioningType
        {
            /// <summary>
            /// Formato de extension para nombre de archivos FileNameddMMyy hhmmss, ejemplo: fileName010115 125959
            /// </summary>
            FullPath_ddMMyy_hhmmss,
            /// <summary>
            /// Formato de extension para nombre de arhivos FileNameyyMMss hhmmss, ejemplo: fileName150101 125959
            /// </summary>
            FullPath_yyMMdd_hhmmss,
            /// <summary>
            /// Formato de extension para nombre de archivos FileName(n), ejemplo: FileName(9)
            /// </summary>
            Identity
        }

        /// <summary>
        /// Genera un nombre con una nueva version para el directorio en cuestion, Nota: No devuelve la ruta solo el nombre. Ejemplo: fileName(1), fileName_010101-125959
        /// </summary>
        /// <param name="path">ruta fisica donde se encuentra el archivo al cual se le realizará versionamiento</param>
        /// <param name="version">tipo de complemento con que se realizará versionamiento</param>
        /// <returns></returns>
        public static string GetFullPathVersioning(string path, VersioningType version)
        {
            FileInfo fi = new FileInfo(path);
            var newPath = string.Empty;
            switch (version)
            {
                case VersioningType.FullPath_ddMMyy_hhmmss:
                    newPath = GetFullPathVersioningDate_ddMMyy(path, "");
                    break;
                case VersioningType.FullPath_yyMMdd_hhmmss:
                    newPath = GetFullPathVersioningDate_yyyMMdd(path, "");
                    break;
                case VersioningType.Identity:
                    newPath = GetFullPathVersioningIdentity(fi, "");
                    break;
                default: newPath = fi.FullName;
                    break;
            }
            return newPath;
        }

        /// <summary>
        /// Genera un nombre con una nueva version para el directorio en cuestion.
        /// </summary>
        /// <param name="path">ruta fisica donde se encuentra el archivo al cual se le realizará versionamiento</param>
        /// <param name="version">tipo de complemento con que se realizará versionamiento</param>
        /// <param name="prefijo">Prefijo del nombre si es </param>
        /// <returns></returns>
        public static string GetFullPathVersioning(string path, VersioningType version, string prefijo)
        {
            FileInfo fi = new FileInfo(path);
            var newPath = string.Empty;
            switch (version)
            {
                case VersioningType.FullPath_ddMMyy_hhmmss:
                    newPath = GetFullPathVersioningDate_ddMMyy(path, prefijo);
                    break;
                case VersioningType.FullPath_yyMMdd_hhmmss:
                    newPath = GetFullPathVersioningDate_yyyMMdd(path, prefijo);
                    break;
                case VersioningType.Identity:
                    newPath = GetFullPathVersioningIdentity(fi, prefijo);
                    break;
                default: newPath = fi.FullName;
                    break;
            }
            return newPath;
        }

        /// <summary>
        /// Asigna el complemento al nombre para versionamiento con formato ddMMyy hhmmss
        /// </summary>
        /// <param name="path">ruta del arhivo al cual se le hará versionamiento</param>
        /// <returns>cadena con la ruta completa</returns>
        private static string GetFullPathVersioningDate_ddMMyy(string path, string prefijo)
        {
            if (!string.IsNullOrWhiteSpace(prefijo))
                prefijo += "_";

            FileInfo fi = new FileInfo(path);
            var name = ValidacionFormatos.GetNombreWithOutVersion(fi.Name.Replace(fi.Extension, ""), VersioningType.FullPath_ddMMyy_hhmmss);
            StringBuilder sb = new StringBuilder();
            sb.Append(fi.DirectoryName).Append(@"\");
            sb.Append(prefijo);
            sb.Append(name).Append("_");
            sb.Append(DateTime.Now.ToString("ddMMyy_hhmmss"));
            sb.Append(fi.Extension);

            return sb.ToString();
        }

        /// <summary>
        /// Asigna el complemento al nombre para versionamiento con formato yyMMdd hhmmss
        /// </summary>
        /// <param name="path"></param>
        /// <returns>cadena con la ruta completa del </returns>
        private static string GetFullPathVersioningDate_yyyMMdd(string path, string prefijo)
        {
            if (!string.IsNullOrWhiteSpace(prefijo))
                prefijo += "_";

            FileInfo fi = new FileInfo(path);
            var name = ValidacionFormatos.GetNombreWithOutVersion(fi.Name.Replace(fi.Extension, ""), VersioningType.FullPath_yyMMdd_hhmmss);
            StringBuilder sb = new StringBuilder();
            sb.Append(fi.DirectoryName).Append(@"\");
            sb.Append(prefijo);
            sb.Append(name).Append("_");
            sb.Append(DateTime.Now.ToString("yyMMdd_hhmmss"));
            sb.Append(fi.Extension);

            return sb.ToString();
        }

        /// <summary>
        /// /// Asigna el complemento al nombre para versionamiento con formato (n)
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        private static string GetFullPathVersioningIdentity(FileInfo fi, string prefijo)
        {
            if (!string.IsNullOrWhiteSpace(prefijo))
                prefijo += "_";

            StringBuilder newFile = new StringBuilder();
            var dir = fi.DirectoryName;
            var ext = fi.Extension;
            var name = fi.Name.Replace(ext, "");
            newFile.Append(dir).Append(@"\");
            newFile.Append(name);
            newFile.Append(ext);

            int vers = 1;
            while (fi.Exists)
            {
                newFile.Clear();
                newFile.Append(dir).Append(@"\");
                newFile.Append(prefijo);
                newFile.Append(string.Format(@"{0}({1})", ValidacionFormatos.GetNombreWithOutVersion(name, VersioningType.Identity), vers));
                newFile.Append(ext);

                fi = new FileInfo(newFile.ToString());
                vers++;
            }

            return newFile.ToString();
        }
    }
}
