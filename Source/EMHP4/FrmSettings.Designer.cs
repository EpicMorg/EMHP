namespace EMHP4
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.pan_settings_null = new System.Windows.Forms.Panel();
            this.gbx_sites_ban = new System.Windows.Forms.GroupBox();
            this.dgv_sites_ban = new System.Windows.Forms.DataGridView();
            this.cl_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_myver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_newver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbtn_install = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbx_other = new System.Windows.Forms.GroupBox();
            this.lbl_lang_name = new System.Windows.Forms.Label();
            this.combo_langs = new System.Windows.Forms.ComboBox();
            this.btn_create_translate = new System.Windows.Forms.Button();
            this.lbl_lang_author = new System.Windows.Forms.Label();
            this.lbl_lng_autor_name = new System.Windows.Forms.Label();
            this.cbx_check_for_problems = new System.Windows.Forms.CheckBox();
            this.chbx_autostart = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.pan_settings_null.SuspendLayout();
            this.gbx_sites_ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sites_ban)).BeginInit();
            this.gbx_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_settings_null
            // 
            this.pan_settings_null.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_settings_null.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_settings_null.Controls.Add(this.gbx_other);
            this.pan_settings_null.Controls.Add(this.gbx_sites_ban);
            this.pan_settings_null.Location = new System.Drawing.Point(15, 15);
            this.pan_settings_null.Name = "pan_settings_null";
            this.pan_settings_null.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.pan_settings_null.Size = new System.Drawing.Size(538, 380);
            this.pan_settings_null.TabIndex = 0;
            // 
            // gbx_sites_ban
            // 
            this.gbx_sites_ban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_sites_ban.Controls.Add(this.dgv_sites_ban);
            this.gbx_sites_ban.Location = new System.Drawing.Point(9, 5);
            this.gbx_sites_ban.Name = "gbx_sites_ban";
            this.gbx_sites_ban.Size = new System.Drawing.Size(524, 220);
            this.gbx_sites_ban.TabIndex = 0;
            this.gbx_sites_ban.TabStop = false;
            this.gbx_sites_ban.Text = "Заблокировать опасные сайты (по категориям):";
            // 
            // dgv_sites_ban
            // 
            this.dgv_sites_ban.AllowUserToAddRows = false;
            this.dgv_sites_ban.AllowUserToDeleteRows = false;
            this.dgv_sites_ban.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_sites_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sites_ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_category,
            this.cl_myver,
            this.cl_newver,
            this.cl_size,
            this.clbtn_install});
            this.dgv_sites_ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sites_ban.Location = new System.Drawing.Point(3, 16);
            this.dgv_sites_ban.Name = "dgv_sites_ban";
            this.dgv_sites_ban.ReadOnly = true;
            this.dgv_sites_ban.Size = new System.Drawing.Size(518, 201);
            this.dgv_sites_ban.TabIndex = 0;
            // 
            // cl_category
            // 
            this.cl_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_category.HeaderText = "Категория";
            this.cl_category.Name = "cl_category";
            this.cl_category.ReadOnly = true;
            // 
            // cl_myver
            // 
            this.cl_myver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_myver.HeaderText = "Версия";
            this.cl_myver.Name = "cl_myver";
            this.cl_myver.ReadOnly = true;
            this.cl_myver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_myver.ToolTipText = "0.0";
            // 
            // cl_newver
            // 
            this.cl_newver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_newver.HeaderText = "На сервере";
            this.cl_newver.Name = "cl_newver";
            this.cl_newver.ReadOnly = true;
            this.cl_newver.ToolTipText = "0.0";
            // 
            // cl_size
            // 
            this.cl_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_size.HeaderText = "Записей";
            this.cl_size.Name = "cl_size";
            this.cl_size.ReadOnly = true;
            this.cl_size.ToolTipText = "102442424";
            // 
            // clbtn_install
            // 
            this.clbtn_install.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clbtn_install.HeaderText = "Действия";
            this.clbtn_install.Name = "clbtn_install";
            this.clbtn_install.ReadOnly = true;
            // 
            // gbx_other
            // 
            this.gbx_other.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_other.Controls.Add(this.btn_apply);
            this.gbx_other.Controls.Add(this.chbx_autostart);
            this.gbx_other.Controls.Add(this.cbx_check_for_problems);
            this.gbx_other.Controls.Add(this.lbl_lng_autor_name);
            this.gbx_other.Controls.Add(this.lbl_lang_author);
            this.gbx_other.Controls.Add(this.btn_create_translate);
            this.gbx_other.Controls.Add(this.combo_langs);
            this.gbx_other.Controls.Add(this.lbl_lang_name);
            this.gbx_other.Location = new System.Drawing.Point(12, 231);
            this.gbx_other.Name = "gbx_other";
            this.gbx_other.Size = new System.Drawing.Size(518, 142);
            this.gbx_other.TabIndex = 1;
            this.gbx_other.TabStop = false;
            this.gbx_other.Text = "Остальные настройки:";
            // 
            // lbl_lang_name
            // 
            this.lbl_lang_name.AutoSize = true;
            this.lbl_lang_name.Location = new System.Drawing.Point(6, 25);
            this.lbl_lang_name.Name = "lbl_lang_name";
            this.lbl_lang_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_lang_name.TabIndex = 0;
            this.lbl_lang_name.Text = "Язык программы:";
            // 
            // combo_langs
            // 
            this.combo_langs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_langs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_langs.FormattingEnabled = true;
            this.combo_langs.Items.AddRange(new object[] {
            "Default"});
            this.combo_langs.Location = new System.Drawing.Point(112, 22);
            this.combo_langs.Name = "combo_langs";
            this.combo_langs.Size = new System.Drawing.Size(267, 21);
            this.combo_langs.TabIndex = 1;
            // 
            // btn_create_translate
            // 
            this.btn_create_translate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_translate.Location = new System.Drawing.Point(385, 22);
            this.btn_create_translate.Name = "btn_create_translate";
            this.btn_create_translate.Size = new System.Drawing.Size(127, 23);
            this.btn_create_translate.TabIndex = 2;
            this.btn_create_translate.Text = "Создать перевод";
            this.btn_create_translate.UseVisualStyleBackColor = true;
            // 
            // lbl_lang_author
            // 
            this.lbl_lang_author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lang_author.AutoSize = true;
            this.lbl_lang_author.Location = new System.Drawing.Point(288, 55);
            this.lbl_lang_author.Name = "lbl_lang_author";
            this.lbl_lang_author.Size = new System.Drawing.Size(91, 13);
            this.lbl_lang_author.TabIndex = 3;
            this.lbl_lang_author.Text = "Автор перевода:";
            // 
            // lbl_lng_autor_name
            // 
            this.lbl_lng_autor_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lng_autor_name.AutoSize = true;
            this.lbl_lng_autor_name.Location = new System.Drawing.Point(385, 55);
            this.lbl_lng_autor_name.Name = "lbl_lng_autor_name";
            this.lbl_lng_autor_name.Size = new System.Drawing.Size(37, 13);
            this.lbl_lng_autor_name.TabIndex = 4;
            this.lbl_lng_autor_name.Text = "STAM";
            // 
            // cbx_check_for_problems
            // 
            this.cbx_check_for_problems.AutoSize = true;
            this.cbx_check_for_problems.Location = new System.Drawing.Point(9, 79);
            this.cbx_check_for_problems.Name = "cbx_check_for_problems";
            this.cbx_check_for_problems.Size = new System.Drawing.Size(345, 17);
            this.cbx_check_for_problems.TabIndex = 5;
            this.cbx_check_for_problems.Text = "Проверять файл на подозрительные записи и информировать";
            this.cbx_check_for_problems.UseVisualStyleBackColor = true;
            // 
            // chbx_autostart
            // 
            this.chbx_autostart.AutoSize = true;
            this.chbx_autostart.Location = new System.Drawing.Point(9, 102);
            this.chbx_autostart.Name = "chbx_autostart";
            this.chbx_autostart.Size = new System.Drawing.Size(359, 17);
            this.chbx_autostart.TabIndex = 6;
            this.chbx_autostart.Text = "Проверять и применять обновления баз при запуске программы";
            this.chbx_autostart.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Location = new System.Drawing.Point(388, 102);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(124, 23);
            this.btn_apply.TabIndex = 7;
            this.btn_apply.Text = "Применить";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 410);
            this.Controls.Add(this.pan_settings_null);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(584, 387);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EpicMorg Hosts Manager (ex. Hosts Patcher)";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.pan_settings_null.ResumeLayout(false);
            this.gbx_sites_ban.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sites_ban)).EndInit();
            this.gbx_other.ResumeLayout(false);
            this.gbx_other.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_settings_null;
        private System.Windows.Forms.GroupBox gbx_sites_ban;
        private System.Windows.Forms.DataGridView dgv_sites_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_myver;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_newver;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_size;
        private System.Windows.Forms.DataGridViewButtonColumn clbtn_install;
        private System.Windows.Forms.GroupBox gbx_other;
        private System.Windows.Forms.Button btn_create_translate;
        private System.Windows.Forms.ComboBox combo_langs;
        private System.Windows.Forms.Label lbl_lang_name;
        private System.Windows.Forms.Label lbl_lng_autor_name;
        private System.Windows.Forms.Label lbl_lang_author;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.CheckBox chbx_autostart;
        private System.Windows.Forms.CheckBox cbx_check_for_problems;
    }
}