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
    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;//PictureBoxSizeMode.StretchImage;
            pictureBox.Image = FormMain._bitmap;
            this.closeToolStripMenuItem.Click += (sender, EventArgs) => { this.Close(); };
            this.WindowState = FormWindowState.Maximized;
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cScreenShot.SaveBitmap(FormMain._bitmap);
        }

    }

}
