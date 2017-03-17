using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocrexample
{
    public partial class image_load : Form
    {
        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        public image_load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getfile.ShowDialog();



        }

        private void getfile_FileOk(object sender, CancelEventArgs e)
        {

            ImageOCR.ImageLocation = getfile.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ImageOCR_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void ImageOCR_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect =
                new Rectangle(
                    Math.Min(RectStartPoint.X, tempEndPoint.X),
                    Math.Min(RectStartPoint.Y, tempEndPoint.Y),
                    Math.Abs(RectStartPoint.X - tempEndPoint.X),
                    Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            Invalidate(Rect);
            ImageOCR.Refresh();
        }

        private void ImageOCR_Paint(object sender, PaintEventArgs e)
        {
            // Draw the rectangle...
            if (ImageOCR.Image != null)
            {
                Brush brush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
                e.Graphics.FillRectangle(brush, Rect);
            }
        }
    }
}
