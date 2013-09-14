using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlassMoth;

namespace EMHP4
{
    public partial class frm_settings : Form 
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

        public frm_settings()
        {
            InitializeComponent();
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
        private void frm_settings_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message n = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }
        #endregion
        //!------Мое любимое перетаскивание------

        private void frm_settings_Load(object sender, EventArgs e)
        {
            //-------Aero Api------
            #region aero api govnokod
            this.Paint -= new System.Windows.Forms.PaintEventHandler(this.frm_main_Paint);
            this.Refresh();
            this.RecreateHandle(); //needed if changing on the fly
            this.FitGlass();
            #endregion
            //!------Aero Api------
            combo_langs.SelectedIndex = 0;
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


    }
}
