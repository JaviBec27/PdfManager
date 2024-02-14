using iTextSharp.text;
using iTextSharp.text.pdf;
using SwDividePDF.Negocio.Interface;
using System;
using System.ComponentModel;

namespace SwDividePDF.Negocio.Implementation
{
    public class PdfExtract : BaseClass, IPdfExtract
    {
        public PdfExtract() { }
        public PdfExtract(BackgroundWorker worker) : base(worker) { }

        /// <summary>
        /// Extrae una pagina de un PDF y la guarda en un nuevo archivo
        /// </summary>
        /// <param name="sourcePdfPath">Ruta donde se aloja el documento PDF</param>
        /// <param name="outputPdfPath">Ruta donde guardaremos el nuevo documento con la pagina estraída</param>
        /// <param name="pageNumber">Numero de la página que se extraerá</param>
        public void ExtractPages(string sourcePdfPath, string outputPdfPath, int pageNumber)
        {

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                using (var reader = new PdfReader(sourcePdfPath))
                {
                    // Capture the correct size and orientation for the page:
                    using (var document = new Document(reader.GetPageSizeWithRotation(pageNumber)))
                    {
                        // Initialize an instance of the PdfCopyClass with the source 
                        // document and an output file stream:
                        var pdfCopyProvider = new PdfCopy(document,
                            new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                        document.Open();

                        // Extract the desired page number:
                        var importedPage = pdfCopyProvider.GetImportedPage(reader, pageNumber);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        /// <summary>
        /// Extrae de un pdf las páginas indicadas
        /// </summary>
        /// <param name="sourcePdfPath">Ruta donde se aloja el documento PDF</param>
        /// <param name="outputPdfPath">Ruta donde guardaremos el nuevo documento con las páginas extraídas</param>
        /// <param name="startPage">Pagina inicial </param>
        /// <param name="endPage"></param>
        public void ExtractPages(string sourcePdfPath, string outputPdfPath, int startPage, int endPage)
        {

            if (outputPdfPath == sourcePdfPath)
                outputPdfPath = UtilidadesUE.Versionamiento.GetFullPathVersioning(outputPdfPath, UtilidadesUE.Versionamiento.VersioningType.Identity);

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                using (var reader = new PdfReader(sourcePdfPath))
                {
                    // For simplicity, I am assuming all the pages share the same size
                    // and rotation as the first page:
                    using (var sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
                    {
                        // Initialize an instance of the PdfCopyClass with the source 
                        // document and an output file stream:
                        var pdfCopyProvider = new PdfCopy(sourceDocument,
                            new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                        sourceDocument.Open();

                        // Walk the specified range and add the page copies to the output file:
                        for (int i = startPage; i <= endPage; i++)
                        {
                            var importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                            pdfCopyProvider.AddPage(importedPage);

                            if (worker != null)
                                worker.ReportProgress(i * 100 / endPage);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

    }
}
