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
            this.GroupPagFin = new System.Windows.Forms.GroupBox();
            this.TxtPref = new System.Windows.Forms.TextBox();
            this.GroupPagIni = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDivisorPattern = new System.Windows.Forms.Button();
            this.TxtDivisorPattern = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPathPdf = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupPagFin.SuspendLayout();
            this.GroupPagIni.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPagFin
            // 
            this.GroupPagFin.Controls.Add(this.TxtPref);
            this.GroupPagFin.Location = new System.Drawing.Point(160, 197);
            this.GroupPagFin.Name = "GroupPagFin";
            this.GroupPagFin.Size = new System.Drawing.Size(161, 60);
            this.GroupPagFin.TabIndex = 15;
            this.GroupPagFin.TabStop = false;
            this.GroupPagFin.Text = "Prefijo";
            // 
            // TxtPref
            // 
            this.TxtPref.Enabled = false;
            this.TxtPref.Location = new System.Drawing.Point(6, 20);
            this.TxtPref.Name = "TxtPref";
            this.TxtPref.Size = new System.Drawing.Size(144, 20);
            this.TxtPref.TabIndex = 3;
            this.TxtPref.Text = "69";
            // 
            // GroupPagIni
            // 
            this.GroupPagIni.Controls.Add(this.TxtNombre);
            this.GroupPagIni.Location = new System.Drawing.Point(8, 197);
            this.GroupPagIni.Name = "GroupPagIni";
            this.GroupPagIni.Size = new System.Drawing.Size(146, 60);
            this.GroupPagIni.TabIndex = 14;
            this.GroupPagIni.TabStop = false;
            this.GroupPagIni.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(6, 20);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(130, 20);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Text = "KIT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDivisorPattern);
            this.groupBox2.Controls.Add(this.TxtDivisorPattern);
            this.groupBox2.Location = new System.Drawing.Point(8, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo de Configuración DivisorPattern";
            // 
            // BtnDivisorPattern
            // 
            this.BtnDivisorPattern.Location = new System.Drawing.Point(540, 27);
            this.BtnDivisorPattern.Name = "BtnDivisorPattern";
            this.BtnDivisorPattern.Size = new System.Drawing.Size(28, 23);
            this.BtnDivisorPattern.TabIndex = 7;
            this.BtnDivisorPattern.Text = "...";
            this.BtnDivisorPattern.UseVisualStyleBackColor = true;
            this.BtnDivisorPattern.Click += new System.EventHandler(this.BtnDivisorPattern_Click);
            // 
            // TxtDivisorPattern
            // 
            this.TxtDivisorPattern.Location = new System.Drawing.Point(6, 29);
            this.TxtDivisorPattern.Name = "TxtDivisorPattern";
            this.TxtDivisorPattern.Size = new System.Drawing.Size(524, 20);
            this.TxtDivisorPattern.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPathPdf);
            this.groupBox1.Location = new System.Drawing.Point(8, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar PDF";
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
            // TxtPathPdf
            // 
            this.TxtPathPdf.Location = new System.Drawing.Point(10, 31);
            this.TxtPathPdf.Name = "TxtPathPdf";
            this.TxtPathPdf.Size = new System.Drawing.Size(524, 20);
            this.TxtPathPdf.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(8, 269);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(106, 23);
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
            this.progressBar1.Location = new System.Drawing.Point(0, 319);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(614, 14);
            this.progressBar1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(53, 20);
            this.HelpMenuItem.Text = "Ayuda";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalirMenuItem.Text = "Salir";
            // 
            // DividePdfByPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 333);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GroupPagFin);
            this.Controls.Add(this.GroupPagIni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DividePdfByPattern";
            this.Text = "Divisor de PDFs Por Patrón (Archivo)";
            this.GroupPagFin.ResumeLayout(false);
            this.GroupPagFin.PerformLayout();
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

        private System.Windows.Forms.GroupBox GroupPagFin;
        private System.Windows.Forms.TextBox TxtPref;
        private System.Windows.Forms.GroupBox GroupPagIni;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TxtPathPdf;
        private System.Windows.Forms.Button BtnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnDivisorPattern;
        private System.Windows.Forms.TextBox TxtDivisorPattern;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
    }
}