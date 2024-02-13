using System;
using System.Collections.Generic;
using System.IO;

namespace SwDividePDF.Negocio
{
    public static class ConfigPattern
    {
        /// <summary>
        /// Devuelve un archivo diccionario con el numero de kit y la cantidad de páginas; obtenidos desde el archivo de configuración de patrón 
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        public static Dictionary<int, int> GetDictionary(string sourcePath)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            try
            {
                using (var sr = new StreamReader(sourcePath))
                {
                    var header = sr.ReadLine();
                    if (!HeaderValidator(header))
                        throw new Exception("Header Invalido!. Solo se acepta este header: KIT;PAGINAS ");

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        var arrLine = line.Split(';');

                        if (arrLine.Length > 1)
                        {
                            var kit = int.Parse(arrLine[0]);
                            var pags = int.Parse(arrLine[1]);
                            dic.Add(kit, pags);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dic;
        }

        /// <summary>
        /// Devuelve un archivo diccionario con el numero de kit y la cantidad de páginas; obtenidos desde el archivo de configuración de patrón 
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        public static List<FilePatternManagement> GetFilePatternManagements(string sourcePath)
        {
            var list = new List<FilePatternManagement>();

            try
            {
                using (var sr = new StreamReader(sourcePath))
                {
                    var header = sr.ReadLine();
                    if (!HeaderValidator(header))
                        throw new Exception("Header Invalido!. Solo se acepta este header: KIT;PAGINAS;CORPORACION ");

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        var arrLine = line.Split(';');

                        if (arrLine.Length > 1)
                        {
                            var kit = arrLine[0];
                            var pags = int.Parse(arrLine[1]);
                            var corp = arrLine[2];
                            list.Add(new FilePatternManagement() { Kit = kit, Paginas = pags, Corporacion = corp });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        private static bool HeaderValidator(string line)
        {
            if (line == "KIT;PAGINAS" || line == "KIT;PAGINAS;CORPORACION")            
                return true;           

            return false;
        }
    }

    public class FilePatternManagement
    {
        public string Kit { get; set; }
        public int Paginas { get; set; }
        public string Corporacion { get; set; }
    }
}
