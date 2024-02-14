using iTextSharp.text;
using iTextSharp.text.pdf;
using SwDividePDF.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDividePDF.Negocio.Implementation
{
    internal class PdfPatternSplit : BaseClass, IPdfPatternSplit
    {
        public PdfPatternSplit() { }
        public PdfPatternSplit(BackgroundWorker worker) : base(worker) { }

        public void SplitPagesByDiccionary(string sourcePdfPath, Dictionary<int, int> divisorPattern, string pref, string name)
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

        public void SplitPagesByPattern(string sourcePdfPath, List<FilePatternManagement> filePatterns, string name)
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
                        using (var sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage)))
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

