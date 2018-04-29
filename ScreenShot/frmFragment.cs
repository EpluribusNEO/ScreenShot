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

    public partial class frmFragment : Form
    {
        
        private static Bitmap bMap;
        private delegate void xEvent(object sender, EventArgs e);  
        public frmFragment()
        {
            InitializeComponent();
        }
        
        private void panelFragment_DoubleClick(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            int x = FindForm().PointToScreen(c.Location).X;
            int y = FindForm().PointToScreen(c.Location).Y; 
            int w = c.Size.Width  + x;
            int h = c.Size.Height + y;

            bMap = new Bitmap(c.Size.Width, c.Size.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            System.Drawing.Graphics GFX  = System.Drawing.Graphics.FromImage(bMap);
            GFX.CopyFromScreen(x, y, 0, 0, c.Size, System.Drawing.CopyPixelOperation.SourceCopy);

            cScreenShot.SaveBitmap(bMap);
        }
    }
}
