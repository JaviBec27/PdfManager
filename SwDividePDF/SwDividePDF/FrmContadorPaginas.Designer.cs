namespace SwDividePDF
{
    partial class FrmContadorPaginas
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
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.GBPaths = new System.Windows.Forms.GroupBox();
            this.TxtxPath = new System.Windows.Forms.TextBox();
            this.BtnxPath = new System.Windows.Forms.Button();
            this.GBPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Location = new System.Drawing.Point(461, 71);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(61, 23);
            this.BtnProcesar.TabIndex = 4;
            this.BtnProcesar.Text = "Ejecutar";
            this.BtnProcesar.UseVisualStyleBackColor = true;
            // 
            // GBPaths
            // 
            this.GBPaths.Controls.Add(this.TxtxPath);
            this.GBPaths.Controls.Add(this.BtnxPath);
            this.GBPaths.Location = new System.Drawing.Point(12, 12);
            this.GBPaths.Name = "GBPaths";
            this.GBPaths.Size = new System.Drawing.Size(511, 53);
            this.GBPaths.TabIndex = 3;
            this.GBPaths.TabStop = false;
            this.GBPaths.Text = "Buscar Directorio";
            // 
            // TxtxPath
            // 
            this.TxtxPath.Location = new System.Drawing.Point(6, 19);
            this.TxtxPath.Name = "TxtxPath";
            this.TxtxPath.Size = new System.Drawing.Size(459, 20);
            this.TxtxPath.TabIndex = 1;
            // 
            // BtnxPath
            // 
            this.BtnxPath.Location = new System.Drawing.Point(471, 19);
            this.BtnxPath.Name = "BtnxPath";
            this.BtnxPath.Size = new System.Drawing.Size(33, 23);
            this.BtnxPath.TabIndex = 0;
            this.BtnxPath.Text = "...";
            this.BtnxPath.UseVisualStyleBackColor = true;
            // 
            // FrmContadorPaginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 104);
            this.Controls.Add(this.BtnProcesar);
            this.Controls.Add(this.GBPaths);
            this.Name = "FrmContadorPaginas";
            this.Text = "FrmContadorPaginas";
            this.GBPaths.ResumeLayout(false);
            this.GBPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.GroupBox GBPaths;
        private System.Windows.Forms.TextBox TxtxPath;
        private System.Windows.Forms.Button BtnxPath;
    }
}