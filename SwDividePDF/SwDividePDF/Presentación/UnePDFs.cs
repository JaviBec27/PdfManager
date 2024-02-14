using SwDividePDF.Negocio.Interface;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SwDividePDF
{
    public partial class UnePDFs : Form
    {
        public UnePDFs()
        {
            InitializeComponent();
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = fbd.SelectedPath;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var pathOut = GetOutPath();
            if (string.IsNullOrEmpty(pathOut))
            {
                UtilidadesUE.Mensajes.Mostrar("Nombre de archivo destino, inválido!", UtilidadesUE.Mensajes.Tipos.Error, UtilidadesUE.Mensajes.Visualizacion.PopUp);
                return;
            }

            UnirPDF(TxtPath.Text, pathOut);
        }


        private string GetOutPath()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.pdf|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
                return sfd.FileName;

            return "";
        }

        private void UnirPDF(string pathIn, string pathOut)
        {
            IPdfJoin pdfo = new Negocio.Implementation.PdfJoin();

            try
            {
                pdfo.JoinPages(pathIn, pathOut);
                UtilidadesUE.Mensajes.Mostrar("PDFs Unidos", UtilidadesUE.Mensajes.Tipos.Info, UtilidadesUE.Mensajes.Visualizacion.PopUp);
                Process.Start("explorer.exe", pathIn);
            }
            catch (Exception ex)
            {
                UtilidadesUE.Mensajes.Mostrar(ex.Message, UtilidadesUE.Mensajes.Tipos.Error, UtilidadesUE.Mensajes.Visualizacion.PopUp);
            }
        }       

        private void UnePDFs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
