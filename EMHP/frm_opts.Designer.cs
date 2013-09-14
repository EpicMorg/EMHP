namespace EMHP
{
    partial class frm_opts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_opts));
            this.gbx_main_null = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_lng = new System.Windows.Forms.Button();
            this.cbx_minimized = new System.Windows.Forms.CheckBox();
            this.cbx_autorun = new System.Windows.Forms.CheckBox();
            this.gbx_autorun = new System.Windows.Forms.GroupBox();
            this.gbx_main_null.SuspendLayout();
            this.gbx_autorun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_main_null
            // 
            resources.ApplyResources(this.gbx_main_null, "gbx_main_null");
            this.gbx_main_null.Controls.Add(this.gbx_autorun);
            this.gbx_main_null.Controls.Add(this.btn_reset);
            this.gbx_main_null.Controls.Add(this.btn_ok);
            this.gbx_main_null.Controls.Add(this.btn_lng);
            this.gbx_main_null.Name = "gbx_main_null";
            this.gbx_main_null.TabStop = false;
            // 
            // btn_reset
            // 
            resources.ApplyResources(this.btn_reset, "btn_reset");
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_lng
            // 
            resources.ApplyResources(this.btn_lng, "btn_lng");
            this.btn_lng.Name = "btn_lng";
            this.btn_lng.UseVisualStyleBackColor = true;
            this.btn_lng.Click += new System.EventHandler(this.btn_lng_Click);
            // 
            // cbx_minimized
            // 
            resources.ApplyResources(this.cbx_minimized, "cbx_minimized");
            this.cbx_minimized.Name = "cbx_minimized";
            this.cbx_minimized.UseVisualStyleBackColor = true;
            //this.cbx_minimized.CheckedChanged += new System.EventHandler(this.cbx_minimized_CheckedChanged);
            // 
            // cbx_autorun
            // 
            resources.ApplyResources(this.cbx_autorun, "cbx_autorun");
            this.cbx_autorun.Name = "cbx_autorun";
            this.cbx_autorun.UseVisualStyleBackColor = true;
            this.cbx_autorun.CheckedChanged += new System.EventHandler(this.cbx_autorun_CheckedChanged);
            // 
            // gbx_autorun
            // 
            this.gbx_autorun.Controls.Add(this.cbx_autorun);
            this.gbx_autorun.Controls.Add(this.cbx_minimized);
            resources.ApplyResources(this.gbx_autorun, "gbx_autorun");
            this.gbx_autorun.Name = "gbx_autorun";
            this.gbx_autorun.TabStop = false;
            // 
            // frm_opts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx_main_null);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_opts";
            this.ShowInTaskbar = false;
            this.gbx_main_null.ResumeLayout(false);
            this.gbx_autorun.ResumeLayout(false);
            this.gbx_autorun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_main_null;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_lng;
        private System.Windows.Forms.CheckBox cbx_minimized;
        private System.Windows.Forms.CheckBox cbx_autorun;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox gbx_autorun;
    }
}