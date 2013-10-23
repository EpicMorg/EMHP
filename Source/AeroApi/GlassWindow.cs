using System;
using System.Drawing;
using System.Windows.Forms;

namespace AeroApi {
    public
#if !DEBUG
        abstract
#endif
        class GlassWindow : Form {
        #region winapi1
        private VistaApi.Margins _marg;
        private Rectangle _topRect = Rectangle.Empty;
        private Rectangle _botRect = Rectangle.Empty;
        private Rectangle _lefRect = Rectangle.Empty;
        private Rectangle _rigRect = Rectangle.Empty;
        #endregion
        protected GlassWindow() {
            this.Load += OnFormLoad;
            this.Resize += this.OnFormResize;
            this.MouseDown += OnFormMouseDown;
        }
        #region aero api govnokod
        private void FitGlass() {
            // If DWM is not enabled then get out
            if ( !this.IsGlassEnabled() )
                return;
            // Set the Margins to their default values
            this._marg.Top = 15; // extend from the top
            this._marg.Left = 15;  // not used in this sample but could be
            this._marg.Right = 15; // not used in this sample but could be
            this._marg.Bottom = 15;// not used in this sample but could be

            this.Paint += this.OnFormPaint;
            // call the function that gives us glass, 
            // passing a reference to our inset Margins
            VistaApi.DwmExtendFrameIntoClientArea( this.Handle, ref this._marg );
        }
        private bool IsGlassEnabled() {
            if ( Environment.OSVersion.Version.Major < 6 ) {
                this.BackColor = SystemColors.Control;
                return false;
            }
            //Check if DWM is enabled
            var isGlassSupported = false;
            VistaApi.DwmIsCompositionEnabled( ref isGlassSupported );
            return isGlassSupported;
        }
        protected override void WndProc( ref Message m ) {
            base.WndProc( ref m );

            if ( m.Msg == VistaApi.WM_NCHITTEST // if this is a click
              && m.Result.ToInt32() == VistaApi.HTCLIENT // ...and it is on the client
              && this.IsOnGlass( m.LParam.ToInt32() ) ) // ...and specifically in the glass area
                m.Result = new IntPtr( VistaApi.HTCAPTION ); // lie and say they clicked on the title bar
        }
        private bool IsOnGlass( int lParam ) {
            // sanity check
            if ( !this.IsGlassEnabled() )
                return false;
            // get screen coordinates
            var x = ( lParam << 16 ) >> 16; // lo order word
            var y = lParam >> 16; // hi order word
            // translate screen coordinates to client area
            var p = this.PointToClient( new Point( x, y ) );
            // work out if point clicked is on glass
            return this._topRect.Contains( p ) || this._lefRect.Contains( p ) || this._rigRect.Contains( p ) || this._botRect.Contains( p );
        }
        #endregion
        #region Handlers
        private void OnFormPaint( object sender, PaintEventArgs e ) {
            // black brush for Alpha transparency
            var blackBrush = new SolidBrush( Color.Black );
            using ( var g = e.Graphics ) {
                if ( this.IsGlassEnabled() ) {
                    // setup the rectangles
                    this._topRect = new Rectangle( 0, 0, this.ClientSize.Width, this._marg.Top );
                    this._lefRect = new Rectangle( 0, 0, this._marg.Left, this.ClientSize.Height );
                    this._rigRect = new Rectangle( this.ClientSize.Width - this._marg.Right, 0, this._marg.Right, this.ClientSize.Height );
                    this._botRect = new Rectangle( 0, this.ClientSize.Height - this._marg.Bottom, this.ClientSize.Width, this._marg.Bottom );

                    // Fill Rectangles
                    g.FillRectangle( blackBrush, this._topRect );
                    g.FillRectangle( blackBrush, this._lefRect );
                    g.FillRectangle( blackBrush, this._rigRect );
                    g.FillRectangle( blackBrush, this._botRect );
                }
                g.Flush();
            }
            // g.DrawString("hello. Am I on glass?", this.Font, blackBrush, 10, 10);
            blackBrush.Dispose();
        }
        private void OnFormResize( object sender, EventArgs e ) {
            this.Paint -= this.OnFormPaint;
            this.Refresh();
            this.FitGlass();
        }
        private void OnFormLoad( object sender, EventArgs e ) {
            this.Paint -= this.OnFormPaint;
            this.Refresh();
            this.RecreateHandle();
            this.FitGlass();
        }
        private void OnFormMouseDown( object sender, MouseEventArgs e ) {
            this.Capture = false;
            var n = Message.Create( this.Handle, 0xa1, new IntPtr( 2 ), IntPtr.Zero );
            this.WndProc( ref n );
        }
        #endregion
    }
}
