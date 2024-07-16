namespace SwDividePDF.Negocio.Interface
{
    /// <summary>
    /// Define las operaciones para extraer páginas de un archivo PDF.
    /// </summary>
    public interface IPdfExtract
    {
        /// <summary>
        /// Extrae una sola página de un archivo PDF y la guarda en un nuevo archivo PDF.
        /// </summary>
        /// <param name="sourceFilePath">Ruta del archivo PDF de origen.</param>
        /// <param name="outputFilePath">Ruta del archivo PDF de salida donde se guardará la página extraída.</param>
        /// <param name="pageNumber">Número de la página que se desea extraer.</param>
        void ExtractPage(string sourceFilePath, string outputFilePath, int pageNumber);

        /// <summary>
        /// Extrae un rango de páginas de un archivo PDF y las guarda en un nuevo archivo PDF.
        /// </summary>
        /// <param name="sourceFilePath">Ruta del archivo PDF de origen.</param>
        /// <param name="outputFilePath">Ruta del archivo PDF de salida donde se guardarán las páginas extraídas.</param>
        /// <param name="startPage">Número de la primera página del rango que se desea extraer.</param>
        /// <param name="endPage">Número de la última página del rango que se desea extraer.</param>
        void ExtractPages(string sourceFilePath, string outputFilePath, int startPage, int endPage);
    }
}

