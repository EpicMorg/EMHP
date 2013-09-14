using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EMHP
{
    public partial class frm_lng : Form
    {
        public frm_lng()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
        }

        private void btn_lng_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lng_ok_Click(object sender, EventArgs e)
        {
            /*
            if (lstlang.SelectedItems.Count == 0)
            {
                translator.Language = "builtin";
            }
            else
            {
                translator.Language = lstlang.SelectedItems[0].Text;
            }
            */
                this.Close();
        }

        private void btn_new_translate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporary%space%disabled","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frm_lng_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string lng in Directory.GetDirectories(Environment.CurrentDirectory + "\\translations\\"))
                {
                    try
                    {
                        lstlang.StateImageList.Images.Add(lng, Image.FromFile(Environment.CurrentDirectory + "\\translations\\" + lng + "\\icon.png"));
                        lstlang.Items.Add(lng, lng);
                    }
                    catch (System.Exception) { }
                }
            }
            catch (System.Exception) { }
        }
    }
}
