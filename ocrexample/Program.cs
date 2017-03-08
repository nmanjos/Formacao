using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Drawing.Imaging;
using MosaiqPerformanceMonitor;

namespace ocrexample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static IImage imageresizer(string path)
        {
            Mat frame = new Mat();
            int width = 640, height = 480;
            

            frame = CvInvoke.Imread(path, ImreadModes.AnyColor);

            CvInvoke.Resize(frame, frame, new Size(width, height), 0, 0, Inter.Linear);    //This resizes the image into your specified width and height

            return frame;
        }




        static void Main()
        {

            // example  
            var image = ScreenCapture.CaptureActiveWindow();
            image.Save(@"C:\temp\snippetsource.jpg", ImageFormat.Jpeg);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
