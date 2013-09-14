using System;
using System.Windows.Forms;

namespace EMHP
{
    public partial class frm_date_time : Form
    {
        public frm_date_time()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
        }

        private void btn_time_sel_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
