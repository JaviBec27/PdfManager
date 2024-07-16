using SwDividePDF.Presentación.Style.StyleCase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwDividePDF.Presentación
{
    public partial class BaseForm : MainForm
    {
        private Panel titleBarPanel;
        private Button closeBtn_Primary;
        private Panel panel1;
        private Panel sideBarMenuPanel;
        private Panel panel3;
        private Panel contentPanel;
        private Button MinimizeBtn_Primary;
        private Button normalizeBtn_Primary;
        private Panel panel2;
        private Label mainTitle;
        private Panel btn_BorderPanel_1;
        private Button splitBtn_Secondary;
        private Button btnJoin_Secondary;
        private Panel btn_BorderPanel_2;
        private Panel tittle_BorderPanel;
        private Button powerOffBtn_Primary;
        private Button btnInfo_Secondary;
        private Panel btn_BorderPanel_3;
        private Panel btn_BorderPanel_5;
        private Panel btn_BorderPanel_4;
        private Button btnAddDateAndVersion_Secondary;
        private Button btnSplitPdfPattern_Secondary;
        private Button maximizeBtn_Primary;

        public BaseForm() : base()
        {          
            InitializeComponent();
            this.Load += BaseForm_Load;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            ApplyCustomizedDesing(this);
        }

        protected void ApplyCustomizedDesing(Control parent)
        {
            base.styleContext.SetStyleStrategy(_globalStyleStrategy);
            styleContext.ApplyStyle(parent);
        }

 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.normalizeBtn_Primary = new System.Windows.Forms.Button();
            this.MinimizeBtn_Primary = new System.Windows.Forms.Button();
            this.maximizeBtn_Primary = new System.Windows.Forms.Button();
            this.closeBtn_Primary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideBarMenuPanel = new System.Windows.Forms.Panel();
            this.btnJoin_Secondary = new System.Windows.Forms.Button();
            this.btn_BorderPanel_2 = new System.Windows.Forms.Panel();
            this.splitBtn_Secondary = new System.Windows.Forms.Button();
            this.btn_BorderPanel_1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tittle_BorderPanel = new System.Windows.Forms.Panel();
            this.powerOffBtn_Primary = new System.Windows.Forms.Button();
            this.btnInfo_Secondary = new System.Windows.Forms.Button();
            this.btn_BorderPanel_3 = new System.Windows.Forms.Panel();
            this.btnSplitPdfPattern_Secondary = new System.Windows.Forms.Button();
            this.btnAddDateAndVersion_Secondary = new System.Windows.Forms.Button();
            this.btn_BorderPanel_4 = new System.Windows.Forms.Panel();
            this.btn_BorderPanel_5 = new System.Windows.Forms.Panel();
            this.titleBarPanel.SuspendLayout();
            this.sideBarMenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.titleBarPanel.Controls.Add(this.normalizeBtn_Primary);
            this.titleBarPanel.Controls.Add(this.MinimizeBtn_Primary);
            this.titleBarPanel.Controls.Add(this.maximizeBtn_Primary);
            this.titleBarPanel.Controls.Add(this.closeBtn_Primary);
            this.titleBarPanel.Controls.Add(this.panel1);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1000, 35);
            this.titleBarPanel.TabIndex = 0;
            // 
            // normalizeBtn_Primary
            // 
            this.normalizeBtn_Primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalizeBtn_Primary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.normalizeBtn_Primary.Location = new System.Drawing.Point(923, 0);
            this.normalizeBtn_Primary.Name = "normalizeBtn_Primary";
            this.normalizeBtn_Primary.Size = new System.Drawing.Size(34, 32);
            this.normalizeBtn_Primary.TabIndex = 5;
            this.normalizeBtn_Primary.Text = "[[]]";
            this.normalizeBtn_Primary.UseVisualStyleBackColor = true;
            this.normalizeBtn_Primary.Visible = false;
            this.normalizeBtn_Primary.Click += new System.EventHandler(this.normalizeBtn_Click);
            // 
            // MinimizeBtn_Primary
            // 
            this.MinimizeBtn_Primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn_Primary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimizeBtn_Primary.Location = new System.Drawing.Point(883, 0);
            this.MinimizeBtn_Primary.Name = "MinimizeBtn_Primary";
            this.MinimizeBtn_Primary.Size = new System.Drawing.Size(34, 32);
            this.MinimizeBtn_Primary.TabIndex = 4;
            this.MinimizeBtn_Primary.Text = "--";
            this.MinimizeBtn_Primary.UseVisualStyleBackColor = true;
            this.MinimizeBtn_Primary.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // maximizeBtn_Primary
            // 
            this.maximizeBtn_Primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn_Primary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximizeBtn_Primary.Location = new System.Drawing.Point(923, 0);
            this.maximizeBtn_Primary.Name = "maximizeBtn_Primary";
            this.maximizeBtn_Primary.Size = new System.Drawing.Size(34, 32);
            this.maximizeBtn_Primary.TabIndex = 3;
            this.maximizeBtn_Primary.Text = "[  ]";
            this.maximizeBtn_Primary.UseVisualStyleBackColor = true;
            this.maximizeBtn_Primary.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // closeBtn_Primary
            // 
            this.closeBtn_Primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn_Primary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn_Primary.Location = new System.Drawing.Point(963, 0);
            this.closeBtn_Primary.Name = "closeBtn_Primary";
            this.closeBtn_Primary.Size = new System.Drawing.Size(34, 32);
            this.closeBtn_Primary.TabIndex = 2;
            this.closeBtn_Primary.Text = "X";
            this.closeBtn_Primary.UseVisualStyleBackColor = true;
            this.closeBtn_Primary.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 287);
            this.panel1.TabIndex = 1;
            // 
            // sideBarMenuPanel
            // 
            this.sideBarMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.sideBarMenuPanel.Controls.Add(this.btn_BorderPanel_5);
            this.sideBarMenuPanel.Controls.Add(this.btn_BorderPanel_4);
            this.sideBarMenuPanel.Controls.Add(this.btnAddDateAndVersion_Secondary);
            this.sideBarMenuPanel.Controls.Add(this.btnSplitPdfPattern_Secondary);
            this.sideBarMenuPanel.Controls.Add(this.btnInfo_Secondary);
            this.sideBarMenuPanel.Controls.Add(this.btn_BorderPanel_3);
            this.sideBarMenuPanel.Controls.Add(this.btnJoin_Secondary);
            this.sideBarMenuPanel.Controls.Add(this.btn_BorderPanel_2);
            this.sideBarMenuPanel.Controls.Add(this.splitBtn_Secondary);
            this.sideBarMenuPanel.Controls.Add(this.btn_BorderPanel_1);
            this.sideBarMenuPanel.Controls.Add(this.panel2);
            this.sideBarMenuPanel.Controls.Add(this.panel3);
            this.sideBarMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMenuPanel.Location = new System.Drawing.Point(0, 35);
            this.sideBarMenuPanel.Name = "sideBarMenuPanel";
            this.sideBarMenuPanel.Size = new System.Drawing.Size(269, 415);
            this.sideBarMenuPanel.TabIndex = 1;
            // 
            // btnJoin_Secondary
            // 
            this.btnJoin_Secondary.FlatAppearance.BorderSize = 0;
            this.btnJoin_Secondary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnJoin_Secondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin_Secondary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnJoin_Secondary.Image = ((System.Drawing.Image)(resources.GetObject("btnJoin_Secondary.Image")));
            this.btnJoin_Secondary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoin_Secondary.Location = new System.Drawing.Point(18, 122);
            this.btnJoin_Secondary.Name = "btnJoin_Secondary";
            this.btnJoin_Secondary.Size = new System.Drawing.Size(257, 35);
            this.btnJoin_Secondary.TabIndex = 2;
            this.btnJoin_Secondary.Text = "Unir PDF";
            this.btnJoin_Secondary.UseVisualStyleBackColor = true;
            this.btnJoin_Secondary.Click += new System.EventHandler(this.btnJoin_Secondary_Click);
            // 
            // btn_BorderPanel_2
            // 
            this.btn_BorderPanel_2.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BorderPanel_2.Location = new System.Drawing.Point(6, 122);
            this.btn_BorderPanel_2.Name = "btn_BorderPanel_2";
            this.btn_BorderPanel_2.Size = new System.Drawing.Size(12, 35);
            this.btn_BorderPanel_2.TabIndex = 3;
            // 
            // splitBtn_Secondary
            // 
            this.splitBtn_Secondary.FlatAppearance.BorderSize = 0;
            this.splitBtn_Secondary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.splitBtn_Secondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitBtn_Secondary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitBtn_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitBtn_Secondary.Image = ((System.Drawing.Image)(resources.GetObject("splitBtn_Secondary.Image")));
            this.splitBtn_Secondary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitBtn_Secondary.Location = new System.Drawing.Point(18, 81);
            this.splitBtn_Secondary.Name = "splitBtn_Secondary";
            this.splitBtn_Secondary.Size = new System.Drawing.Size(257, 35);
            this.splitBtn_Secondary.TabIndex = 0;
            this.splitBtn_Secondary.Text = "Dividir PDF";
            this.splitBtn_Secondary.UseVisualStyleBackColor = true;
            this.splitBtn_Secondary.Click += new System.EventHandler(this.splitBtn_Secondary_Click);
            // 
            // btn_BorderPanel_1
            // 
            this.btn_BorderPanel_1.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BorderPanel_1.Location = new System.Drawing.Point(6, 81);
            this.btn_BorderPanel_1.Name = "btn_BorderPanel_1";
            this.btn_BorderPanel_1.Size = new System.Drawing.Size(12, 35);
            this.btn_BorderPanel_1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.powerOffBtn_Primary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 67);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.tittle_BorderPanel);
            this.panel3.Controls.Add(this.mainTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 55);
            this.panel3.TabIndex = 0;
            // 
            // mainTitle
            // 
            this.mainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Kristen ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainTitle.Location = new System.Drawing.Point(12, 11);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(235, 36);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "PDF MANAGER";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(269, 35);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(731, 415);
            this.contentPanel.TabIndex = 2;
            // 
            // tittle_BorderPanel
            // 
            this.tittle_BorderPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.tittle_BorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tittle_BorderPanel.Location = new System.Drawing.Point(0, 50);
            this.tittle_BorderPanel.Name = "tittle_BorderPanel";
            this.tittle_BorderPanel.Size = new System.Drawing.Size(269, 5);
            this.tittle_BorderPanel.TabIndex = 1;
            // 
            // powerOffBtn_Primary
            // 
            this.powerOffBtn_Primary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.powerOffBtn_Primary.FlatAppearance.BorderSize = 0;
            this.powerOffBtn_Primary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.powerOffBtn_Primary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerOffBtn_Primary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOffBtn_Primary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.powerOffBtn_Primary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.powerOffBtn_Primary.Location = new System.Drawing.Point(6, 20);
            this.powerOffBtn_Primary.Name = "powerOffBtn_Primary";
            this.powerOffBtn_Primary.Size = new System.Drawing.Size(257, 35);
            this.powerOffBtn_Primary.TabIndex = 3;
            this.powerOffBtn_Primary.Text = "Apagar";
            this.powerOffBtn_Primary.UseVisualStyleBackColor = false;
            this.powerOffBtn_Primary.Click += new System.EventHandler(this.powerOffBtn_Click);
            // 
            // btnInfo_Secondary
            // 
            this.btnInfo_Secondary.FlatAppearance.BorderSize = 0;
            this.btnInfo_Secondary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnInfo_Secondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo_Secondary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInfo_Secondary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo_Secondary.Location = new System.Drawing.Point(18, 246);
            this.btnInfo_Secondary.Name = "btnInfo_Secondary";
            this.btnInfo_Secondary.Size = new System.Drawing.Size(257, 35);
            this.btnInfo_Secondary.TabIndex = 4;
            this.btnInfo_Secondary.Text = "Information";
            this.btnInfo_Secondary.UseVisualStyleBackColor = true;
            this.btnInfo_Secondary.Click += new System.EventHandler(this.btnInfo_Secondary_Click);
            // 
            // btn_BorderPanel_3
            // 
            this.btn_BorderPanel_3.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BorderPanel_3.Location = new System.Drawing.Point(6, 163);
            this.btn_BorderPanel_3.Name = "btn_BorderPanel_3";
            this.btn_BorderPanel_3.Size = new System.Drawing.Size(12, 35);
            this.btn_BorderPanel_3.TabIndex = 5;
            // 
            // btnSplitPdfPattern_Secondary
            // 
            this.btnSplitPdfPattern_Secondary.FlatAppearance.BorderSize = 0;
            this.btnSplitPdfPattern_Secondary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnSplitPdfPattern_Secondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitPdfPattern_Secondary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitPdfPattern_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSplitPdfPattern_Secondary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSplitPdfPattern_Secondary.Location = new System.Drawing.Point(18, 163);
            this.btnSplitPdfPattern_Secondary.Name = "btnSplitPdfPattern_Secondary";
            this.btnSplitPdfPattern_Secondary.Size = new System.Drawing.Size(257, 35);
            this.btnSplitPdfPattern_Secondary.TabIndex = 6;
            this.btnSplitPdfPattern_Secondary.Text = "Divide PDF por patrón";
            this.btnSplitPdfPattern_Secondary.UseVisualStyleBackColor = true;
            this.btnSplitPdfPattern_Secondary.Click += new System.EventHandler(this.btnSplitPdfPattern_Secondary_Click);
            // 
            // btnAddDateAndVersion_Secondary
            // 
            this.btnAddDateAndVersion_Secondary.FlatAppearance.BorderSize = 0;
            this.btnAddDateAndVersion_Secondary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddDateAndVersion_Secondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDateAndVersion_Secondary.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDateAndVersion_Secondary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddDateAndVersion_Secondary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDateAndVersion_Secondary.Location = new System.Drawing.Point(18, 204);
            this.btnAddDateAndVersion_Secondary.Name = "btnAddDateAndVersion_Secondary";
            this.btnAddDateAndVersion_Secondary.Size = new System.Drawing.Size(257, 35);
            this.btnAddDateAndVersion_Secondary.TabIndex = 7;
            this.btnAddDateAndVersion_Secondary.Text = "Agregar versión y fecha";
            this.btnAddDateAndVersion_Secondary.UseVisualStyleBackColor = true;
            this.btnAddDateAndVersion_Secondary.Click += new System.EventHandler(this.btnAddDateAndVersion_Secondary_Click);
            // 
            // btn_BorderPanel_4
            // 
            this.btn_BorderPanel_4.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BorderPanel_4.Location = new System.Drawing.Point(6, 204);
            this.btn_BorderPanel_4.Name = "btn_BorderPanel_4";
            this.btn_BorderPanel_4.Size = new System.Drawing.Size(12, 35);
            this.btn_BorderPanel_4.TabIndex = 6;
            // 
            // btn_BorderPanel_5
            // 
            this.btn_BorderPanel_5.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BorderPanel_5.Location = new System.Drawing.Point(6, 246);
            this.btn_BorderPanel_5.Name = "btn_BorderPanel_5";
            this.btn_BorderPanel_5.Size = new System.Drawing.Size(12, 35);
            this.btn_BorderPanel_5.TabIndex = 7;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sideBarMenuPanel);
            this.Controls.Add(this.titleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.titleBarPanel.ResumeLayout(false);
            this.sideBarMenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizeBtn_Primary.Visible = false;
            normalizeBtn_Primary.Visible = true;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void normalizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizeBtn_Primary.Visible = true;
            normalizeBtn_Primary.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            powerOffBtn_Click(sender, e);
        }

        private void powerOffBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Secondary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Information());
        }

        private void btnAddDateAndVersion_Secondary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddVersionAndDate());
        }


        private void OpenChildForm(object childFormObject)
        {
            if (this.contentPanel.Controls.Count > 0)
                this.contentPanel.Controls.RemoveAt(0);
            var childForm = childFormObject as Form;
            if (childForm != null)
            {
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                this.contentPanel.Controls.Add(childForm);
                this.contentPanel.Tag = childForm;
                childForm.Show();
            }
        }

        private void splitBtn_Secondary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DividePDF());
        }

        private void btnJoin_Secondary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnePDFs());
        }

        private void btnSplitPdfPattern_Secondary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DividePdfByPattern());
        }
    }
}
