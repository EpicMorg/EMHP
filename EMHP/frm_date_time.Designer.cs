namespace EMHP
{
    partial class frm_date_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_date_time));
            this.month_date_1 = new System.Windows.Forms.MonthCalendar();
            this.btn_time_sel_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // month_date_1
            // 
            resources.ApplyResources(this.month_date_1, "month_date_1");
            this.month_date_1.Name = "month_date_1";
            // 
            // btn_time_sel_ok
            // 
            resources.ApplyResources(this.btn_time_sel_ok, "btn_time_sel_ok");
            this.btn_time_sel_ok.Name = "btn_time_sel_ok";
            this.btn_time_sel_ok.UseVisualStyleBackColor = true;
            this.btn_time_sel_ok.Click += new System.EventHandler(this.btn_time_sel_ok_Click);
            // 
            // frm_date_time
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_time_sel_ok);
            this.Controls.Add(this.month_date_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_date_time";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar month_date_1;
        private System.Windows.Forms.Button btn_time_sel_ok;
    }
}