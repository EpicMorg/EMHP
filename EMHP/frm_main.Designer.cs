namespace EMHP
{
    partial class frm_main
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
            if (this.Opacity < 0.1)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mn_main = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_opts = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_disclaimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_help_htu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_host_view = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgv_db = new System.Windows.Forms.DataGridView();
            this.cl_banned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_path = new System.Windows.Forms.GroupBox();
            this.btn_hosts_folder_browse = new System.Windows.Forms.Button();
            this.txt_path_hosts = new System.Windows.Forms.TextBox();
            this.tm_transparent = new System.Windows.Forms.Timer(this.components);
            this.tm_open_trn = new System.Windows.Forms.Timer(this.components);
            this.tipmain = new System.Windows.Forms.ToolTip(this.components);
            this.brsSpam = new System.Windows.Forms.WebBrowser();
            this.mn_main.SuspendLayout();
            this.gb_host_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db)).BeginInit();
            this.gb_path.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn_main
            // 
            resources.ApplyResources(this.mn_main, "mn_main");
            this.mn_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_opts,
            this.menu_help});
            this.mn_main.Name = "mn_main";
            this.tipmain.SetToolTip(this.mn_main, resources.GetString("mn_main.ToolTip"));
            // 
            // menu_file
            // 
            resources.ApplyResources(this.menu_file, "menu_file");
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_minimize,
            this.toolStripSeparator2,
            this.menu_save,
            this.menu_restore,
            this.menu_backup,
            this.toolStripSeparator1,
            this.menu_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Click += new System.EventHandler(this.menu_backup_Click);
            // 
            // menu_minimize
            // 
            resources.ApplyResources(this.menu_minimize, "menu_minimize");
            this.menu_minimize.Name = "menu_minimize";
            this.menu_minimize.Click += new System.EventHandler(this.menu_minimize_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // menu_save
            // 
            resources.ApplyResources(this.menu_save, "menu_save");
            this.menu_save.Name = "menu_save";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_restore
            // 
            resources.ApplyResources(this.menu_restore, "menu_restore");
            this.menu_restore.Name = "menu_restore";
            this.menu_restore.Click += new System.EventHandler(this.menu_restore_Click);
            // 
            // menu_backup
            // 
            resources.ApplyResources(this.menu_backup, "menu_backup");
            this.menu_backup.Name = "menu_backup";
            this.menu_backup.Click += new System.EventHandler(this.menu_backup_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // menu_exit
            // 
            resources.ApplyResources(this.menu_exit, "menu_exit");
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // menu_opts
            // 
            resources.ApplyResources(this.menu_opts, "menu_opts");
            this.menu_opts.Name = "menu_opts";
            this.menu_opts.Click += new System.EventHandler(this.menu_opts_Click);
            // 
            // menu_help
            // 
            resources.ApplyResources(this.menu_help, "menu_help");
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_disclaimer,
            this.toolStripSeparator3,
            this.menu_help_htu,
            this.menu_about});
            this.menu_help.Name = "menu_help";
            // 
            // menu_disclaimer
            // 
            resources.ApplyResources(this.menu_disclaimer, "menu_disclaimer");
            this.menu_disclaimer.Name = "menu_disclaimer";
            this.menu_disclaimer.Click += new System.EventHandler(this.menu_disclaimer_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // menu_help_htu
            // 
            resources.ApplyResources(this.menu_help_htu, "menu_help_htu");
            this.menu_help_htu.Name = "menu_help_htu";
            this.menu_help_htu.Click += new System.EventHandler(this.menu_help_htu_Click);
            // 
            // menu_about
            // 
            resources.ApplyResources(this.menu_about, "menu_about");
            this.menu_about.Name = "menu_about";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // gb_host_view
            // 
            resources.ApplyResources(this.gb_host_view, "gb_host_view");
            this.gb_host_view.Controls.Add(this.btndel);
            this.gb_host_view.Controls.Add(this.btnadd);
            this.gb_host_view.Controls.Add(this.dgv_db);
            this.gb_host_view.Controls.Add(this.gb_path);
            this.gb_host_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_host_view.Name = "gb_host_view";
            this.gb_host_view.TabStop = false;
            this.tipmain.SetToolTip(this.gb_host_view, resources.GetString("gb_host_view.ToolTip"));
            // 
            // btndel
            // 
            resources.ApplyResources(this.btndel, "btndel");
            this.btndel.Name = "btndel";
            this.tipmain.SetToolTip(this.btndel, resources.GetString("btndel.ToolTip"));
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Name = "btnadd";
            this.tipmain.SetToolTip(this.btnadd, resources.GetString("btnadd.ToolTip"));
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgv_db
            // 
            resources.ApplyResources(this.dgv_db, "dgv_db");
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
            this.cl_adress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_db.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_db.Name = "dgv_db";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_db.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tipmain.SetToolTip(this.dgv_db, resources.GetString("dgv_db.ToolTip"));
            this.dgv_db.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_db_CellContentClick);
            this.dgv_db.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_db_CellValueChanged);
            // 
            // cl_banned
            // 
            resources.ApplyResources(this.cl_banned, "cl_banned");
            this.cl_banned.Name = "cl_banned";
            // 
            // cl_ip
            // 
            resources.ApplyResources(this.cl_ip, "cl_ip");
            this.cl_ip.Name = "cl_ip";
            // 
            // cl_adress
            // 
            resources.ApplyResources(this.cl_adress, "cl_adress");
            this.cl_adress.Name = "cl_adress";
            // 
            // gb_path
            // 
            resources.ApplyResources(this.gb_path, "gb_path");
            this.gb_path.Controls.Add(this.btn_hosts_folder_browse);
            this.gb_path.Controls.Add(this.txt_path_hosts);
            this.gb_path.Name = "gb_path";
            this.gb_path.TabStop = false;
            this.tipmain.SetToolTip(this.gb_path, resources.GetString("gb_path.ToolTip"));
            // 
            // btn_hosts_folder_browse
            // 
            resources.ApplyResources(this.btn_hosts_folder_browse, "btn_hosts_folder_browse");
            this.btn_hosts_folder_browse.Name = "btn_hosts_folder_browse";
            this.tipmain.SetToolTip(this.btn_hosts_folder_browse, resources.GetString("btn_hosts_folder_browse.ToolTip"));
            this.btn_hosts_folder_browse.UseVisualStyleBackColor = true;
            this.btn_hosts_folder_browse.Click += new System.EventHandler(this.btn_hosts_folder_browse_Click);
            // 
            // txt_path_hosts
            // 
            resources.ApplyResources(this.txt_path_hosts, "txt_path_hosts");
            this.txt_path_hosts.Name = "txt_path_hosts";
            this.txt_path_hosts.ReadOnly = true;
            this.tipmain.SetToolTip(this.txt_path_hosts, resources.GetString("txt_path_hosts.ToolTip"));
            // 
            // tm_transparent
            // 
            this.tm_transparent.Interval = 5;
            this.tm_transparent.Tick += new System.EventHandler(this.tm_transparent_Tick);
            // 
            // tm_open_trn
            // 
            this.tm_open_trn.Interval = 5;
            this.tm_open_trn.Tick += new System.EventHandler(this.tm_open_trn_Tick);
            // 
            // brsSpam
            // 
            resources.ApplyResources(this.brsSpam, "brsSpam");
            this.brsSpam.AllowWebBrowserDrop = false;
            this.brsSpam.IsWebBrowserContextMenuEnabled = false;
            this.brsSpam.Name = "brsSpam";
            this.brsSpam.ScriptErrorsSuppressed = true;
            this.brsSpam.ScrollBarsEnabled = false;
            this.tipmain.SetToolTip(this.brsSpam, resources.GetString("brsSpam.ToolTip"));
            this.brsSpam.Url = new System.Uri("http://download.epicm.org/EMHP/support/index.html", System.UriKind.Absolute);
            this.brsSpam.WebBrowserShortcutsEnabled = false;
            // 
            // frm_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brsSpam);
            this.Controls.Add(this.mn_main);
            this.Controls.Add(this.gb_host_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mn_main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Opacity = 0D;
            this.tipmain.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.mn_main.ResumeLayout(false);
            this.mn_main.PerformLayout();
            this.gb_host_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db)).EndInit();
            this.gb_path.ResumeLayout(false);
            this.gb_path.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn_main;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menu_help_htu;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_opts;
        private System.Windows.Forms.GroupBox gb_host_view;
        private System.Windows.Forms.GroupBox gb_path;
        private System.Windows.Forms.Button btn_hosts_folder_browse;
        private System.Windows.Forms.TextBox txt_path_hosts;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_restore;
        private System.Windows.Forms.ToolStripMenuItem menu_backup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer tm_transparent;
        private System.Windows.Forms.Timer tm_open_trn;
        private System.Windows.Forms.ToolStripMenuItem menu_minimize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_disclaimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgv_db;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ToolTip tipmain;
        private System.Windows.Forms.WebBrowser brsSpam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cl_banned;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_adress;


    }
}

