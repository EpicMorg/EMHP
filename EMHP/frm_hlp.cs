using System.Windows.Forms;

namespace EMHP
{
    public partial class frm_hlp : Form
    {
        public frm_hlp()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = Program.culture;
            InitializeComponent();
        }
    }
}
