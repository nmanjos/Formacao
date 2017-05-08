using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class BDTickets : IBDTickets
    {
        public double CustoMediaTickets()
        {
            throw new NotImplementedException();
        }

        public double CustoTecnicoTickets(int tipo)
        {
            throw new NotImplementedException();
        }

        public double CustoTipoTickets(int tipo)
        {
            throw new NotImplementedException();
        }

        public Colaborador EliminaColaborador()
        {
            throw new NotImplementedException();
        }

        public Colaborador EliminaColaborador(int nif)
        {
            throw new NotImplementedException();
        }

        public Tecnico EliminaTecnico()
        {
            throw new NotImplementedException();
        }

        public Ticket EliminaTicket()
        {
            throw new NotImplementedException();
        }

        public bool InsereColaborador()
        {
            throw new NotImplementedException();
        }

        public bool InsereTecnico()
        {
            throw new NotImplementedException();
        }

        public bool InsereTicket()
        {
            throw new NotImplementedException();
        }

        public bool InsereTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Perfil ProcuraPerfil(int nif)
        {
            throw new NotImplementedException();
        }

        public List<Perfil> ProcuraPerfis()
        {
            throw new NotImplementedException();
        }

        public List<Perfil> ProcuraPerfisTipo(int TIPO)
        {
            throw new NotImplementedException();
        }

        public Ticket ProcuraTicket(int numero)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsEncomendaPendente()
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsPorAssociar()
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsTecnico(int nif)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
