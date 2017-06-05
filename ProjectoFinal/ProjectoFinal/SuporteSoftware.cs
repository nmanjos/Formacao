using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class SuporteSoftware : Ticket
    {
        public SuporteSoftware(int Num, DateTime Createdate, DateTime Lastupdate, Colaborador Requester, Area Areaintre, Prioridade priority, Equipamento Equipamento, string Description, List<Tecnico> Tecnicos, Status Estado, List<MaterialRequest> Encomendas, int Horas, string Resolution, Tecnico Quemfechou) : base(Num, Createdate, Lastupdate, Requester, Areaintre, priority, Equipamento, Description, Tecnicos, Estado, Encomendas, Horas, Resolution, Quemfechou)
        {
        }
    }
}
