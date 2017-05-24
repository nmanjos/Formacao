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

        public MaterialRequest(int reqcode, string description, double price, Tecnico requester, Material materiais, Status estado)
        {
            this.reqcode = reqcode;
            this.description = description;
            this.price = price;
            this.requester = requester;
            this.materiais = materiais;
            this.estado = estado;
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
                return requester;
            }

            set
            {
                requester = value;
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
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
