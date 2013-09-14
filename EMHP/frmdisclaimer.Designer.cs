namespace EMHP
{
    partial class frm_disclaimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_disclaimer));
            this.txt_dsk__title_en = new System.Windows.Forms.Label();
            this.txt_dsk_all = new System.Windows.Forms.TextBox();
            this.btn_dsk_cls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_dsk__title_en
            // 
            resources.ApplyResources(this.txt_dsk__title_en, "txt_dsk__title_en");
            this.txt_dsk__title_en.ForeColor = System.Drawing.Color.Red;
            this.txt_dsk__title_en.Name = "txt_dsk__title_en";
            // 
            // txt_dsk_all
            // 
            resources.ApplyResources(this.txt_dsk_all, "txt_dsk_all");
            this.txt_dsk_all.BackColor = System.Drawing.Color.Black;
            this.txt_dsk_all.ForeColor = System.Drawing.Color.Red;
            this.txt_dsk_all.Name = "txt_dsk_all";
            this.txt_dsk_all.ReadOnly = true;
            this.txt_dsk_all.TabStop = false;
            // 
            // btn_dsk_cls
            // 
            resources.ApplyResources(this.btn_dsk_cls, "btn_dsk_cls");
            this.btn_dsk_cls.ForeColor = System.Drawing.Color.Red;
            this.btn_dsk_cls.Name = "btn_dsk_cls";
            this.btn_dsk_cls.UseVisualStyleBackColor = true;
            this.btn_dsk_cls.Click += new System.EventHandler(this.btn_dsk_cls_Click);
            // 
            // frm_disclaimer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_dsk_cls);
            this.Controls.Add(this.txt_dsk_all);
            this.Controls.Add(this.txt_dsk__title_en);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_disclaimer";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_dsk__title_en;
        private System.Windows.Forms.TextBox txt_dsk_all;
        private System.Windows.Forms.Button btn_dsk_cls;

    }
}