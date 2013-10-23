namespace EMHP4
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel_main = new System.Windows.Forms.Panel();
            this.gb_path = new System.Windows.Forms.GroupBox();
            this.btn_hosts_folder_browse = new System.Windows.Forms.Button();
            this.txt_path_hosts = new System.Windows.Forms.TextBox();
            this.dgv_db = new System.Windows.Forms.DataGridView();
            this.cl_banned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сmenu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnadd = new System.Windows.Forms.ToolStripMenuItem();
            this.btndel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu = new System.Windows.Forms.MenuStrip();
            this.mmenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_saveit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mmenu_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_htu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            this.gb_path.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db)).BeginInit();
            this.menu.SuspendLayout();
            this.mmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.gb_path);
            this.panel_main.Controls.Add(this.dgv_db);
            this.panel_main.Controls.Add(this.mmenu);
            this.panel_main.Location = new System.Drawing.Point(15, 15);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(548, 399);
            this.panel_main.TabIndex = 4;
            // 
            // gb_path
            // 
            this.gb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_path.Controls.Add(this.btn_hosts_folder_browse);
            this.gb_path.Controls.Add(this.txt_path_hosts);
            this.gb_path.Location = new System.Drawing.Point(3, 343);
            this.gb_path.Name = "gb_path";
            this.gb_path.Size = new System.Drawing.Size(540, 51);
            this.gb_path.TabIndex = 7;
            this.gb_path.TabStop = false;
            this.gb_path.Text = "Путь к файлу hosts";
            // 
            // btn_hosts_folder_browse
            // 
            this.btn_hosts_folder_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hosts_folder_browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_hosts_folder_browse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_hosts_folder_browse.Location = new System.Drawing.Point(488, 17);
            this.btn_hosts_folder_browse.Name = "btn_hosts_folder_browse";
            this.btn_hosts_folder_browse.Size = new System.Drawing.Size(40, 23);
            this.btn_hosts_folder_browse.TabIndex = 1;
            this.btn_hosts_folder_browse.Text = "...";
            this.btn_hosts_folder_browse.UseVisualStyleBackColor = true;
            this.btn_hosts_folder_browse.Click += new System.EventHandler(this.btn_hosts_folder_browse_Click);
            // 
            // txt_path_hosts
            // 
            this.txt_path_hosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_path_hosts.Location = new System.Drawing.Point(15, 19);
            this.txt_path_hosts.Name = "txt_path_hosts";
            this.txt_path_hosts.ReadOnly = true;
            this.txt_path_hosts.Size = new System.Drawing.Size(467, 22);
            this.txt_path_hosts.TabIndex = 0;
            // 
            // dgv_db
            // 
            this.dgv_db.AllowUserToAddRows = false;
            this.dgv_db.AllowUserToDeleteRows = false;
            this.dgv_db.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_db.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_db.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_db.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_banned,
            this.cl_ip,
            this.cl_adress,
            this.cl_comment});
            this.dgv_db.ContextMenuStrip = this.menu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_db.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_db.Location = new System.Drawing.Point(0, 27);
            this.dgv_db.Name = "dgv_db";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_db.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_db.Size = new System.Drawing.Size(546, 310);
            this.dgv_db.TabIndex = 6;
            this.dgv_db.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_db_CellContentClick);
            this.dgv_db.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_db_CellValueChanged);
            // 
            // cl_banned
            // 
            this.cl_banned.HeaderText = "";
            this.cl_banned.Name = "cl_banned";
            this.cl_banned.Width = 50;
            // 
            // cl_ip
            // 
            this.cl_ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_ip.HeaderText = "IP";
            this.cl_ip.Name = "cl_ip";
            // 
            // cl_adress
            // 
            this.cl_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_adress.HeaderText = "Сайт";
            this.cl_adress.Name = "cl_adress";
            // 
            // cl_comment
            // 
            this.cl_comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_comment.HeaderText = "Комментарий";
            this.cl_comment.Name = "cl_comment";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сmenu_save,
            this.toolStripSeparator2,
            this.btnadd,
            this.btndel,
            this.toolStripSeparator1,
            this.menu_backup,
            this.menu_restore});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(169, 126);
            // 
            // сmenu_save
            // 
            this.сmenu_save.Name = "сmenu_save";
            this.сmenu_save.Size = new System.Drawing.Size(168, 22);
            this.сmenu_save.Text = "Сохранить";
            this.сmenu_save.Click += new System.EventHandler(this.UISave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // btnadd
            // 
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(168, 22);
            this.btnadd.Text = "Добавить запись";
            this.btnadd.Click += new System.EventHandler(this.UIAddRow);
            // 
            // btndel
            // 
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(168, 22);
            this.btndel.Text = "Удалить запись";
            this.btndel.Click += new System.EventHandler(this.UIDelRow);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // menu_backup
            // 
            this.menu_backup.Name = "menu_backup";
            this.menu_backup.Size = new System.Drawing.Size(168, 22);
            this.menu_backup.Text = "Зарезервировать";
            this.menu_backup.Click += new System.EventHandler(this.UIBackup);
            // 
            // menu_restore
            // 
            this.menu_restore.Name = "menu_restore";
            this.menu_restore.Size = new System.Drawing.Size(168, 22);
            this.menu_restore.Text = "Восстановить";
            this.menu_restore.Click += new System.EventHandler(this.UIRestore);
            // 
            // mmenu
            // 
            this.mmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmenu_file,
            this.mmenu_edit,
            this.mmenu_settings,
            this.menu_help});
            this.mmenu.Location = new System.Drawing.Point(0, 0);
            this.mmenu.Name = "mmenu";
            this.mmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mmenu.Size = new System.Drawing.Size(546, 24);
            this.mmenu.TabIndex = 8;
            this.mmenu.Text = "Menu";
            // 
            // mmenu_file
            // 
            this.mmenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmenu_saveit,
            this.mmenu_backup,
            this.mmenu_restore,
            this.toolStripSeparator3,
            this.menu_exit});
            this.mmenu_file.Name = "mmenu_file";
            this.mmenu_file.Size = new System.Drawing.Size(48, 20);
            this.mmenu_file.Text = "Файл";
            // 
            // mmenu_saveit
            // 
            this.mmenu_saveit.Name = "mmenu_saveit";
            this.mmenu_saveit.Size = new System.Drawing.Size(181, 22);
            this.mmenu_saveit.Text = "Сохранить";
            this.mmenu_saveit.Click += new System.EventHandler(this.UISave);
            // 
            // mmenu_backup
            // 
            this.mmenu_backup.Name = "mmenu_backup";
            this.mmenu_backup.Size = new System.Drawing.Size(181, 22);
            this.mmenu_backup.Text = "Зарезервировать";
            this.mmenu_backup.Click += new System.EventHandler(this.UIBackup);
            // 
            // mmenu_restore
            // 
            this.mmenu_restore.Name = "mmenu_restore";
            this.mmenu_restore.Size = new System.Drawing.Size(181, 22);
            this.mmenu_restore.Text = "Восстановить файл";
            this.mmenu_restore.Click += new System.EventHandler(this.UIRestore);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(181, 22);
            this.menu_exit.Text = "Выход";
            this.menu_exit.Click += new System.EventHandler(this.UIExit);
            // 
            // mmenu_edit
            // 
            this.mmenu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmenu_add,
            this.mmenu_delete});
            this.mmenu_edit.Name = "mmenu_edit";
            this.mmenu_edit.Size = new System.Drawing.Size(59, 20);
            this.mmenu_edit.Text = "Правка";
            // 
            // mmenu_add
            // 
            this.mmenu_add.Name = "mmenu_add";
            this.mmenu_add.Size = new System.Drawing.Size(166, 22);
            this.mmenu_add.Text = "Добавить запись";
            this.mmenu_add.Click += new System.EventHandler(this.UIAddRow);
            // 
            // mmenu_delete
            // 
            this.mmenu_delete.Name = "mmenu_delete";
            this.mmenu_delete.Size = new System.Drawing.Size(166, 22);
            this.mmenu_delete.Text = "Удалить запись";
            this.mmenu_delete.Click += new System.EventHandler(this.UIDelRow);
            // 
            // mmenu_settings
            // 
            this.mmenu_settings.Name = "mmenu_settings";
            this.mmenu_settings.Size = new System.Drawing.Size(78, 20);
            this.mmenu_settings.Text = "Настройка";
            this.mmenu_settings.Click += new System.EventHandler(this.UISettings);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_htu,
            this.menu_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(68, 20);
            this.menu_help.Text = "Помощь";
            // 
            // menu_htu
            // 
            this.menu_htu.Enabled = false;
            this.menu_htu.Name = "menu_htu";
            this.menu_htu.Size = new System.Drawing.Size(149, 22);
            this.menu_htu.Text = "Справка";
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(149, 22);
            this.menu_about.Text = "О программе";
            this.menu_about.Click += new System.EventHandler(this.UIAbout);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 429);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mmenu;
            this.MinimumSize = new System.Drawing.Size(355, 203);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EpicMorg Hosts Manager (ex. Hosts Patcher)";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.gb_path.ResumeLayout(false);
            this.gb_path.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db)).EndInit();
            this.menu.ResumeLayout(false);
            this.mmenu.ResumeLayout(false);
            this.mmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btnadd;
        private System.Windows.Forms.ToolStripMenuItem btndel;
        private System.Windows.Forms.DataGridView dgv_db;
        private System.Windows.Forms.GroupBox gb_path;
        private System.Windows.Forms.Button btn_hosts_folder_browse;
        private System.Windows.Forms.TextBox txt_path_hosts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сmenu_save;
        private System.Windows.Forms.MenuStrip mmenu;
        private System.Windows.Forms.ToolStripMenuItem mmenu_file;
        private System.Windows.Forms.ToolStripMenuItem mmenu_saveit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_restore;
        private System.Windows.Forms.ToolStripMenuItem menu_backup;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem mmenu_backup;
        private System.Windows.Forms.ToolStripMenuItem mmenu_restore;
        private System.Windows.Forms.ToolStripMenuItem mmenu_edit;
        private System.Windows.Forms.ToolStripMenuItem mmenu_delete;
        private System.Windows.Forms.ToolStripMenuItem mmenu_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_htu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_banned;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_comment;
        private System.Windows.Forms.ToolStripMenuItem mmenu_settings;

    }
}

