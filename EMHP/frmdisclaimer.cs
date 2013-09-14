using System;
using System.Windows.Forms;

namespace EMHP
{
    public partial class frm_disclaimer : Form
    {
        public frm_disclaimer()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
        }

        private void btn_dsk_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
