using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Drawing.Imaging;
using ocrlib;
using Emgu.CV.Structure;
using System.Text;


namespace ocrexample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        



        static void Main()
        {

            //Get image
            //Resize to 1024x768
            // example  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
