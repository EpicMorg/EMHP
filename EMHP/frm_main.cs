using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace EMHP
{
    //------херня для проверки на нажатия закрытия окна -------
   /* enum Mode : byte
    {
        /// <summary>
        /// Остаться
        /// </summary>
        notexittt,

        /// <summary>
        /// Выйти
        /// </summary>
        exittt,
    }
    */
    
    //---------------------------------------------------------
    public partial class frm_main : Form

    {
        //----херня для проверки на нажатия закрытия окна [2]-----
       // Mode frm_closing;
        //--------------------------------------------------------
       
        void fill_table()
        {
            try
            {
                dgv_db.Rows.Clear();
                string[][] sites = (File.ReadAllLines(txt_path_hosts.Text).Where<string>(x => (!string.IsNullOrEmpty(x) && !x.StartsWith("#"))).Select(x => x.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();
                dgv_db.Rows.Add(sites.Length);
                for (int i = 0; i < sites.Length; i++)
                {
                    try
                    {
                        dgv_db[0, i].Value = sites[i][0].StartsWith("127.0.0");
                        dgv_db[1, i].Value = sites[i][0];
                        dgv_db[2, i].Value = sites[i][1];
                    }
                    catch { }
                }

            }
            catch { }
        }
        public double op1 = 0;
        public frm_main()
        {
            
            Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
            this.Text = String.Format("{0}", AssemblyTitle);

          
        }
        private void refresh()
        {
            try { fill_table(); }
            catch (System.Exception ext) { MessageBox.Show(ext.Message, ext.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // 
        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        // 
        



        private void frm_main_Load(object sender, EventArgs e)
        {
            #if VERBOSE
            MessageBox.Show("Определена константа VERBOSE!", "Developer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #if DEBUG
            #region Developer mode
            if (Program.developer)
            {
                MessageBox.Show("Программа запущена в режиме разработчика!\r\nВизуальные эффекты отключены.\r\nДля возвращения в обычный режим отключите опцию -developer в настройках вашей IDE:\r\nСвойства проекта->Отладка->Параметры командной строки", "Девелоперы отаке111", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (Program.culture != CultureInfo.InstalledUICulture)
                {
                    MessageBox.Show(String.Format("Язык программы изменен на {0}\r\nЯзык системы:{1}\r\nДля отключения изменения языка зайдите в Свойства проекта->Отладка->Параметры командной строки\r\n и удалите параметр --culture", Program.culture.DisplayName, CultureInfo.InstalledUICulture.DisplayName), "Отладка работы языка))", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion
            #endif
            #endif
            if (Program.m) this.WindowState = FormWindowState.Minimized;
            txt_path_hosts.Text = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
            refresh();
            tm_open_trn.Start();
            fill_table();
        }
        private void btn_hosts_folder_browse_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc");
            }
            catch { }
        }
        private void menu_exit_Click(object sender, EventArgs e)
        {
            tm_transparent.Start();
        }
        private void menu_help_htu_Click(object sender, EventArgs e)
        {
            frm_hlp form_hlp = new frm_hlp();
            form_hlp.ShowDialog();
        }
        private void menu_about_Click(object sender, EventArgs e)
        {
            frm_about form_about = new frm_about();
            form_about.ShowDialog();
        }
        private void tm_transparent_Tick(object sender, EventArgs e)
        {
            if (!Program.developer)
            {
                if (op1 > 0) op1 -= 0.005;
                else Application.Exit();
                this.Opacity = op1;
            }
            else
            {
                Application.Exit();
                this.Opacity = op1;
            }
        }
        private void tm_open_trn_Tick(object sender, EventArgs e)
        {
            if (!Program.developer)
            {
                if (this.op1 < 1)
                {
                    this.Opacity = op1;
                    op1 += 0.005;
                }
                else tm_open_trn.Stop();
            }
            else
            {
                this.Opacity = 1;
                tm_open_trn.Stop();
            }
        }
        private void menu_opts_Click(object sender, EventArgs e)
        {
            frm_opts form_opts = new frm_opts();
            form_opts.ShowDialog();
        }
        private void menu_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void menu_disclaimer_Click(object sender, EventArgs e)
        {
            frm_disclaimer form_disclaimer = new frm_disclaimer();
            form_disclaimer.ShowDialog();
        }
        private void menu_save_Click(object sender, EventArgs e)
        {
        //    string txt = "";
        //   int xui=0;
        //    DataGridViewRow wt = new DataGridViewRow();
       //         for (xui = 0; xui < (dgv_db.Rows.Count -1); xui++)
       //         {
       //             wt = dgv_db.Rows[xui];
       //             if (wt.Cells[1].Value.ToString().Length > 0 && wt.Cells[2].Value.ToString().Length > 0) 
       //                 txt += wt.Cells[1].Value.ToString() +"\t"+ wt.Cells[2].Value.ToString() + "\r\n"; 
       //         }
       //     File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts", txt);
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "ipconfig";
                p.StartInfo.Arguments = "/flushdns";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                p.Start();
            }
            catch { }
        }
        private void menu_restore_Click(object sender, EventArgs e)
        {
            try{File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts.backup", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts"); }
            catch { }
        }
        private void menu_backup_Click(object sender, EventArgs e)
        {
            try { File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts.backup"); }
            catch { }
        }
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
          /*  if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                frm_closing = Mode.notexittt;
               
            }
            else
            {
                frm_closing = Mode.exittt;
                e.Cancel = true;
                 
            }*/
            tm_open_trn.Stop();
            tm_transparent.Start();
            
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.DataGridViewCell x in dgv_db.SelectedCells)
            {
                try { dgv_db.Rows.Remove(x.OwningRow); }
                catch { }
            }
        }
        private void dgv_db_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                dgv_db.Rows[e.RowIndex].Cells[1].Value = "127.0.0.1";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            dgv_db.Rows.Add();
        }

        private void dgv_db_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}