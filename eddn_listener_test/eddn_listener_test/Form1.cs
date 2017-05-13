using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using eddn_listener_test;


namespace eddn_listener_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            while (Program.m_Active)
            {
                noCycles.Text = (Convert.ToInt32(noCycles.Text) + 1).ToString();
                Toprocess.Text = Program.Response.Count.ToString();
                if (Program.Response.Count() > 0)
                {
                    EDDNStream Data = Program.Response.Dequeue();
                    string str = "";
                    str += "Star System: " + Data.message.StarSystem + "\n";
                    str += "time stamp: " + Data.message.timestamp + "\n";
                    str += "System Government: " + Data.message.SystemGovernment + "\n";
                    str += "Controlin Faction: " + Data.message.SystemFaction + "\n\n";
                    
                    if (!(Data.message.Factions == null))
                    {
                        foreach (Faction faction in Data.message.Factions)
                        {
                            
                            str += "Faction :" + faction.Name + "\n";
                            str += String.Format("Influence: {0:P2}.", faction.Influence) + "\n";
                            str += "State :" + faction.FactionState + "\n\n";
                        }
                        
                    }
                    else
                    {
                        str += "No Factions";
                    }


                    richTextBox1.Text = str;
                    Application.DoEvents();
                    Thread.Sleep(150);
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
