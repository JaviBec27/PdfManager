using System;
using System.Collections.Generic;
using System.IO;
using SwDividePDF.Negocio.Model;

namespace SwDividePDF.Negocio.Service
{
    public static class FilePatternManager
    {
        /// <summary>
        /// Devuelve un archivo diccionario con el numero de kit y la cantidad de páginas; obtenidos desde el archivo de configuración de patrón 
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        public static Dictionary<int, int> GetDictionary(string sourcePath, bool hasHeader, char splitter)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            try
            {
                using (var sr = new StreamReader(sourcePath))
                {
                    if (hasHeader)
                        sr.ReadLine();


                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        var arrLine = line.Split(splitter);

                        if (arrLine.Length > 1)
                        {
                            var name = int.Parse(arrLine[0]);
                            var pags = int.Parse(arrLine[1]);
                            dictionary.Add(name, pags);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dictionary;
        }



        /// <summary>
        /// Devuelve un archivo diccionario con el numero de kit y la cantidad de páginas; obtenidos desde el archivo de configuración de patrón 
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        public static List<SplitPattern> GetFilePatternManagements(string sourcePath, bool hasHeader, char splitter)
        {
            var list = new List<SplitPattern>();

            try
            {
                using (var sr = new StreamReader(sourcePath))
                {
                    if (hasHeader)
                        sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        var arrLine = line.Split(splitter);

                        if (arrLine.Length > 1)
                        {
                            var name = arrLine[0];
                            var pags = int.Parse(arrLine[1]);
                            var sufix = arrLine[2];
                            list.Add(new SplitPattern() { Name = name, Pags = pags, Sufix = sufix });
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

    }
}
