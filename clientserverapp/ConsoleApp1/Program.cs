using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using ZeroMQ;
using System.Threading;
using System.IO;
using System.Diagnostics;
using Ionic.Zlib;

namespace eddnServer
{
    class Program
    {
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static bool m_Active=true;
        private static string m_Adress = "tcp://eddn-relay.elite-markets.net:9500";
        private static Queue<string> Response = new Queue<string>();

        static void Main(string[] args)
        {
            Parallel.Invoke(() => SetupServer(), () => Subscribe());

            Console.ReadLine();
        }
        private static void SetupServer()
        {
            Console.WriteLine("Setting up Server ...");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 10000));
            _serverSocket.Listen(1);
            Console.WriteLine("Listening on Port 10000");
            _serverSocket.BeginAccept(new AsyncCallback(AccepCallBack), null);

        }
        private static void AccepCallBack(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);

            IPEndPoint client = socket.RemoteEndPoint as IPEndPoint;

            Console.WriteLine("Client Connected" + client.Address +":" + client.Port);
            socket.BeginReceive(_buffer, 0,_buffer.Length, SocketFlags.None,new  AsyncCallback(ReceiveCallBack), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AccepCallBack), null);
        }

       private static void ReceiveCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);

            string text = Encoding.ASCII.GetString(dataBuf);
            Console.WriteLine("text received: " + text);
            string response = string.Empty;
            if (text.ToLower() == "get time")
            {
                response = Response.Dequeue();
            }
            else
            {
                response = "Invalid Request";
            }
            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);

        }
        
        private static void SendCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
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
                                    if (msg.Contains("FSDJump")||!msg.Contains("government_None"))
                                    {
                                        Response.Enqueue(msg);
                                        Debug.Print("Recieved one valid message");
                                    }
                                    
                                }
                            }
                        }
                        Thread.Sleep(100);
                    }
                }
            }
        }
        //private void ParseEDDNRawData(String RawData)
        //{
        //    try
        //    {
        //        EDDNRecievedArgs ArgsObject;

        //        if (RawData.Contains(@"ED-IBE"))
        //            Debug.Print("here");

        //        if (RawData.Contains(@"commodity/1"))
        //        {
        //            // new v2 schema
        //            Debug.Print("recieved v1 commodities message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data commodities message (v1)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Commodity_v1_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        if (RawData.Contains(@"commodity/2"))
        //        {
        //            // new v2 schema
        //            Debug.Print("recieved v2 commodities message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data commodities message (v2)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Commodity_v2_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        else if (RawData.Contains(@"commodity/3"))
        //        {
        //            // new v2 schema
        //            Debug.Print("recieved v3 commodities message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data commodities message (v3)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Commodity_v3_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };
        //        }
        //        else if (RawData.Contains(@"outfitting/1"))
        //        {
        //            // outfitting schema
        //            Debug.Print("recieved outfitting v1 message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data outfitting message (v1)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Outfitting_v1_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        else if (RawData.Contains(@"outfitting/2"))
        //        {
        //            // outfitting schema
        //            Debug.Print("recieved outfitting v2 message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data outfitting message (v2)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Outfitting_v2_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        else if (RawData.Contains(@"shipyard/1"))
        //        {
        //            // shipyardItem schema
        //            Debug.Print("recieved shipyard v1 message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data shipyard message (v1)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Shipyard_v1_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        else if (RawData.Contains(@"shipyard/2"))
        //        {
        //            // shipyardItem schema
        //            Debug.Print("recieved shipyard v2 message");

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved data shipyard message (v2)",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.Shipyard_v2_Recieved,
        //                RawData = RawData,
        //                Data = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(RawData),
        //                Adress = m_Adress
        //            };

        //        }
        //        else
        //        {
        //            // other unknown data

        //            ArgsObject = new EDDNRecievedArgs()
        //            {
        //                Message = "recieved unknown data message",
        //                InfoType = EDDNRecievedArgs.enMessageInfo.UnknownData,
        //                RawData = RawData,
        //                Data = null,
        //                Adress = m_Adress
        //            };
        //        }

        //        if (ArgsObject != null)
        //        {
        //            // only for one listener per time this is allowed
        //            lock (m_RecieveLocker)
        //            {
        //                DataRecieved(this, ArgsObject);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        DataRecieved(this, new EDDNRecievedArgs()
        //        {
        //            Message = "Error while parsing recieved EDDN data :" + Environment.NewLine + ex.GetBaseException().Message.ToString() + Environment.NewLine + ex.StackTrace,
        //            InfoType = EDDNRecievedArgs.enMessageInfo.ParseError,
        //            RawData = RawData,
        //            Data = null
        //        });
        //    }
        //}
    }
}
