using iTextSharp.text;
using iTextSharp.text.pdf;
using SwDividePDF.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SwDividePDF.Negocio.Implementation
{
    public class PdfSplit : BaseClass, IPdfSplit
    {
        public PdfSplit() { }
        public PdfSplit(BackgroundWorker worker) : base(worker) { }

        public void SplitPages(string sourcePdfPath, string outputPdfPath, int LengthPagexDocument)
        {
            SplitPages(sourcePdfPath, outputPdfPath, 1, LengthPagexDocument);
        }

        public void SplitPages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument)
        {
            int j = 0;
            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                //reader = new PdfReader(sourcePdfPath);
                using (PdfReader reader = new PdfReader(sourcePdfPath))
                {
                    var totalReadedPages = startPage - 1;
                    var ssPage = startPage - 1;
                    while (totalReadedPages < reader.NumberOfPages)
                    {
                        startPage = ssPage + 1 + (j * LengthPagexDocument);

                        // For simplicity, I am assuming all the pages share the same size
                        // and rotation as the first page:
                        using (var sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
                        {
                            // Initialize an instance of the PdfCopyClass with the source 
                            // document and an output file stream:
                            outputPdfPath = UtilidadesUE.Versionamiento.GetFullPathVersioning(sourcePdfPath, UtilidadesUE.Versionamiento.VersioningType.Identity);
                            var pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));
                            // Walk the specified range and add the page copies to the output file:
                            sourceDocument.Open();
                            for (int i = startPage; i <= (LengthPagexDocument + startPage - 1); i++)
                            {
                                var importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                                pdfCopyProvider.AddPage(importedPage);
                                totalReadedPages++;

                                if (worker != null)
                                {
                                    worker.ReportProgress(totalReadedPages * 100 / reader.NumberOfPages);
                                }
                            }
                            j++;
                        }
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
