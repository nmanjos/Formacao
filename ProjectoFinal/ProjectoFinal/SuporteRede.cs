using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class SuporteRede : Ticket
    {
        public SuporteRede(int Num, DateTime CreateDate, DateTime LastUpdate, Colaborador Requester, int Priority, Equipamento Equipamento, string Description, List<Tecnico> Tecnicos, TicketStatus Estado, List<MaterialRequest> Requesicoes, int Horas, Tecnico QuemFechou) : base(Num, CreateDate, LastUpdate, Requester, Priority, Equipamento, Description, Tecnicos, Estado, Requesicoes, Horas, QuemFechou)
        {
        }
    }
}
