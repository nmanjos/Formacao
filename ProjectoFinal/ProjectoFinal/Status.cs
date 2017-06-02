using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    

    class Status
    {
        
        string descr = "";
        bool is_final = false;
        bool is_rejected = false;
        bool is_ticket = true;
        bool is_request = false;
        public Status()
        {

        }
        public Status(string Descr, bool Is_final, bool Is_rejected, bool Is_ticket, bool Is_request)
        {
            this.descr = Descr;
            this.is_final = Is_final;
            this.is_rejected = Is_rejected;
            this.is_ticket = Is_ticket;
            this.is_request = Is_request;
        }

        public string Descr
        {
            get
            {
                return descr;
            }

            set
            {
                descr = value;
            }
        }

        public bool Is_final
        {
            get
            {
                return is_final;
            }

            set
            {
                is_final = value;
            }
        }

        public bool Is_rejected
        {
            get
            {
                return is_rejected;
            }

            set
            {
                is_rejected = value;
            }
        }

        public bool Is_ticket
        {
            get
            {
                return is_ticket;
            }

            set
            {
                is_ticket = value;
            }
        }

        public bool Is_request
        {
            get
            {
                return is_request;
            }

            set
            {
                is_request = value;
            }
        }
    }
}
