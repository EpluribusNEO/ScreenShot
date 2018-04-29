using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class FormMain : Form
    {
        frmFragment frmFrag;
        delegate void zEvent(object sender, EventArgs e);
        private static int _scrWidth  = Screen.PrimaryScreen.Bounds.Width;
        private static int _scrHeight = Screen.PrimaryScreen.Bounds.Height;
        public static Bitmap _bitmap = new Bitmap(_scrWidth, _scrHeight);
        public Bitmap _fragBitMap;

        public FormMain()
        {
            InitializeComponent();
            this.btnExit.Click += new EventHandler(evntExit);
            frmFrag = new frmFragment();
        }
        zEvent evntExit = (sender, EventArgs) => {Application.Exit(); };

        private void btnScreen_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Location = new Point(_scrWidth, _scrHeight);
            Graphics graph = Graphics.FromImage(_bitmap as Image);
            graph.CopyFromScreen(0, 0, 0, 0, _bitmap.Size);
            this.Location = new Point(x, y);
            frmScreen frmScr = new frmScreen();
            frmScr.ShowDialog();
        }

        private void btnFragment_Click(object sender, EventArgs e)
        {
            if(frmFrag == null || frmFrag.IsDisposed)
                frmFrag = new frmFragment(); 
            frmFrag.Show();
            frmFrag.WindowState = FormWindowState.Normal;
            frmFrag.Focus();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            cScreenShot.test();
        }
    }
}
