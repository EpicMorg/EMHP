using System;
using AeroApi;

namespace EMHP4 {
    public partial class FrmAbout : GlassWindow {
        public FrmAbout() {
            InitializeComponent();
            var ai = new AssemblyInfo();
            this.Text = String.Format( "О {0}", ai.AssemblyTitle );
            this.txt_vesion_null.Text = String.Format( "{0}", ai.AssemblyVersion );
            this.txt_cr.Text = ai.AssemblyCopyright;
        }
    }
}
