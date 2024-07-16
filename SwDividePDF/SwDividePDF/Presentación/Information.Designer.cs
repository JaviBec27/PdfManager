namespace SwDividePDF.Presentación
{
    partial class Information
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThema_Primary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThema_Primary
            // 
            this.btnThema_Primary.Location = new System.Drawing.Point(24, 32);
            this.btnThema_Primary.Name = "btnThema_Primary";
            this.btnThema_Primary.Size = new System.Drawing.Size(201, 50);
            this.btnThema_Primary.TabIndex = 0;
            this.btnThema_Primary.Text = "Cambiar Tema";
            this.btnThema_Primary.UseVisualStyleBackColor = true;
            this.btnThema_Primary.Click += new System.EventHandler(this.btnThema_Primary_Click);
            // 
            // Information
            // 
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.btnThema_Primary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThema_Primary;
    }
}
