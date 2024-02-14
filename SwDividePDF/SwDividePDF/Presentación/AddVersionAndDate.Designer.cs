namespace SwDividePDF
{
    partial class AddVersionAndDate
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupPagFin = new System.Windows.Forms.GroupBox();
            this.TxtCreationDate = new System.Windows.Forms.TextBox();
            this.GroupPagIni = new System.Windows.Forms.GroupBox();
            this.TxtVersion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPathPdf = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.GroupPagFin.SuspendLayout();
            this.GroupPagIni.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(562, 14);
            this.progressBar1.TabIndex = 23;
            // 
            // GroupPagFin
            // 
            this.GroupPagFin.Controls.Add(this.TxtCreationDate);
            this.GroupPagFin.Location = new System.Drawing.Point(164, 91);
            this.GroupPagFin.Name = "GroupPagFin";
            this.GroupPagFin.Size = new System.Drawing.Size(161, 60);
            this.GroupPagFin.TabIndex = 22;
            this.GroupPagFin.TabStop = false;
            this.GroupPagFin.Text = "Fecha Creación";
            // 
            // TxtCreationDate
            // 
            this.TxtCreationDate.Location = new System.Drawing.Point(6, 20);
            this.TxtCreationDate.Name = "TxtCreationDate";
            this.TxtCreationDate.Size = new System.Drawing.Size(144, 20);
            this.TxtCreationDate.TabIndex = 3;
            // 
            // GroupPagIni
            // 
            this.GroupPagIni.Controls.Add(this.TxtVersion);
            this.GroupPagIni.Location = new System.Drawing.Point(12, 91);
            this.GroupPagIni.Name = "GroupPagIni";
            this.GroupPagIni.Size = new System.Drawing.Size(146, 60);
            this.GroupPagIni.TabIndex = 21;
            this.GroupPagIni.TabStop = false;
            this.GroupPagIni.Text = "Versión";
            // 
            // TxtVersion
            // 
            this.TxtVersion.Location = new System.Drawing.Point(6, 20);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(130, 20);
            this.TxtVersion.TabIndex = 2;
            this.TxtVersion.Text = "1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPathPdf);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar PDF";
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(504, 29);
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
            this.TxtPathPdf.Size = new System.Drawing.Size(488, 20);
            this.TxtPathPdf.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(12, 163);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(106, 23);
            this.BtnSend.TabIndex = 18;
            this.BtnSend.Text = "Ejecutar";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // AddVersionAndDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 222);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GroupPagFin);
            this.Controls.Add(this.GroupPagIni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Name = "AddVersionAndDate";
            this.Text = "AddVersionAndDate";
            this.GroupPagFin.ResumeLayout(false);
            this.GroupPagFin.PerformLayout();
            this.GroupPagIni.ResumeLayout(false);
            this.GroupPagIni.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox GroupPagFin;
        private System.Windows.Forms.TextBox TxtCreationDate;
        private System.Windows.Forms.GroupBox GroupPagIni;
        private System.Windows.Forms.TextBox TxtVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TxtPathPdf;
        private System.Windows.Forms.Button BtnSend;
    }
}