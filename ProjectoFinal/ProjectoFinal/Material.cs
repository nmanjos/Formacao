using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Material
    {
        string partnumber;
        string name;
        string supplier;
        double price;
        bool issoftware;
        DateTime expires;
        public Material(string Partnumber, string Name, string Supplier, double Price, bool isSoftware, DateTime Expires)
        {
           
            partnumber = Partnumber;
            name = Name;
            supplier = Supplier;
            price = Price;
            issoftware = isSoftware;
            expires = Expires;
        }
        public string Partnumber { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public double Price { get; set; }
        public bool isSoftware { get; set; }
        public DateTime Expires { get; set; }

    }
}
