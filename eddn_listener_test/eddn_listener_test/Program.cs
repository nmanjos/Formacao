using Ionic.Zlib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroMQ;

namespace eddn_listener_test
{
    
    static class Program
    {
        public static bool m_Active = true;
        public static string m_Adress = "tcp://eddn-relay.elite-markets.net:9500";
        public static Queue<EDDNStream> Response = new Queue<EDDNStream>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Parallel.Invoke(() => Application.Run(new Form1()), () => Subscribe());
        }
        public static void Subscribe()
        {

            m_Active = true;

            using (var ctx = ZContext.Create())
            {
                using (var socket = new ZSocket(ctx, ZSocketType.SUB))
                {
                    socket.SubscribeAll();
                    socket.Connect(m_Adress);
                    while (m_Active)
                    {
                        ZFrame frame = socket.ReceiveFrame();
                        var decompressedFileStream = new MemoryStream();
                        if (frame != null)
                        {
                            using (var ms = new MemoryStream())
                            {
                                frame.CopyTo(ms);
                                ms.Position = 0;
                                using (var stream = new ZlibStream(ms, CompressionMode.Decompress))
                                using (var sr = new StreamReader(stream))
                                {
                                    string msg = sr.ReadToEnd();
                                    if (msg.Contains("FSDJump") && !msg.Contains("$government_None;"))
                                    {
                                        EDDNStream Data = EDDNData(msg);
                                        Response.Enqueue(Data);
                                        
                                    }

                                }
                            }
                        }
                        Thread.Sleep(100);
                    }
                    
                }
            }
        }
        public static EDDNStream EDDNData(string str)
        {
            EDDNStream Data = new EDDNStream();
            
                if (!string.IsNullOrEmpty(str) || !string.IsNullOrWhiteSpace(str))
                {
                    Data = JsonConvert.DeserializeObject<EDDNStream>(str);
                    Thread.Sleep(150);
                }
            return Data;
        }
        
    }
    
}
