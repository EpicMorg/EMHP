using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GlassMoth;

/*---------------------------------------TO---DO----------------------------------------/
 *                                                  									*
 *      2.  При запуске программы считывать сохраненные пользователем настройки.        *
 *      3.  В папке Bases лежат(будут) базы сайтов из которых будут                     *
 *      применяться баны. После применения бана в комментарии должна                    *
 *      быть метка(как открытие\закрытие тега, в данном случае - категории).            *
 *      3.1 Если в папке лежит файл, то программа в форме настроек может                *
 *      установить или перекачать файл(если новая версия).                              *
 *      4.  В папке lng лежат xml-языки. Твоей dll-кой пользователь может               *
 *      их создавать. English запилим сами(не в ресурсы).                               *
 *      5.  Добавить собственное комментирование. поскольку # - игнорируется,           *
 *      то пусть комментарий для проги будет спецсимволом. К примеру: #+.               *
 *      Прога отображает все со знака +. Парсер надо переделать?                        *
 *      6.  Запилить собственную проверку на подозрительные сайты.                      *
 *      Например,  на запись 1.2.3.5 vk.com прога среагирует,                           *
 *      если пользователь добавит строчку в исключение(спецкоммент?)                    *
 *      то прога будет в дальнейшем ее игнорировать (мини-антивирус).                   *
 *                                                                                      *
 ---------------------------------------TO---DO----------------------------------------*/

namespace EMHP4
{
    public partial class frm_main : Form
    {
        #region winapi1
        // margins for API call used in Paint
        // private Point dragStartPoint = new Point();
        // Rectangles; one for each edge of the form
        private VistaApi.Margins marg;
        private Rectangle topRect = Rectangle.Empty;
        private Rectangle botRect = Rectangle.Empty;
        private Rectangle lefRect = Rectangle.Empty;
        private Rectangle rigRect = Rectangle.Empty;
        #endregion

        #region filtable
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
        #endregion

        public frm_main()
        {
             InitializeComponent();
            this.FitGlass(); //winapi eroglass
        }
          
        //-------Aero Api------
        #region aero api govnokod
        private void FitGlass()
        {
            // If DWM is not enabled then get out
            if (!this.IsGlassEnabled())
            {
                return;
            }

            // Set the Margins to their default values
            marg.Top = 15; // extend from the top
            marg.Left = 15;  // not used in this sample but could be
            marg.Right = 15; // not used in this sample but could be
            marg.Bottom = 15;// not used in this sample but could be

            this.Paint += new PaintEventHandler(this.frm_main_Paint);

            // call the function that gives us glass, 
            // passing a reference to our inset Margins
            VistaApi.DwmExtendFrameIntoClientArea(this.Handle, ref marg);
        }

        private bool IsGlassEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
            {
              //  Debug.WriteLine("How about trying this on Vista?");
                this.BackColor = SystemColors.Control;
                return false;
            }

            //Check if DWM is enabled
            bool isGlassSupported = false;
            VistaApi.DwmIsCompositionEnabled(ref isGlassSupported);
            return isGlassSupported;
        }

