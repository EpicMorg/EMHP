namespace EMHP
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
            this.pic_mainlogo = new System.Windows.Forms.PictureBox();
            this.pic_company = new System.Windows.Forms.PictureBox();
            this.panel_version = new System.Windows.Forms.Panel();
            this.txt_prod = new System.Windows.Forms.Label();
            this.txt_vesion = new System.Windows.Forms.Label();
            this.txt_vesion_null = new System.Windows.Forms.Label();
            this.panel_autors = new System.Windows.Forms.Panel();
            this.txt_autor1_null = new System.Windows.Forms.Label();
            this.panel_history = new System.Windows.Forms.Panel();
            this.txt_history = new System.Windows.Forms.TextBox();
            this.txt_cr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pic_mainlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pic_company)).BeginInit();
            this.panel_version.SuspendLayout();
            this.panel_autors.SuspendLayout();
            this.panel_history.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_mainlogo
            // 
            resources.ApplyResources(this.pic_mainlogo, "pic_mainlogo");
            this.pic_mainlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_mainlogo.Image = global::EMHP.Properties.Resources.png_tm;
            this.pic_mainlogo.Name = "pic_mainlogo";
            this.pic_mainlogo.TabStop = false;
            // 
            // pic_company
            // 
            resources.ApplyResources(this.pic_company, "pic_company");
            this.pic_company.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_company.Image = global::EMHP.Properties.Resources.logo2;
            this.pic_company.Name = "pic_company";
            this.pic_company.TabStop = false;
            // 
            // panel_version
            // 
            resources.ApplyResources(this.panel_version, "panel_version");
            this.panel_version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_version.Controls.Add(this.txt_prod);
            this.panel_version.Controls.Add(this.txt_vesion);
            this.panel_version.Controls.Add(this.txt_vesion_null);
            this.panel_version.Name = "panel_version";
            // 
            // txt_prod
            // 
            resources.ApplyResources(this.txt_prod, "txt_prod");
            this.txt_prod.Name = "txt_prod";
            // 
            // txt_vesion
            // 
            resources.ApplyResources(this.txt_vesion, "txt_vesion");
            this.txt_vesion.Name = "txt_vesion";
            // 
            // txt_vesion_null
            // 
            resources.ApplyResources(this.txt_vesion_null, "txt_vesion_null");
            this.txt_vesion_null.Name = "txt_vesion_null";
            // 
            // panel_autors
            // 
            resources.ApplyResources(this.panel_autors, "panel_autors");
            this.panel_autors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_autors.Controls.Add(this.txt_autor1_null);
            this.panel_autors.Name = "panel_autors";
            // 
            // txt_autor1_null
            // 
            resources.ApplyResources(this.txt_autor1_null, "txt_autor1_null");
            this.txt_autor1_null.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_autor1_null.Name = "txt_autor1_null";
            // 
            // panel_history
            // 
            resources.ApplyResources(this.panel_history, "panel_history");
            this.panel_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_history.Controls.Add(this.txt_history);
            this.panel_history.Controls.Add(this.txt_cr);
            this.panel_history.Name = "panel_history";
            // 
            // txt_history
            // 
            resources.ApplyResources(this.txt_history, "txt_history");
            this.txt_history.BackColor = System.Drawing.Color.Black;
            this.txt_history.ForeColor = System.Drawing.Color.Lime;
            this.txt_history.Name = "txt_history";
            this.txt_history.ReadOnly = true;
            this.txt_history.ShortcutsEnabled = false;
            this.txt_history.TabStop = false;
            // 
            // txt_cr
            // 
            resources.ApplyResources(this.txt_cr, "txt_cr");
            this.txt_cr.Name = "txt_cr";
            // 
            // frm_about
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_history);
            this.Controls.Add(this.panel_autors);
            this.Controls.Add(this.panel_version);
            this.Controls.Add(this.pic_mainlogo);
            this.Controls.Add(this.pic_company);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_about_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pic_mainlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pic_company)).EndInit();
            this.panel_version.ResumeLayout(false);
            this.panel_version.PerformLayout();
            this.panel_autors.ResumeLayout(false);
            this.panel_autors.PerformLayout();
            this.panel_history.ResumeLayout(false);
            this.panel_history.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_mainlogo;
        private System.Windows.Forms.PictureBox pic_company;
        private System.Windows.Forms.Panel panel_version;
        private System.Windows.Forms.Panel panel_autors;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.Label txt_vesion_null;
        private System.Windows.Forms.Label txt_prod;
        private System.Windows.Forms.Label txt_vesion;
        private System.Windows.Forms.Label txt_cr;
        private System.Windows.Forms.Label txt_autor1_null;
        private System.Windows.Forms.TextBox txt_history;
    }
}