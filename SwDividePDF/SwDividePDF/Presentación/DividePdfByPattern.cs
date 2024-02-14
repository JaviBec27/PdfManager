using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwDividePDF
{
    public partial class DividePdfByPattern : Form
    {
        public DividePdfByPattern()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var arr = new string[4];
            arr[0] = TxtPathPdf.Text;
            arr[1] = TxtDivisorPattern.Text;
            arr[2] = TxtNombre.Text;
            arr[3] = TxtPref.Text;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(arr);
            else
                UtilidadesUE.Mensajes.Mostrar("Ya se encuentra en ejecución otro proceso", UtilidadesUE.Mensajes.Tipos.Info);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            var parameters = (string[])e.Argument;
            ExecProcess(worker, parameters[0], parameters[1], parameters[2], parameters[3]);
        }

        private void ExecProcess(BackgroundWorker worker, string pdfPath, string divisorPatternPath, string nombre, string prefijo)
        {
            try
            {
                Negocio.Interface.IPdfPatternSplit pdf = new Negocio.Implementation.PdfPatternSplit(worker);
                pdf.SplitPagesByPattern(pdfPath, Negocio.ConfigPattern.GetFilePatternManagements(divisorPatternPath), nombre);

                UtilidadesUE.Mensajes.Mostrar("Proceso Finalizado!", UtilidadesUE.Mensajes.Tipos.Info);
            }
            catch (Exception ex)
            {
                UtilidadesUE.Mensajes.Mostrar(ex.Message, UtilidadesUE.Mensajes.Tipos.Error);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BtnDivisorPattern_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                TxtDivisorPattern.Text = ofd.FileName;
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                TxtPathPdf.Text = ofd.FileName;
        }

        private void ShowHelpMessage()
        {
            MessageBox.Show("KIT;PAGINAS;CORPORACION\n1;10;71\n2;25;71\n3;6;72\n4;15;73");
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelpMessage();
        }
    }
}
