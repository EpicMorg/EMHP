using System;
using AeroApi;

namespace EMHP4 {
    public partial class FrmSettings : GlassWindow {

        public FrmSettings() {
            InitializeComponent();
        }
        private void frm_settings_Load( object sender, EventArgs e ) {
            combo_langs.SelectedIndex = 0;
        }
    }
}
