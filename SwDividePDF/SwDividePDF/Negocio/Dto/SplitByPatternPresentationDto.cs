using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDividePDF.Negocio.Dto
{
    public class SplitterByPatternParams
    {
        /// <summary>
        /// Ruta del pdf a dividir
        /// </summary>
        public string PathFilePdf { get; set; }


        /// <summary>
        /// Configuraciones del archivo patrón
        /// </summary>
        public ConfigurationPatternParams ConfigurationPattern { get; set; }

        /// <summary>
        /// Configuraciones adicionales del archivo de salida
        /// </summary>
        public ConfigurationOutputFileParams ConfigurationOutputFile { get; set; }

    }

    public class ConfigurationPatternParams
    {
        /// <summary>
        /// ruta del archivo patrón de división
        /// </summary>
        public string PathFileSplitPattern { get; set; }

        /// <summary>
        /// caracter de división dentro del archivo
        /// </summary>
        public char SplitterPattern { get; set; }

        /// <summary>
        /// indica si el archivo contiene o no cabeceras
        /// </summary>
        public bool HasHeaders { get; set; }

    }

    public class ConfigurationOutputFileParams
    {
        /// <summary>
        /// Texto del prefijo
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// indica si desea agreagra la fecha y hora como sufijo al nombre de cada pdf
        /// </summary>
        public bool AddDateTimeNameSufix { get; set; }
    }
}
