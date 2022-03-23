using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageApp
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }
        private void initilzeBitmap(int Width, int Hight, Color color)
        {
            bitmap = new Bitmap(Width, Hight);
            for (int w = 0; w < bitmap.Width; w++)
            {
                for (int h = 0; h < bitmap.Height; h++)
                {
                    bitmap.SetPixel(w, h, color);
                }
            }

        }
        private void btnColorImage_Click(object sender, EventArgs e)
        {
            nudWidth.Visible = true;
            nudHight.Visible = true;
            btnColor.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            btnView.Visible = true;
        }
        private void btnColor_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void btnBrowseImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap bitmap2 = new Bitmap(ofd.FileName);

                pictureBox1.BackgroundImage = bitmap2;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            int width = (int)nudWidth.Value;
            int hight = (int)nudHight.Value;
            Color color = colorDialog1.Color;
            initilzeBitmap(width, hight, color);
            pictureBox1.BackgroundImage = bitmap;
        }
    }
}
