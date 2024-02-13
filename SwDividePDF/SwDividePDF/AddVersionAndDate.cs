using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwDividePDF
{
    public partial class AddVersionAndDate : Form
    {
        public AddVersionAndDate()
        {
            InitializeComponent();
            TxtCreationDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPathPdf.Text))
            {
                UtilidadesUE.Mensajes.Mostrar("La ruta para el PDF es inválida!", UtilidadesUE.Mensajes.Tipos.Error);
                return;
            }

            SetVersions(TxtPathPdf.Text, TxtVersion.Text, TxtCreationDate.Text);
        }
        //TODO: DEBO REVISAR PORQUE ESTOY TRATANDO DE PONERLE VERSION Y FECHA DE CREACIÓN A UN PDF.....
        private void SetVersions(string inPath, string version, string fechaCreacion)
        {
            
            var outputPdfPath = UtilidadesUE.Versionamiento.GetFullPathVersioning(inPath, UtilidadesUE.Versionamiento.VersioningType.Identity, "Version");
            try
            {
                using (var reader = new PdfReader(inPath))
                {
                    using (var fileStream = new FileStream(outputPdfPath, FileMode.Create, FileAccess.Write))
                    {
                        var document = new Document(reader.GetPageSizeWithRotation(1));
                        var writer = PdfWriter.GetInstance(document, fileStream);

                        document.Open();

                        for (var i = 1; i <= reader.NumberOfPages; i++)
                        {
                            document.NewPage();

                            var baseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                            var importedPage = writer.GetImportedPage(reader, i);

                            var contentByte = writer.DirectContent;
                            contentByte.AddTemplate(importedPage, 0, 0);
                            contentByte.BeginText();
                            contentByte.SetFontAndSize(baseFont, 8);
                            contentByte.SetColorFill(new BaseColor(Color.Black));
                            BaseColor baseColor = new BaseColor(0, 0, 0);
                            contentByte.SetColorFill(baseColor);
                            var mytext = "VDOC: " + version + " - FECR: " + fechaCreacion;
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, mytext, document.PageSize.Right / 2, 20, 0);

                            contentByte.EndText();

                        }

                        document.Close();
                        writer.Close();
                    }
                }

                UtilidadesUE.Mensajes.Mostrar("Proceso Finalizado!", UtilidadesUE.Mensajes.Tipos.Info);
            }
            catch (Exception ex)
            {
                UtilidadesUE.Mensajes.Mostrar(ex.Message, UtilidadesUE.Mensajes.Tipos.Error);
                throw;
            }
        }


        private void SetVersion(string inPath, string version, string fechaCreacion)
        {
            var outputPdfPath = UtilidadesUE.Versionamiento.GetFullPathVersioning(inPath, UtilidadesUE.Versionamiento.VersioningType.Identity, "Version");

            using (var reader = new PdfReader(inPath))
            {
                var startPage = 1;
                var totalReadedPages = 0;
                var ssPage = 0;
                var j = 0;
                while (totalReadedPages < reader.NumberOfPages)
                {
                    startPage = ssPage + 1 + j;

                    // For simplicity, I am assuming all the pages share the same size
                    // and rotation as the first page:
                    using (Document document = new Document(reader.GetPageSizeWithRotation(startPage)))
                    {

                        using (FileStream fs = new FileStream(outputPdfPath, FileMode.Create, FileAccess.Write))
                        {

                            using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                            {
                                writer.Open();
                                document.Open();

                                // the pdf content
                                PdfContentByte cb = writer.DirectContent;

                                // select the font properties
                                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                cb.SetColorFill(BaseColor.DARK_GRAY);
                                cb.SetFontAndSize(bf, 8);

                                // write the text in the pdf content
                                cb.BeginText();
                                string text = "VDOC: " + version;
                                // put the alignment and coordinates here
                                cb.ShowTextAligned(1, text, 520, 640, 0);
                                cb.EndText();
                                cb.BeginText();
                                text = "FECR: " + fechaCreacion;
                                // put the alignment and coordinates here
                                cb.ShowTextAligned(2, text, 100, 200, 0);
                                cb.EndText();

                                // create the new page and add it to the pdf
                                PdfImportedPage page = writer.GetImportedPage(reader, 1);
                                cb.AddTemplate(page, 0, 0);
                                totalReadedPages++;

                                // close the streams and voilá the file should be changed :)
                                //document.Close();
                                //fs.Close();
                                //writer.Close();
                                //reader.Close();
                            }
                        }

                        j++;
                    }
                }
            }
            // open the reader





        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPathPdf.Text = ofd.FileName;
            }
        }
    }
}
