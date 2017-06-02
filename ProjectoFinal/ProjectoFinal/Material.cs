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
        public Material()
        {

        }
        public Material(string Partnumber, string Descr, string Supplier, double Price, bool isSoftware)
        {

            partnumber = Partnumber;
            name = Descr;
            supplier = Supplier;
            price = Price;
            issoftware = isSoftware;
 
        }
        public string Partnumber
        {
            get
            {
                return partnumber;
            }

            set
            {
                partnumber = value;
            }
        }

        public string Descr
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Supplier
        {
            get
            {
                return supplier;
            }

            set
            {
                supplier = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public bool Issoftware
        {
            get
            {
                return issoftware;
            }

            set
            {
                issoftware = value;
            }
        }
        public override string ToString()
        {
            return partnumber + " - " + name + " - " + price.ToString();
        }






    }
}
