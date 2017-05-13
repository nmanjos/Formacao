using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eddn_listener_test
{
    public class Header
    {
        public string softwareVersion { get; set; }
        public string gatewayTimestamp { get; set; }
        public string softwareName { get; set; }
        public string uploaderID { get; set; }
    }

    public class Faction
    {
        public string Allegiance { get; set; }
        public string FactionState { get; set; }
        public double Influence { get; set; }
        public string Name { get; set; }
        public string Government { get; set; }

        public override string ToString()
        {
            
            return Allegiance + " - " + FactionState + " - " + Influence.ToString() + " - " + Name + " - " + Government; ;
        }
    }

    public class Message
    {
        public string StarSystem { get; set; }
        public string SystemFaction { get; set; }
        public string timestamp { get; set; }
        public string SystemSecurity { get; set; }
        public string SystemAllegiance { get; set; }
        public string PowerplayState { get; set; }
        public string SystemEconomy { get; set; }
        public List<double> StarPos { get; set; }
        public List<Faction> Factions { get; set; }
        public List<string> Powers { get; set; }
        public string @event { get; set; }
        public string SystemGovernment { get; set; }
    }

    public class EDDNStream
    {
        public Header header { get; set; }
        public string schemaRef { get; set; }
        public Message message { get; set; }
    }
}

