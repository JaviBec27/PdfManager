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
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
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
            this.GroupPagFin.Location = new System.Drawing.Point(240, 303);
            this.GroupPagFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagFin.Name = "GroupPagFin";
            this.GroupPagFin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagFin.Size = new System.Drawing.Size(242, 92);
            this.GroupPagFin.TabIndex = 15;
            this.GroupPagFin.TabStop = false;
            this.GroupPagFin.Text = "Prefijo";
            // 
            // TxtPref
            // 
            this.TxtPref.Enabled = false;
            this.TxtPref.Location = new System.Drawing.Point(9, 31);
            this.TxtPref.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPref.Name = "TxtPref";
            this.TxtPref.Size = new System.Drawing.Size(214, 26);
            this.TxtPref.TabIndex = 3;
            // 
            // GroupPagIni
            // 
            this.GroupPagIni.Controls.Add(this.TxtNombre);
            this.GroupPagIni.Location = new System.Drawing.Point(12, 303);
            this.GroupPagIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagIni.Name = "GroupPagIni";
            this.GroupPagIni.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupPagIni.Size = new System.Drawing.Size(219, 92);
            this.GroupPagIni.TabIndex = 14;
            this.GroupPagIni.TabStop = false;
            this.GroupPagIni.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(9, 31);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(193, 26);
            this.TxtNombre.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnDivisorPattern);
            this.groupBox2.Controls.Add(this.TxtDivisorPattern);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(891, 98);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo de Configuración DivisorPattern";
            // 
            // BtnDivisorPattern
            // 
            this.BtnDivisorPattern.Location = new System.Drawing.Point(713, 36);
            this.BtnDivisorPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDivisorPattern.Name = "BtnDivisorPattern";
            this.BtnDivisorPattern.Size = new System.Drawing.Size(42, 35);
            this.BtnDivisorPattern.TabIndex = 7;
            this.BtnDivisorPattern.Text = "...";
            this.BtnDivisorPattern.UseVisualStyleBackColor = true;
            this.BtnDivisorPattern.Click += new System.EventHandler(this.BtnDivisorPattern_Click);
            // 
            // TxtDivisorPattern
            // 
            this.TxtDivisorPattern.Location = new System.Drawing.Point(9, 45);
            this.TxtDivisorPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDivisorPattern.Name = "TxtDivisorPattern";
            this.TxtDivisorPattern.Size = new System.Drawing.Size(664, 26);
            this.TxtDivisorPattern.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPathPdf);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(891, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar PDF";
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(810, 43);
            this.BtnPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(42, 35);
            this.BtnPath.TabIndex = 6;
            this.BtnPath.Text = "...";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // TxtPathPdf
            // 
            this.TxtPathPdf.Location = new System.Drawing.Point(15, 48);
            this.TxtPathPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPathPdf.Name = "TxtPathPdf";
            this.TxtPathPdf.Size = new System.Drawing.Size(784, 26);
            this.TxtPathPdf.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(12, 414);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(159, 35);
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
            this.progressBar1.Location = new System.Drawing.Point(0, 490);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(921, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(921, 35);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DividePdfByPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 512);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GroupPagFin);
            this.Controls.Add(this.GroupPagIni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
    }
}