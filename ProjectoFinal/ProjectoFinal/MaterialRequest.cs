using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class MaterialRequest
    {
        private string reqcode;
        private double price;
        private Perfil requester;
        private List<Material> materiais;
        private Status estado;

        public MaterialRequest(string Reqcode, double Price, Perfil Requester, List<Material> Materiais, Status Estado)
        {
            this.reqcode = Reqcode;
            this.price = Price;
            requester = Requester;
            this.materiais = Materiais;
            estado = Estado;
        }

        public string Reqcode
        {
            get
            {
                return reqcode;
            }

            set
            {
                reqcode = value;
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

        internal Perfil Requester
        {
            get
            {
                return Requester;
            }

            set
            {
                Requester = value;
            }
        }

        internal List<Material> Materiais
        {
            get
            {
                return materiais;
            }

            set
            {
                materiais = value;
            }
        }

        internal Status Estado
        {
            get
            {
                return Estado;
            }

            set
            {
                Estado = value;
            }
        }
    }
}
