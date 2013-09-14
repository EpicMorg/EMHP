namespace EMHP
{
    partial class frm_lng
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lng));
            this.btn_lng_ok = new System.Windows.Forms.Button();
            this.btn_lng_cancel = new System.Windows.Forms.Button();
            this.gb_lng_select = new System.Windows.Forms.GroupBox();
            this.lstlang = new System.Windows.Forms.ListView();
            this.a = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_new_translate = new System.Windows.Forms.Button();
            this.txt1_lang_select_help = new System.Windows.Forms.TextBox();
            this.gb_lng_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_lng_ok
            // 
            resources.ApplyResources(this.btn_lng_ok, "btn_lng_ok");
            this.btn_lng_ok.Name = "btn_lng_ok";
            this.btn_lng_ok.UseVisualStyleBackColor = true;
            this.btn_lng_ok.Click += new System.EventHandler(this.btn_lng_ok_Click);
            // 
            // btn_lng_cancel
            // 
            resources.ApplyResources(this.btn_lng_cancel, "btn_lng_cancel");
            this.btn_lng_cancel.Name = "btn_lng_cancel";
            this.btn_lng_cancel.UseVisualStyleBackColor = true;
            this.btn_lng_cancel.Click += new System.EventHandler(this.btn_lng_cancel_Click);
            // 
            // gb_lng_select
            // 
            resources.ApplyResources(this.gb_lng_select, "gb_lng_select");
            this.gb_lng_select.Controls.Add(this.lstlang);
            this.gb_lng_select.Controls.Add(this.btn_new_translate);
            this.gb_lng_select.Controls.Add(this.btn_lng_cancel);
            this.gb_lng_select.Controls.Add(this.btn_lng_ok);
            this.gb_lng_select.Name = "gb_lng_select";
            this.gb_lng_select.TabStop = false;
            // 
            // lstlang
            // 
            resources.ApplyResources(this.lstlang, "lstlang");
            this.lstlang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.a});
            this.lstlang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lstlang.Items")))});
            this.lstlang.LargeImageList = this.imageList1;
            this.lstlang.Name = "lstlang";
            this.lstlang.SmallImageList = this.imageList1;
            this.lstlang.UseCompatibleStateImageBehavior = false;
            this.lstlang.View = System.Windows.Forms.View.Details;
            // 
            // a
            // 
            resources.ApplyResources(this.a, "a");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "englisch-flag2.jpg");
            // 
            // btn_new_translate
            // 
            resources.ApplyResources(this.btn_new_translate, "btn_new_translate");
            this.btn_new_translate.Name = "btn_new_translate";
            this.btn_new_translate.UseVisualStyleBackColor = true;
            this.btn_new_translate.Click += new System.EventHandler(this.btn_new_translate_Click);
            // 
            // txt1_lang_select_help
            // 
            resources.ApplyResources(this.txt1_lang_select_help, "txt1_lang_select_help");
            this.txt1_lang_select_help.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt1_lang_select_help.Name = "txt1_lang_select_help";
            this.txt1_lang_select_help.ReadOnly = true;
            this.txt1_lang_select_help.ShortcutsEnabled = false;
            // 
            // frm_lng
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt1_lang_select_help);
            this.Controls.Add(this.gb_lng_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_lng";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_lng_Load);
            this.gb_lng_select.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lng_ok;
        private System.Windows.Forms.Button btn_lng_cancel;
        private System.Windows.Forms.GroupBox gb_lng_select;
        private System.Windows.Forms.Button btn_new_translate;
        private System.Windows.Forms.TextBox txt1_lang_select_help;
        private System.Windows.Forms.ListView lstlang;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.ImageList imageList1;
    }
}