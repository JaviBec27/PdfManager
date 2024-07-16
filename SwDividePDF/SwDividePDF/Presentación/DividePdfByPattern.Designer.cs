namespace SwDividePDF
{
    partial class DividePdfByPattern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupPagIni = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkAddDateTime = new System.Windows.Forms.CheckBox();
            this.TxtPrefix = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkHeaders = new System.Windows.Forms.CheckBox();
            this.BtnDownloadExample = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSplitter = new System.Windows.Forms.TextBox();
            this.BtnDivisorPattern = new System.Windows.Forms.Button();
            this.TxtPathFileSplitPattern = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPathFilePdf = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupPagIni.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPagIni
            // 
            this.GroupPagIni.Controls.Add(this.label1);
            this.GroupPagIni.Controls.Add(this.ChkAddDateTime);
            this.GroupPagIni.Controls.Add(this.TxtPrefix);
            this.GroupPagIni.Location = new System.Drawing.Point(719, 191);
            this.GroupPagIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagIni.Name = "GroupPagIni";
            this.GroupPagIni.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagIni.Size = new System.Drawing.Size(359, 285);
            this.GroupPagIni.TabIndex = 14;
            this.GroupPagIni.TabStop = false;
            this.GroupPagIni.Text = "Configuración general salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prefijo para PDFs";
            // 
            // ChkAddDateTime
            // 
            this.ChkAddDateTime.AutoSize = true;
            this.ChkAddDateTime.Location = new System.Drawing.Point(18, 55);
            this.ChkAddDateTime.Name = "ChkAddDateTime";
            this.ChkAddDateTime.Size = new System.Drawing.Size(255, 24);
            this.ChkAddDateTime.TabIndex = 3;
            this.ChkAddDateTime.Text = "Agregar sufijo fecha al nombre ";
            this.ChkAddDateTime.UseVisualStyleBackColor = true;
            // 
            // TxtPrefix
            // 
            this.TxtPrefix.Location = new System.Drawing.Point(8, 152);
            this.TxtPrefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrefix.Name = "TxtPrefix";
            this.TxtPrefix.Size = new System.Drawing.Size(327, 26);
            this.TxtPrefix.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkHeaders);
            this.groupBox2.Controls.Add(this.BtnDownloadExample);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtSplitter);
            this.groupBox2.Controls.Add(this.BtnDivisorPattern);
            this.groupBox2.Controls.Add(this.TxtPathFileSplitPattern);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(699, 285);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración  patrón de división";
            // 
            // ChkHeaders
            // 
            this.ChkHeaders.AutoSize = true;
            this.ChkHeaders.Checked = true;
            this.ChkHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkHeaders.Location = new System.Drawing.Point(316, 177);
            this.ChkHeaders.Name = "ChkHeaders";
            this.ChkHeaders.Size = new System.Drawing.Size(189, 24);
            this.ChkHeaders.TabIndex = 11;
            this.ChkHeaders.Text = "Contiene Cabeceras?";
            this.ChkHeaders.UseVisualStyleBackColor = true;
            // 
            // BtnDownloadExample
            // 
            this.BtnDownloadExample.Location = new System.Drawing.Point(8, 224);
            this.BtnDownloadExample.Name = "BtnDownloadExample";
            this.BtnDownloadExample.Size = new System.Drawing.Size(150, 43);
            this.BtnDownloadExample.TabIndex = 10;
            this.BtnDownloadExample.Text = "Ejemplo patrón\r\n";
            this.BtnDownloadExample.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Separador ( ; , . - | etc)";
            // 
            // TxtSplitter
            // 
            this.TxtSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSplitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSplitter.Location = new System.Drawing.Point(184, 171);
            this.TxtSplitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSplitter.Name = "TxtSplitter";
            this.TxtSplitter.Size = new System.Drawing.Size(72, 30);
            this.TxtSplitter.TabIndex = 9;
            this.TxtSplitter.Text = ";";
            // 
            // BtnDivisorPattern
            // 
            this.BtnDivisorPattern.Location = new System.Drawing.Point(8, 91);
            this.BtnDivisorPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDivisorPattern.Name = "BtnDivisorPattern";
            this.BtnDivisorPattern.Size = new System.Drawing.Size(181, 45);
            this.BtnDivisorPattern.TabIndex = 7;
            this.BtnDivisorPattern.Text = "Buscar archivo patrón";
            this.BtnDivisorPattern.UseVisualStyleBackColor = true;
            this.BtnDivisorPattern.Click += new System.EventHandler(this.BtnDivisorPattern_Click);
            // 
            // TxtPathFileSplitPattern
            // 
            this.TxtPathFileSplitPattern.Location = new System.Drawing.Point(8, 53);
            this.TxtPathFileSplitPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPathFileSplitPattern.Name = "TxtPathFileSplitPattern";
            this.TxtPathFileSplitPattern.Size = new System.Drawing.Size(672, 26);
            this.TxtPathFileSplitPattern.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPathFilePdf);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1066, 143);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración archivo a dividir";
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(15, 84);
            this.BtnPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(161, 35);
            this.BtnPath.TabIndex = 6;
            this.BtnPath.Text = "Buscar archivo Pdf";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // TxtPathFilePdf
            // 
            this.TxtPathFilePdf.Location = new System.Drawing.Point(15, 48);
            this.TxtPathFilePdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPathFilePdf.Name = "TxtPathFilePdf";
            this.TxtPathFilePdf.Size = new System.Drawing.Size(1026, 26);
            this.TxtPathFilePdf.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(919, 487);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(159, 48);
            this.BtnSend.TabIndex = 11;
            this.BtnSend.Text = "Dividir";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 545);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1120, 22);
            this.progressBar1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.Size = new System.Drawing.Size(147, 34);
            this.SalirMenuItem.Text = "Salir";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(79, 29);
            this.HelpMenuItem.Text = "Ayuda";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // DividePdfByPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 567);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GroupPagIni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DividePdfByPattern";
            this.Text = "Divisor de PDFs Por Patrón (Archivo)";
            this.GroupPagIni.ResumeLayout(false);
            this.GroupPagIni.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupPagIni;
        private System.Windows.Forms.TextBox TxtPrefix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TxtPathFilePdf;
        private System.Windows.Forms.Button BtnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnDivisorPattern;
        private System.Windows.Forms.TextBox TxtPathFileSplitPattern;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkAddDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSplitter;
        private System.Windows.Forms.Button BtnDownloadExample;
        private System.Windows.Forms.CheckBox ChkHeaders;
    }
}