namespace SwDividePDF
{
    partial class DividePDF
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
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtPagInicial = new System.Windows.Forms.TextBox();
            this.TxtPagFinal = new System.Windows.Forms.TextBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.ChkExtraer = new System.Windows.Forms.RadioButton();
            this.ChkDividir = new System.Windows.Forms.RadioButton();
            this.GroupPagIni = new System.Windows.Forms.GroupBox();
            this.GroupPagFin = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupPagIni.SuspendLayout();
            this.GroupPagFin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(10, 31);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(524, 20);
            this.TxtPath.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(12, 219);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(106, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Extraer";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtPagInicial
            // 
            this.TxtPagInicial.Location = new System.Drawing.Point(6, 20);
            this.TxtPagInicial.Name = "TxtPagInicial";
            this.TxtPagInicial.Size = new System.Drawing.Size(130, 20);
            this.TxtPagInicial.TabIndex = 2;
            this.TxtPagInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagInicial_KeyPress);
            // 
            // TxtPagFinal
            // 
            this.TxtPagFinal.Location = new System.Drawing.Point(6, 20);
            this.TxtPagFinal.Name = "TxtPagFinal";
            this.TxtPagFinal.Size = new System.Drawing.Size(144, 20);
            this.TxtPagFinal.TabIndex = 3;
            this.TxtPagFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagFinal_KeyPress);
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(540, 28);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(28, 23);
            this.BtnPath.TabIndex = 6;
            this.BtnPath.Text = "...";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar PDF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblMessage);
            this.groupBox2.Controls.Add(this.ChkExtraer);
            this.groupBox2.Controls.Add(this.ChkDividir);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 59);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(7, 40);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(18, 13);
            this.LblMessage.TabIndex = 12;
            this.LblMessage.Text = "as";
            // 
            // ChkExtraer
            // 
            this.ChkExtraer.AutoSize = true;
            this.ChkExtraer.Checked = true;
            this.ChkExtraer.Location = new System.Drawing.Point(6, 20);
            this.ChkExtraer.Name = "ChkExtraer";
            this.ChkExtraer.Size = new System.Drawing.Size(58, 17);
            this.ChkExtraer.TabIndex = 9;
            this.ChkExtraer.TabStop = true;
            this.ChkExtraer.Text = "Extraer";
            this.ChkExtraer.UseVisualStyleBackColor = true;
            this.ChkExtraer.CheckedChanged += new System.EventHandler(this.ChkExtraer_CheckedChanged);
            // 
            // ChkDividir
            // 
            this.ChkDividir.AutoSize = true;
            this.ChkDividir.Location = new System.Drawing.Point(82, 20);
            this.ChkDividir.Name = "ChkDividir";
            this.ChkDividir.Size = new System.Drawing.Size(54, 17);
            this.ChkDividir.TabIndex = 0;
            this.ChkDividir.Text = "Dividir";
            this.ChkDividir.UseVisualStyleBackColor = true;
            this.ChkDividir.CheckedChanged += new System.EventHandler(this.ChkDividir_CheckedChanged);
            // 
            // GroupPagIni
            // 
            this.GroupPagIni.Controls.Add(this.TxtPagInicial);
            this.GroupPagIni.Location = new System.Drawing.Point(12, 156);
            this.GroupPagIni.Name = "GroupPagIni";
            this.GroupPagIni.Size = new System.Drawing.Size(146, 60);
            this.GroupPagIni.TabIndex = 9;
            this.GroupPagIni.TabStop = false;
            this.GroupPagIni.Text = "Pagina Inicial";
            // 
            // GroupPagFin
            // 
            this.GroupPagFin.Controls.Add(this.TxtPagFinal);
            this.GroupPagFin.Location = new System.Drawing.Point(164, 156);
            this.GroupPagFin.Name = "GroupPagFin";
            this.GroupPagFin.Size = new System.Drawing.Size(161, 60);
            this.GroupPagFin.TabIndex = 10;
            this.GroupPagFin.TabStop = false;
            this.GroupPagFin.Text = "Página Final";
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
            this.progressBar1.Location = new System.Drawing.Point(0, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(616, 18);
            this.progressBar1.TabIndex = 11;
            // 
            // DividePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 277);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GroupPagFin);
            this.Controls.Add(this.GroupPagIni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Name = "DividePDF";
            this.Text = "Dividir PDFs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DividePDF_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupPagIni.ResumeLayout(false);
            this.GroupPagIni.PerformLayout();
            this.GroupPagFin.ResumeLayout(false);
            this.GroupPagFin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtPagInicial;
        private System.Windows.Forms.TextBox TxtPagFinal;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ChkExtraer;
        private System.Windows.Forms.RadioButton ChkDividir;
        private System.Windows.Forms.GroupBox GroupPagIni;
        private System.Windows.Forms.GroupBox GroupPagFin;
        private System.Windows.Forms.Label LblMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

