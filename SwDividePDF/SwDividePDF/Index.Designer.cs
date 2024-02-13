namespace SwDividePDF
{
    partial class Index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DivideByPatternMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dividePDFToolStripMenuItem,
            this.unePDFToolStripMenuItem,
            this.DivideByPatternMenuItem,
            this.agregarVersionToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // dividePDFToolStripMenuItem
            // 
            this.dividePDFToolStripMenuItem.Name = "dividePDFToolStripMenuItem";
            this.dividePDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dividePDFToolStripMenuItem.Text = "DividePDF";
            this.dividePDFToolStripMenuItem.Click += new System.EventHandler(this.dividePDFToolStripMenuItem_Click);
            // 
            // unePDFToolStripMenuItem
            // 
            this.unePDFToolStripMenuItem.Name = "unePDFToolStripMenuItem";
            this.unePDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unePDFToolStripMenuItem.Text = "UnePDF";
            this.unePDFToolStripMenuItem.Click += new System.EventHandler(this.unePDFToolStripMenuItem_Click);
            // 
            // DivideByPatternMenuItem
            // 
            this.DivideByPatternMenuItem.Name = "DivideByPatternMenuItem";
            this.DivideByPatternMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DivideByPatternMenuItem.Text = "DividePDFxKIT";
            this.DivideByPatternMenuItem.Click += new System.EventHandler(this.DivideByPatternMenuItem_Click);
            // 
            // agregarVersionToolStripMenuItem
            // 
            this.agregarVersionToolStripMenuItem.Name = "agregarVersionToolStripMenuItem";
            this.agregarVersionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarVersionToolStripMenuItem.Text = "AgregarVersion";
            this.agregarVersionToolStripMenuItem.Click += new System.EventHandler(this.agregarVersionToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DivideByPatternMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVersionToolStripMenuItem;
    }
}