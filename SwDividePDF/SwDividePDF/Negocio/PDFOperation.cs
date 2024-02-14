using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using SwDividePDF.Negocio.Interface;
using System.ComponentModel;


namespace SwDividePDF.Negocio
{
    public class PDFOperation : BaseClass
    {       

        public PDFOperation() { }
        public PDFOperation(BackgroundWorker worker):base(worker) { }

        
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
            //PdfReader reader = null;
            //Document sourceDocument = null;
            // PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

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
                            importedPage = pdfCopyProvider.GetImportedPage(reader, i);
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

        /// <summary>
        /// Toma todo el documento y lo divide en la cantidad de paginas indicadas
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="outputPdfPath"></param>
        /// <param name="startPage"></param>
        /// <param name="LengthPagexDocument"></param>
        public void DividePages(string sourcePdfPath, string outputPdfPath, int LengthPagexDocument)
        {
            DividePages(sourcePdfPath, outputPdfPath, 1, LengthPagexDocument);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="outputPdfPath"></param>
        /// <param name="startPage"></param>
        /// <param name="LengthPagexDocument"></param>
        public virtual void DividePages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument)
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
                        using (Document sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="outputPdfPath"></param>
        public void UnePdf(string sourcePath, string outputPdfPath)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(sourcePath);

            var files = dir.GetFiles("*.pdf");
            outputPdfPath = UtilidadesUE.Versionamiento.GetFullPathVersioning(outputPdfPath, UtilidadesUE.Versionamiento.VersioningType.FullPath_ddMMyy_hhmmss, "MergedPDF");

            Document sourceDocument = new Document(); ;
            PdfCopy pdfCopyProvider = null;

            try
            {
                // Initialize an instance of the PdfCopyClass with the source 
                pdfCopyProvider = new PdfCopy(sourceDocument,
                    new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));
                sourceDocument.Open();
                foreach (var item in files)
                {
                    UnePdf(item.FullName, outputPdfPath, ref sourceDocument, ref pdfCopyProvider);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sourceDocument.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="outputPdfPath"></param>
        /// <param name="sourceDocument"></param>
        /// <param name="pdfCopyProvider"></param>
        private void UnePdf(string sourcePdfPath, string outputPdfPath, ref Document sourceDocument, ref PdfCopy pdfCopyProvider)
        {
            PdfImportedPage importedPage = null;

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                using (var reader = new PdfReader(sourcePdfPath))
                {
                    int endPage = reader.NumberOfPages;

                    // Walk the specified range and add the page copies to the output file:
                    for (int i = 1; i <= endPage; i++)
                    {
                        importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="divisorPattern"></param>
        /// <param name="pref"></param>
        /// <param name="name"></param>
        public void DividePagesxPattern(string sourcePdfPath, Dictionary<int, int> divisorPattern, string pref, string name)
        {
            //Inicia desde la primera página
            int startPage = 1;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            var fi = new System.IO.FileInfo(sourcePdfPath);
            var rootOutPath = fi.DirectoryName + "/OUT";
            if (!System.IO.Directory.Exists(rootOutPath))
                System.IO.Directory.CreateDirectory(rootOutPath);

            try
            {
                var totalReadedPages = 0;
                var totalCreatedDocs = 0;//(Cantidad de Documentos creados)

                // Inicializamos una nueva instancia  de PdfReader con la ruta del PDF Fuente.                
                using (PdfReader reader = new PdfReader(sourcePdfPath))
                {
                    var numpage = reader.NumberOfPages;//Obtengo el número de páginas del documento

                    if (divisorPattern.Sum(x => x.Value) > numpage)
                        throw new Exception("El listado solicitado contiene mas páginas que el documento.");

                    foreach (var kit in divisorPattern)//Llave: KIT; Valor: Páginas
                    {
                        //Abro un nuevo documento desde la página de inicio indicada
                        using (Document sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
                        {
                            // Initialize an instance of the PdfCopyClass with the source 
                            // document and an output file stream:
                            var filename = $"{name}_{kit}_{pref}.pdf";
                            var outputPdfPath = System.IO.Path.Combine(rootOutPath, filename);
                            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));
                            // Walk the specified range and add the page copies to the output file:
                            sourceDocument.Open();
                            for (int i = startPage; i <= (kit.Value + startPage - 1); i++)//kit.value contiene la cantidad de páginas del kit
                            {
                                importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                                pdfCopyProvider.AddPage(importedPage);
                                totalReadedPages++;
                            }
                            totalCreatedDocs++;
                        }

                        if (worker != null)
                        {
                            worker.ReportProgress((totalCreatedDocs) * 100 / divisorPattern.Count);
                        }

                        startPage = totalReadedPages + 1;//Aqui debo calcular la pagina actual de inicio

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //ErrorMessage = ex.Message;
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePdfPath"></param>
        /// <param name="divisorPattern"></param>
        /// <param name="pref"></param>
        /// <param name="name"></param>
        public void DividePagesxPattern2(string sourcePdfPath, List<FilePatternManagement> filePatterns, string name)
        {
            //Inicia desde la primera página
            int startPage = 1;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            var fi = new System.IO.FileInfo(sourcePdfPath);
            var rootOutPath = fi.DirectoryName + "/OUT";
            if (!System.IO.Directory.Exists(rootOutPath))
                System.IO.Directory.CreateDirectory(rootOutPath);

            try
            {
                var totalReadedPages = 0;
                var totalCreatedDocs = 0;//(Cantidad de Documentos creados)

                // Inicializamos una nueva instancia  de PdfReader con la ruta del PDF Fuente.                
                using (PdfReader reader = new PdfReader(sourcePdfPath))
                {
                    var numpage = reader.NumberOfPages;//Obtengo el número de páginas del documento

                    if (filePatterns.Sum(x => x.Paginas) > numpage)
                        throw new Exception("El listado solicitado contiene mas páginas que el documento.");

                    foreach (var form in filePatterns)//KIT; Páginas; Corporacion
                    {
                        //Abro un nuevo documento desde la página de inicio indicada
                        using (Document sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
                        {
                            // Initialize an instance of the PdfCopyClass with the source 
                            // document and an output file stream:
                            var filename = $"{name}_{form.Kit}_{form.Corporacion}.pdf";
                            var outputPdfPath = System.IO.Path.Combine(rootOutPath, filename);
                            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));
                            // Walk the specified range and add the page copies to the output file:
                            sourceDocument.Open();
                            for (int i = startPage; i <= (form.Paginas + startPage - 1); i++)//kit.value contiene la cantidad de páginas del kit
                            {
                                importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                                pdfCopyProvider.AddPage(importedPage);
                                totalReadedPages++;
                            }
                            totalCreatedDocs++;
                        }

                        if (worker != null)
                        {
                            worker.ReportProgress((totalCreatedDocs) * 100 / filePatterns.Count);
                        }

                        startPage = totalReadedPages + 1;//Aqui debo calcular la pagina actual de inicio

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //ErrorMessage = ex.Message;
            }
            finally
            {
                GC.Collect();
            }
        }


    }
}
