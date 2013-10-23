namespace EMHP4
{
    partial class FrmWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWarning));
            this.lbl_warning_title = new System.Windows.Forms.Label();
            this.pic_mainlogo = new System.Windows.Forms.PictureBox();
            this.chlist_strange_entries = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_recovery = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_warning_title
            // 
            this.lbl_warning_title.AutoSize = true;
            this.lbl_warning_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_warning_title.Location = new System.Drawing.Point(133, 9);
            this.lbl_warning_title.Name = "lbl_warning_title";
            this.lbl_warning_title.Size = new System.Drawing.Size(337, 15);
            this.lbl_warning_title.TabIndex = 5;
            this.lbl_warning_title.Text = "Внимание! Обнаружены подозрительные записи!";
            // 
            // pic_mainlogo
            // 
            this.pic_mainlogo.Image = global::EMHP4.Properties.Resources.yasaluyari2;
            this.pic_mainlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_mainlogo.Location = new System.Drawing.Point(12, 12);
            this.pic_mainlogo.Name = "pic_mainlogo";
            this.pic_mainlogo.Size = new System.Drawing.Size(115, 122);
            this.pic_mainlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mainlogo.TabIndex = 4;
            this.pic_mainlogo.TabStop = false;
            // 
            // chlist_strange_entries
            // 
            this.chlist_strange_entries.FormattingEnabled = true;
            this.chlist_strange_entries.Location = new System.Drawing.Point(136, 40);
            this.chlist_strange_entries.Name = "chlist_strange_entries";
            this.chlist_strange_entries.ScrollAlwaysVisible = true;
            this.chlist_strange_entries.Size = new System.Drawing.Size(199, 94);
            this.chlist_strange_entries.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rb_recovery
            // 
            this.rb_recovery.AutoSize = true;
            this.rb_recovery.Checked = true;
            this.rb_recovery.Location = new System.Drawing.Point(344, 65);
            this.rb_recovery.Name = "rb_recovery";
            this.rb_recovery.Size = new System.Drawing.Size(92, 17);
            this.rb_recovery.TabIndex = 8;
            this.rb_recovery.TabStop = true;
            this.rb_recovery.Text = "Обезвредить";
            this.rb_recovery.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(344, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "В исключения";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Действия над выбра\r\nнными объектами:";
            // 
            // frm_warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb_recovery);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chlist_strange_entries);
            this.Controls.Add(this.lbl_warning_title);
            this.Controls.Add(this.pic_mainlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarning";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EpicMorg Hosts Manager (ex. Hosts Patcher)";
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_mainlogo;
        private System.Windows.Forms.Label lbl_warning_title;
        private System.Windows.Forms.CheckedListBox chlist_strange_entries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_recovery;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
    }
}