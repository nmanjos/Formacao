using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class MaterialRequest
    {
        private int reqcode;
        private string description;
        private double price;
        private Tecnico requester;
        private Material materiais;
        private Status estado;

        public MaterialRequest(int Reqcode, double Price, Tecnico Requester, Material Materiais, Status Estado)
        {
            this.reqcode = Reqcode;
            this.price = Price;
            requester = Requester;
            this.materiais = Materiais;
            estado = Estado;
        }

        public int Reqcode
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

        internal Tecnico Requester
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

        internal Material Materiais
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