        // Alpha-blending Paint after the glass extension
        // this seems better than the winforms transparency approach because here we can click on the glass!
        private void frm_main_Paint(object sender, PaintEventArgs e)
        {
            // black brush for Alpha transparency
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            Graphics g = e.Graphics;

            if (this.IsGlassEnabled())
            {
                // setup the rectangles
                topRect = new Rectangle(0, 0, this.ClientSize.Width, marg.Top);
                lefRect = new Rectangle(0, 0, marg.Left, this.ClientSize.Height);
                rigRect = new Rectangle(this.ClientSize.Width - marg.Right, 0, marg.Right, this.ClientSize.Height);
                botRect = new Rectangle(0, this.ClientSize.Height - marg.Bottom, this.ClientSize.Width, marg.Bottom);

                // Fill Rectangles
                g.FillRectangle(blackBrush, topRect);
                g.FillRectangle(blackBrush, lefRect);
                g.FillRectangle(blackBrush, rigRect);
                g.FillRectangle(blackBrush, botRect);
            }

           // g.DrawString("hello. Am I on glass?", this.Font, blackBrush, 10, 10);

            blackBrush.Dispose();
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == VistaApi.WM_NCHITTEST // if this is a click
              && m.Result.ToInt32() == VistaApi.HTCLIENT // ...and it is on the client
              && this.IsOnGlass(m.LParam.ToInt32())) // ...and specifically in the glass area
            {
                m.Result = new IntPtr(VistaApi.HTCAPTION); // lie and say they clicked on the title bar
            }
        }

        private bool IsOnGlass(int lParam)
        {
            // sanity check
            if (!this.IsGlassEnabled())
            {
                return false;
            }

            // get screen coordinates
            int x = (lParam << 16) >> 16; // lo order word
            int y = lParam >> 16; // hi order word

            // translate screen coordinates to client area
            Point p = this.PointToClient(new Point(x, y));

            // work out if point clicked is on glass
            if (topRect.Contains(p) || lefRect.Contains(p) || rigRect.Contains(p) || botRect.Contains(p))
            {
                return true;
            }

            return false;
        }

        #endregion
        //!------Aero Api------

        //-------Мое любимое перетаскивание------
        #region mousedown
        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message n = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }
        #endregion
        //!------Мое любимое перетаскивание------

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

        private void refresh()
        {
            try { fill_table(); }
            catch (System.Exception ext) { MessageBox.Show(ext.Message, ext.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //-------Aero Api------
            #region aero api govnokod
            this.Paint -= new System.Windows.Forms.PaintEventHandler(this.frm_main_Paint);
            this.Refresh();
            this.RecreateHandle(); //needed if changing on the fly
            this.FitGlass();
            #endregion
            //!------Aero Api------
            this.Text = String.Format("{0}", AssemblyTitle) + String.Format(" {0}", AssemblyVersion);
            refresh();
            txt_path_hosts.Text = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";  
            fill_table();  
        }
         

        //-------Aero Api------
        #region aero api govnokod
        private void frm_main_Resize(object sender, EventArgs e)
        {
            this.Paint -= new System.Windows.Forms.PaintEventHandler(this.frm_main_Paint);
            this.Refresh();
           this.FitGlass(); 
        }
         #endregion
        //!------Aero Api------
         

        #region dgv_db_Cell value changed
        private void dgv_db_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                dgv_db.Rows[e.RowIndex].Cells[1].Value = "127.0.0.1";
        }
        #endregion

        private void btn_hosts_folder_browse_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\");
        }

        #region addrow
         private void btnadd_Click(object sender, EventArgs e)
         {
             dgv_db.Rows.Add();
         }
         private void mmenu_add_Click(object sender, EventArgs e)
         {
             dgv_db.Rows.Add();
         }
         #endregion

        #region delete row
        private void delete_row()
        {
            foreach (System.Windows.Forms.DataGridViewCell x in dgv_db.SelectedCells)
            {
                try { dgv_db.Rows.Remove(x.OwningRow); }
                catch { }
            }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            delete_row();
        }
        private void mmenu_delite_Click(object sender, EventArgs e)
        {
            delete_row();
        }
        #endregion

        #region do backup
       private void do_backup()
       {
           MessageBox.Show("Работает резервирование\r\nНЕ ЧИНИТЬ");
           try { File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts.backup"); }
           catch { }
       }


       private void menu_backup_Click(object sender, EventArgs e)
       {
           do_backup();
       }

      
       private void mmenu_backup_Click(object sender, EventArgs e)
       {
           do_backup();
       }
#endregion

        #region dorestore
       private void do_restore()
       {
           MessageBox.Show("Не работает восстановление\r\nПОЧИНИТЬ");
           // try { File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts.backup", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts"); }
           // catch { } 
       }
       private void menu_restore_Click(object sender, EventArgs e)
       {
           do_restore();
       }


       private void mmenu_restore_Click(object sender, EventArgs e)
       { 
           do_restore(); 
       }
#endregion

        #region do_save
       private void do_save()
       {
           string txt = "";
           int xui = 0;
           DataGridViewRow wt = new DataGridViewRow();
           for (xui = 0; xui < (dgv_db.Rows.Count - 1); xui++)
           {

               //MessageBox.Show("1");
               wt = dgv_db.Rows[xui];
               if (wt.Cells[1].Value.ToString().Length > 0 && wt.Cells[2].Value.ToString().Length > 0)
                   txt += wt.Cells[1].Value.ToString() + "\t" + wt.Cells[2].Value.ToString() + "\r\n";
           }
           
           File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts", txt);
           try
           {
               MessageBox.Show("Сброс ipconfig /flushdns");

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
       private void mmenu_saveit_Click(object sender, EventArgs e)
       {
           do_save();
       } 
       private void сmenu_save_Click(object sender, EventArgs e)
       {
           do_save();
       }
        #endregion

       private void menu_exit_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void menu_about_Click(object sender, EventArgs e)
       {
           frm_about frmabout = new frm_about();
           frmabout.Show();
       }

       private void mmenu_settings_Click(object sender, EventArgs e)
       {
           frm_settings frmsettings = new frm_settings();
           frmsettings.Show();
       }
         
    }
 }
 