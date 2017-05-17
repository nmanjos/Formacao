using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    

    class TicketStatus
    {
        int status_id = 0;
        string status = "";
        bool is_final = false;
        bool is_rejected = false;

        public TicketStatus(int Status_id, string Status, bool Is_final, bool Is_rejected)
        {
            this.status_id = Status_id;
            this.status = Status;
            this.is_final = Is_final;
            this.is_rejected = Is_rejected;
        }

        public int Status_id
        {
            get
            {
                return status_id;
            }

            set
            {
                status_id = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
    }
}
