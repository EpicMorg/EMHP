namespace EMHP4
{
    partial class frm_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_about));
            this.txt_prod = new System.Windows.Forms.Label();
            this.txt_vesion = new System.Windows.Forms.Label();
            this.panel_history = new System.Windows.Forms.Panel();
            this.txt_history = new System.Windows.Forms.TextBox();
            this.txt_cr = new System.Windows.Forms.Label();
            this.txt_autor1_null = new System.Windows.Forms.Label();
            this.panel_autors = new System.Windows.Forms.Panel();
            this.txt_vesion_null = new System.Windows.Forms.Label();
            this.panel_version = new System.Windows.Forms.Panel();
            this.pic_mainlogo = new System.Windows.Forms.PictureBox();
            this.pic_company = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_history.SuspendLayout();
            this.panel_autors.SuspendLayout();
            this.panel_version.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_company)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_prod
            // 
            this.txt_prod.AutoSize = true;
            this.txt_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_prod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_prod.Location = new System.Drawing.Point(3, 2);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(104, 24);
            this.txt_prod.TabIndex = 2;
            this.txt_prod.Text = "Hosts Manager \r\n(ex. Hosts Patcher)";
            // 
            // txt_vesion
            // 
            this.txt_vesion.AutoSize = true;
            this.txt_vesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vesion.Location = new System.Drawing.Point(5, 30);
            this.txt_vesion.Name = "txt_vesion";
            this.txt_vesion.Size = new System.Drawing.Size(44, 13);
            this.txt_vesion.TabIndex = 1;
            this.txt_vesion.Text = "Версия";
            // 
            // panel_history
            // 
            this.panel_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_history.Controls.Add(this.txt_history);
            this.panel_history.Controls.Add(this.txt_cr);
            this.panel_history.Location = new System.Drawing.Point(112, 3);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(220, 180);
            this.panel_history.TabIndex = 5;
            // 
            // txt_history
            // 
            this.txt_history.BackColor = System.Drawing.Color.Black;
            this.txt_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_history.ForeColor = System.Drawing.Color.Lime;
            this.txt_history.Location = new System.Drawing.Point(0, 0);
            this.txt_history.Multiline = true;
            this.txt_history.Name = "txt_history";
            this.txt_history.ReadOnly = true;
            this.txt_history.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_history.ShortcutsEnabled = false;
            this.txt_history.Size = new System.Drawing.Size(216, 155);
            this.txt_history.TabIndex = 1;
            this.txt_history.TabStop = false;
            this.txt_history.Text = resources.GetString("txt_history.Text");
            this.txt_history.WordWrap = false;
            // 
            // txt_cr
            // 
            this.txt_cr.AutoSize = true;
            this.txt_cr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_cr.Location = new System.Drawing.Point(76, 158);
            this.txt_cr.Name = "txt_cr";
            this.txt_cr.Size = new System.Drawing.Size(62, 13);
            this.txt_cr.TabIndex = 0;
            this.txt_cr.Text = "<copyright>";
            // 
            // txt_autor1_null
            // 
            this.txt_autor1_null.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_autor1_null.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_autor1_null.Location = new System.Drawing.Point(13, 10);
            this.txt_autor1_null.Name = "txt_autor1_null";
            this.txt_autor1_null.Size = new System.Drawing.Size(97, 41);
            this.txt_autor1_null.TabIndex = 0;
            this.txt_autor1_null.Text = "GUI: STAM\r\n\r\nCODE: KastHack";
            // 
            // panel_autors
            // 
            this.panel_autors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_autors.Controls.Add(this.txt_autor1_null);
            this.panel_autors.Location = new System.Drawing.Point(3, 189);
            this.panel_autors.Name = "panel_autors";
            this.panel_autors.Size = new System.Drawing.Size(127, 66);
            this.panel_autors.TabIndex = 7;
            // 
            // txt_vesion_null
            // 
            this.txt_vesion_null.AutoSize = true;
            this.txt_vesion_null.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vesion_null.Location = new System.Drawing.Point(53, 30);
            this.txt_vesion_null.Name = "txt_vesion_null";
            this.txt_vesion_null.Size = new System.Drawing.Size(40, 13);
            this.txt_vesion_null.TabIndex = 0;
            this.txt_vesion_null.Text = "0.0.0.0";
            // 
            // panel_version
            // 
            this.panel_version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_version.Controls.Add(this.txt_prod);
            this.panel_version.Controls.Add(this.txt_vesion);
            this.panel_version.Controls.Add(this.txt_vesion_null);
            this.panel_version.Location = new System.Drawing.Point(3, 132);
            this.panel_version.Name = "panel_version";
            this.panel_version.Size = new System.Drawing.Size(112, 51);
            this.panel_version.TabIndex = 6;
            // 
            // pic_mainlogo
            // 
            this.pic_mainlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_mainlogo.Image = global::EMHP4.Properties.Resources._2;
            this.pic_mainlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_mainlogo.Location = new System.Drawing.Point(3, 3);
            this.pic_mainlogo.Name = "pic_mainlogo";
            this.pic_mainlogo.Size = new System.Drawing.Size(112, 128);
            this.pic_mainlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mainlogo.TabIndex = 3;
            this.pic_mainlogo.TabStop = false;
            // 
            // pic_company
            // 
            this.pic_company.BackgroundImage = global::EMHP4.Properties.Resources.logo2;
            this.pic_company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_company.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_company.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_company.Location = new System.Drawing.Point(136, 188);
            this.pic_company.Name = "pic_company";
            this.pic_company.Size = new System.Drawing.Size(196, 67);
            this.pic_company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_company.TabIndex = 4;
            this.pic_company.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_history);
            this.panel1.Controls.Add(this.pic_mainlogo);
            this.panel1.Controls.Add(this.pic_company);
            this.panel1.Controls.Add(this.panel_autors);
            this.panel1.Controls.Add(this.panel_version);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 260);
            this.panel1.TabIndex = 8;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 292);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hosts Patcher :: About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_about_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_about_MouseDown);
            this.Resize += new System.EventHandler(this.frm_about_Resize);
            this.panel_history.ResumeLayout(false);
            this.panel_history.PerformLayout();
            this.panel_autors.ResumeLayout(false);
            this.panel_version.ResumeLayout(false);
            this.panel_version.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_company)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_prod;
        private System.Windows.Forms.Label txt_vesion;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.TextBox txt_history;
        private System.Windows.Forms.Label txt_cr;
        private System.Windows.Forms.Label txt_autor1_null;
        private System.Windows.Forms.PictureBox pic_mainlogo;
        private System.Windows.Forms.Panel panel_autors;
        private System.Windows.Forms.Label txt_vesion_null;
        private System.Windows.Forms.Panel panel_version;
        private System.Windows.Forms.PictureBox pic_company;
        private System.Windows.Forms.Panel panel1;
    }
}