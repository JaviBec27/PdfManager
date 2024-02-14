namespace SwDividePDF
{
    partial class UnePDFs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPath);
            this.groupBox1.Controls.Add(this.TxtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directorio PDFs";
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
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(10, 31);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(524, 20);
            this.TxtPath.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(15, 131);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(106, 23);
            this.BtnSend.TabIndex = 11;
            this.BtnSend.Text = "Unir PDFs";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Permite unir en un solo PDF, diferentes PDFs ubicados en un determinado directori" +
    "o";
            // 
            // UnePDFs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.MaximizeBox = false;
            this.Name = "UnePDFs";
            this.Text = "UnePDFs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnePDFs_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label1;
    }
}