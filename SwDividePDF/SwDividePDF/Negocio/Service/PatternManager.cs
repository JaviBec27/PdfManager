using System;
using System.Collections.Generic;
using System.IO;
using SwDividePDF.Negocio.Model;
using System.Linq;
using SwDividePDF.Negocio.Dto;

namespace SwDividePDF.Negocio.Service
{
    public static class PatternManager
    {
        /// <summary>
        /// Reads a file with a specific format and returns a collection of the desired data.
        /// </summary>
        /// <param name="sourcePath">The path to the file.</param>
        /// <param name="hasHeader">Indicates whether the file has a header line.</param>
        /// <param name="splitter">The character used to split lines in the file.</param>
        /// <param name="selector">A function that selects the desired data from each line.</param>
        /// <returns>A collection of the desired data extracted from the file.</returns>
        private static IEnumerable<T> ReadFile<T>(ConfigurationPatternParams patternParams, Func<string[], T> selector)
        {
            using (var sr = new StreamReader(patternParams.PathFileSplitPattern))
            {
                if (patternParams.HasHeaders)
                    sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var arrLine = line.Split(patternParams.SplitterPattern);

                    if (arrLine.Length > 1)
                        yield return selector(arrLine);
                }
            }
        }

        /// <summary>
        /// Returns a dictionary with the kit number and page count from a configuration file.
        /// </summary>
        /// <param name="sourcePath">The path to the configuration file.</param>
        /// <param name="hasHeader">Indicates whether the file has a header line.</param>
        /// <param name="splitter">The character used to split lines in the file.</param>
        /// <returns>A dictionary with the kit number and page count.</returns>
        public static Dictionary<int, int> GetSplitterDictionary(ConfigurationPatternParams patternParams)
        {
            return ReadFile(patternParams, line => new KeyValuePair<int, int>(int.Parse(line[0]), int.Parse(line[1]))).ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Devuelve una lista de objetos SplitPattern obtenidos desde el archivo de configuración cargado.
        /// </summary>
        /// <param name="sourcePath">The path to the configuration file.</param>
        /// <param name="hasHeader">Indicates whether the file has a header line.</param>
        /// <param name="splitter">The character used to split lines in the file.</param>
        /// <returns>A list of SplitPattern objects.</returns>
        public static List<SplitPattern> GetSplitterPattern(ConfigurationPatternParams patternParams)
        {
            return ReadFile(patternParams, line => new SplitPattern { Name = line[0], Pags = int.Parse(line[1]), Sufix = line[2] }).ToList();
        }
    }
}