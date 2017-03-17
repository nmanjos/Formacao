using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using ocrlib;

namespace ocrexample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap imgorig = ScreenCapturer.Capture();
            imgorig.Save("imageorig.jpg", ImageFormat.Jpeg);
            Bitmap imgresized = ImageProcessor.imageresizer(imgorig);
            imgresized.Save("imgresized.jpg", ImageFormat.Jpeg);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
