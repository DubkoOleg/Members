using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Members
{
    public partial class Form1 : Form
    {
        private Bitmap MyImage;

        public Form1()
        {
            InitializeComponent();

            var fileToDisplay = @"D:\Программмирование\GitHub\Members\Members\Members\Фото.jpg";

            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            MyImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //pictureBox.ClientSize = new Size(xSize, ySize);
            pictureBox.Image = (Image)MyImage;
        }
    }
}
