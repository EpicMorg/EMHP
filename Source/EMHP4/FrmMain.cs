using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AeroApi;
namespace EMHP4 {
    public partial class FrmMain : GlassWindow {
        private readonly string _hostsPath = Path.Combine(
            Environment.GetFolderPath( Environment.SpecialFolder.System ),
            "drivers",
            "etc",
            "hosts"
        );
        private string HostsPath {
            get { return _hostsPath; }
        }

        private void Backup() {
            try {
                File.Delete( this.HostsPath + ".backup" );
                File.Copy( this.HostsPath, this.HostsPath + ".backup" );
            }
            catch ( UnauthorizedAccessException ) {
                ErrorBox( "Невозможно получить доступ к файлу. Перезапустите программу с правами администратора" );
            }
            catch ( Exception ex ) { ErrorBox( "Не удалось сделать резервную копию:\r\n" + ex.Message ); }
        }
        private void Restore() {
            try {
                File.Delete( this.HostsPath );
                File.Copy( this.HostsPath + ".backup", this.HostsPath );
            }
            catch ( UnauthorizedAccessException ) {
                ErrorBox( "Невозможно получить доступ к файлу. Перезапустите программу с правами администратора" );
            }
            catch ( Exception ex ) { ErrorBox( "Не удалось восстановить резервную копию:\r\n" + ex.Message ); }
        }
        private void Save() {
            var txt = new StringBuilder();
            foreach (DataGridViewRow wt in dgv_db.Rows) {
                var ip = wt.Cells[ 1 ].Value as string;
                var host = wt.Cells[ 2 ].Value as string;
                if ( !String.IsNullOrWhiteSpace( ip ) && !String.IsNullOrWhiteSpace( host ) )
                    txt.AppendFormat( "{0}\t{1}\r\n", ip, host );
            }
            try {
                File.WriteAllText( this.HostsPath, txt.ToString() );
            }
            catch ( UnauthorizedAccessException ) {
                ErrorBox( "Невозможно получить доступ к файлу. Перезапустите программу с правами администратора" );
            }
            catch ( Exception ex ) {
                ErrorBox( "Произошла ошибка при сохранении:\r\n" + ex.Message );
            }

            FlushDNS();
        }
        private static void FlushDNS() {
            try {
                new Process {
                    StartInfo = {
                        FileName = "ipconfig",
                        Arguments = "/flushdns",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                }.Start();
            }
            catch ( Exception ) {
                ErrorBox( "Не удалось сбросить кэш DNS" );
            }
        }
        #region UI builders

        public FrmMain() {
            InitializeComponent();
        }
        private void RefillTable() {
            dgv_db.Rows.Clear();
            var splitChars = new[] {
                    '\t',
                    ' '
                };
            var rows = File.ReadAllLines( this.HostsPath )
                .Select( a => a.Trim() )
                .Where( x => ( !string.IsNullOrEmpty( x ) && !x.StartsWith( "#" ) ) )
                .Select( x => x.Split( splitChars, StringSplitOptions.RemoveEmptyEntries ) )
                .Where( a => a.Length >= 2 )
                .Select( this.BuildRow )
                .Where( a => a != null )
                .ToArray();
            this.dgv_db.Rows.AddRange( rows );
        }

        private DataGridViewRow BuildRow( string[] a ) {
            var row = this.dgv_db.RowTemplate.Clone() as DataGridViewRow;
            if ( row != null ) row.CreateCells( this.dgv_db, a[ 0 ].StartsWith( "127.0.0." ), a[ 0 ], a[ 1 ] );
            return row;
        }
        private void DelSelectedRows() {
            dgv_db.SuspendLayout();
            this.SuspendLayout();
            foreach ( var rowIndex in dgv_db.SelectedCells.OfType<DataGridViewCell>().Select( a => a.RowIndex ).Distinct().OrderByDescending( a => a ).ToArray() )
                dgv_db.Rows.RemoveAt( rowIndex );
            dgv_db.ResumeLayout();
            this.ResumeLayout();
            Application.DoEvents();
        }
        private void UserRefillTable() {
            try { RefillTable(); }
            catch ( Exception ex ) { ErrorBox( ex.Message ); }
        }
        private static void ErrorBox( string message ) {
            MessageBox.Show( message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        #endregion
        #region UIHandlers
        private void frm_main_Load( object sender, EventArgs e ) {
            var ai = new AssemblyInfo();
            this.Text = String.Format( "{0}", ai.AssemblyTitle ) + String.Format( " {0}", ai.AssemblyVersion );
            txt_path_hosts.Text = this.HostsPath;
            UserRefillTable();
        }
        private void btn_hosts_folder_browse_Click( object sender, EventArgs e ) { Process.Start( Path.GetDirectoryName( this.HostsPath ) ); }
        private void UIAddRow( object sender, EventArgs e ) { dgv_db.Rows.Add(); }
        private void UIDelRow( object sender, EventArgs e ) { DelSelectedRows(); }
        private void UIBackup( object sender, EventArgs e ) { Backup(); }
        private void UIRestore( object sender, EventArgs e ) { Restore(); }
        private void UISave( object sender, EventArgs e ) { Save(); }
        private void UIExit( object sender, EventArgs e ) { Application.Exit(); }
        private void UIAbout( object sender, EventArgs e ) { new FrmAbout().Show(); }
        private void UISettings( object sender, EventArgs e ) { new FrmSettings().Show(); }
        private void dgv_db_CellContentClick( object sender, DataGridViewCellEventArgs e ) { dgv_db.CommitEdit( DataGridViewDataErrorContexts.Commit ); }
        #endregion
        private void dgv_db_CellValueChanged( object sender, DataGridViewCellEventArgs e ) {
            int ci = e.ColumnIndex,
                ri = e.RowIndex;
            if ( ci == 0 && ri >= 0 )
                dgv_db[ 1, ri ].Value = ( !(bool) dgv_db[ ci, ri ].Value ) ? "" : "127.0.0.1";
        }
    }
}
