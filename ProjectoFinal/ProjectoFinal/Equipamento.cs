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
        public Equipamento(string PartNumber, string ModelNum, string InventCode, string Description, List<Material> Pecas, string Localizacao, Perfil Empregado, double Price)
        {
            PartNumber = partnumber;
            ModelNum = modelnum;
            InventCode = inventcode;
            Description = description;
            Pecas = pecas;
            Localizacao = localizacao;
            Empregado = empregado;
            Price = price;
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

        public string Description
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
