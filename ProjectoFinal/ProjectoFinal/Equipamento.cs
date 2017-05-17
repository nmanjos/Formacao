using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Equipamento
    {
        string partnumber;
        string modelnum;
        string inventcode;
        string description;
        List<Material> pecas;
        string localizacao;
        Perfil empregado;
        double price;
        public Equipamento(string InventCode,string PartNumber, string ModelNum,  string Descr, List<Material> Pecas, string Localizacao, Perfil Empregado, double Price)
        {
            partnumber = PartNumber;
            modelnum = ModelNum;
            inventcode = InventCode;
            description = Descr;
            pecas = Pecas;
            localizacao = Localizacao;
            empregado = Empregado;
            price = Price;
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

        public string Modelnum
        {
            get
            {
                return modelnum;
            }

            set
            {
                modelnum = value;
            }
        }

        public string Inventcode
        {
            get
            {
                return inventcode;
            }

            set
            {
                inventcode = value;
            }
        }

        public string Descr
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        internal List<Material> Pecas
        {
            get
            {
                return pecas;
            }

            set
            {
                pecas = value;
            }
        }

        public string Localizacao
        {
            get
            {
                return localizacao;
            }

            set
            {
                localizacao = value;
            }
        }

        internal Perfil Empregado
        {
            get
            {
                return empregado;
            }

            set
            {
                empregado = value;
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

        



    }
}
