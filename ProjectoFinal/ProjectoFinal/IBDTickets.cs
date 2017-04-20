﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    interface IBDTickets
    {
        bool InsereColaborador();
        Colaborador EliminaColaborador();
        bool InsereTecnico();
        Tecnico EliminaTecnico();
        bool InsereTicket();
        Ticket EliminaTicket();
        Perfil ProcuraPerfil(int nif);
        List<Perfil> ProcuraPerfis();
        List<Perfil> ProcuraPerfisTipo(int TIPO);
        Ticket ProcuraTicket(int numero);
        List<Ticket> ProcuraTicketsTecnico(int nif);
        List<Ticket> ProcuraTicketsTipo(int tipo);
        List<Ticket> ProcuraTicketsPorAssociar();
        List<Ticket> ProcuraTicketsEncomendaPendente();
        double CustoMediaTickets();
        double CustoTipoTickets(int tipo);
        double CustoTecnicoTickets(int tipo);
    }
}