using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    static class cScreenShot
    {
        public static void test()
        {
            System.Windows.Forms.MessageBox.Show("1.0 (test)\nCreated by Hikaru\nall rights reserved (c) 2018","About");
        }

        public static void SaveBitmap(Bitmap pic)
        {
            SaveFileDialog savdlg = new SaveFileDialog();
            savdlg.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|BMP|*.bmp";
            if(savdlg.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Imaging.ImageFormat format = ImageFormat.Jpeg;
                switch(savdlg.FilterIndex)    //Тут мы просто получаем индекс выбранного расширения, и переключаемся...
                {                             //desu: положение в  SaveFileDialog.Filter в строке ""JPEG|*.jpg|PNG|*.png", будет влиять на их индекс, начала с 1                                                                     
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Png;
                        break;
                    case 3:
                        format = ImageFormat.Gif;
                        break;
                    case 4:
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                }
                pic.Save(savdlg.FileName, format); 
            }
        }
    }
}
