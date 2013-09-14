using System;
using System.Windows.Forms;
using System.Reflection;

namespace EMHP
{
    public partial class frm_opts : Form
    {
        public frm_opts()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
        }
        public void applychanges()
        {
            if (cbx_autorun.Checked)
            {
                try{System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\hostspatcher.bat", Assembly.GetExecutingAssembly().FullName + (cbx_minimized.Checked ? " -m" : ""));}
                catch (System.Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
       
      
        private void cbx_autorun_CheckedChanged(object sender, EventArgs e)
        {
                cbx_minimized.Enabled = cbx_autorun.Checked;
        }
        private void btn_lng_Click(object sender, EventArgs e)
        {
            frm_lng form_lang = new frm_lng();
            form_lang.ShowDialog();
        }
       
        private void btn_ok_Click(object sender, EventArgs e)
        {
            applychanges();
            this.Close();
        }
        private void btn_date_time_Click(object sender, EventArgs e)
        {
            frm_date_time form_date_time = new frm_date_time();
            form_date_time.ShowDialog();
        }

    
        

        
    }
}
