﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class SuporteEquipamento : Ticket
    {
        public SuporteEquipamento(int Num, DateTime Createate, DateTime Lastupdate, Colaborador Requester, int Priority, Equipamento Equipamento, string Description, List<Tecnico> Tecnicos, Status Estado, List<MaterialRequest> Encomendas, int Horas, string Resolution, Tecnico Quemfechou) : base(Num, Createate, Lastupdate, Requester, Priority, Equipamento, Description, Tecnicos, Estado, Encomendas, Horas, Resolution, Quemfechou)
        {
        }
    }
}
