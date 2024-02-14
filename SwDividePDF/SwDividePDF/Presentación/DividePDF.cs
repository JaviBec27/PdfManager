using SwDividePDF.Negocio.Interface;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace SwDividePDF
{
    public partial class DividePDF : Form
    {
        private string MENSAJE_DIVIDIR = "Permite Dividir el PDF de a X páginas";
        private string MENSAJE_EXTRAER = "Permite extraer del PDF las páginas entre una Página Inicial y una Final";

        public DividePDF()
        {
            InitializeComponent();
            LblMessage.Text = MENSAJE_EXTRAER;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ExecProcess(BackgroundWorker worker)
        {
            try
            {
                var sourcepath = TxtPath.Text;
                var outpath = UtilidadesUE.Versionamiento.GetFullPathVersioning(sourcepath, UtilidadesUE.Versionamiento.VersioningType.FullPath_ddMMyy_hhmmss);

                int pagIn = 0;
                int pagFin = 0;

                if (!int.TryParse(TxtPagInicial.Text, out pagIn) || pagIn <= 0)
                {
                    MessageBox.Show("Error pagina inicial");
                    return;
                }

                if ((!int.TryParse(TxtPagFinal.Text, out pagFin) || pagFin <= 0))
                {
                    MessageBox.Show("Error pagina Final");
                    return;
                }



                if (ChkExtraer.Checked)
                {
                    if (pagFin < pagIn)
                    {
                        UtilidadesUE.Mensajes.Mostrar("La página inicial debe ser menor o igual que la final", UtilidadesUE.Mensajes.Tipos.Error, UtilidadesUE.Mensajes.Visualizacion.PopUp);
                        return;
                    }
                    IPdfExtract pdfExtract = new Negocio.Implementation.PdfExtract(worker);
                    ExtractPage(pdfExtract, sourcepath, pagIn, pagFin);
                }
                else
                {
                    IPdfSplit pdfSplit = new Negocio.Implementation.PdfSplit(worker);
                    DividePage(pdfSplit, sourcepath, pagIn, pagFin);
                }

                UtilidadesUE.Mensajes.Mostrar("PDF Dividido!", UtilidadesUE.Mensajes.Tipos.Info, UtilidadesUE.Mensajes.Visualizacion.PopUp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExtractPage(IPdfExtract pdf, string sourcepath, int ini, int fin)
        {
            pdf.ExtractPages(sourcepath, sourcepath, ini, fin);
        }

        private void DividePage(IPdfSplit pdf, string sourcepath, int ini, int fin)
        {
            try
            {
                pdf.SplitPages(sourcepath, sourcepath, ini, fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Obtiene la ruta donde se encuentra el PDF a dividir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = ofd.FileName;
            }
        }


        /// <summary>
        /// Modifica el escenario para  D I V I D I R
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkDividir_CheckedChanged(object sender, EventArgs e)
        {
            GroupPagIni.Text = "Desde la página";

            GroupPagFin.Text = "De x en x hasta el fin";
            BtnSend.Text = "Dividir";
            LblMessage.Text = MENSAJE_DIVIDIR;

        }

        /// <summary>
        /// Modifica el escenario para  E X T R A E R
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkExtraer_CheckedChanged(object sender, EventArgs e)
        {
            GroupPagIni.Text = "Página Inicial";
            LblMessage.Text = MENSAJE_EXTRAER;

            GroupPagFin.Text = "Página Final";
            BtnSend.Text = "Extraer";
        }


        #region ValidaNumerEnTexto_Entrada
        private void TxtPagInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeys(e);
        }

        private void TxtPagFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeys(e);
        }


        private void ValidateKeys(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void DividePDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            ExecProcess(worker);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }


}
