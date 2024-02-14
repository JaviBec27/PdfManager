using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SwDividePDF.Negocio.Interface;
using UtilidadesUE;



namespace SwDividePDF.Negocio.Implementation
{
    public class PdfJoin : IPdfJoin
    {
        /// <summary>
        /// Obtiene un listado de PDF, los une y entrega el documento unido a la salida
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="outputPdfPath"></param>
        public void JoinPages(string sourcePath, string outputPdfPath)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(sourcePath);

            var files = dir.GetFiles("*.pdf");
            outputPdfPath = Versionamiento.GetFullPathVersioning(outputPdfPath, Versionamiento.VersioningType.FullPath_ddMMyy_hhmmss, "PdfJoined");

            var sourceDocument = new Document();

            try
            {
                // Initialize an instance of the PdfCopyClass with the source 
                using (var pdfCopyProvider = new PdfCopy(sourceDocument,
                    new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create)))
                {
                    sourceDocument.Open();
                    foreach (var item in files)
                    {
                        JoinPdf(item.FullName, pdfCopyProvider);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene el PDf de la fuente, lo lee y lo carga en el pdfCopyProvider para unirlo
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="outputPdfPath"></param>
        /// <param name="sourceDocument"></param>
        /// <param name="pdfCopyProvider"></param>
        private void JoinPdf(string sourcePdfPath, PdfCopy pdfCopyProvider)
        {

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                using (var reader = new PdfReader(sourcePdfPath))
                {
                    int endPage = reader.NumberOfPages;

                    // Walk the specified range and add the page copies to the output file:
                    for (int i = 1; i <= endPage; i++)
                    {
                        PdfImportedPage importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
