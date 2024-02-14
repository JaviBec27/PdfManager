using SwDividePDF.Negocio.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            SplitterByPatternParams splitterParams = new SplitterByPatternParams()
            {
                PathFilePdf = TxtPathFilePdf.Text,
                ConfigurationOutputFile = new ConfigurationOutputFileParams { AddDateTimeNameSufix = ChkAddDateTime.Checked, Prefix = TxtPrefix.Text },
                ConfigurationPattern = new ConfigurationPatternParams { HasHeaders = ChkHeaders.Checked, PathFileSplitPattern = TxtPathFileSplitPattern.Text, SplitterPattern = Convert.ToChar(TxtSplitter.Text) }
            };

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(splitterParams);
            else
                UtilidadesUE.Mensajes.Mostrar("Ya se encuentra en ejecución otro proceso", UtilidadesUE.Mensajes.Tipos.Info);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            var parameters = (SplitterByPatternParams)e.Argument;
            ExecProcess(worker, parameters);
        }

        private void ExecProcess(BackgroundWorker worker, SplitterByPatternParams configParams)
        {
            try
            {

                var splitPatternList = Negocio.Service.PatternManager.GetSplitterPattern(configParams.ConfigurationPattern);
                if (!splitPatternList.Any())
                    throw new Exception("El archivo de configuración de división no se cargó correctamente");


                Negocio.Interface.IPdfPatternSplit pdf = new Negocio.Implementation.PdfPatternSplit(worker);

                pdf.SplitPagesByPattern(configParams.PathFilePdf, splitPatternList, configParams.ConfigurationOutputFile.Prefix);

                UtilidadesUE.Mensajes.Mostrar("Proceso Finalizado!", UtilidadesUE.Mensajes.Tipos.Info);
                Process.Start("explorer.exe", new System.IO.FileInfo(configParams.PathFilePdf).DirectoryName);
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
                TxtPathFileSplitPattern.Text = ofd.FileName;
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                TxtPathFilePdf.Text = ofd.FileName;
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
