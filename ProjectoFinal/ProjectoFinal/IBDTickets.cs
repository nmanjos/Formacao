using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    interface IBDTickets
    {
        bool Login();
        
        Perfil GetCurrentUser();
        bool InsereColaborador(Colaborador colab);
        Colaborador EliminaColaborador(int NIF);
        bool InsereTecnico(Tecnico Colab);
        Tecnico EliminaTecnico(int NIF);
        bool InsereTicket(int Id);
        Ticket EliminaTicket(int Id);
        Perfil ProcuraPerfil(int nif);
        List<Perfil> ProcuraPerfis();
        List<Perfil> ProcuraPerfisTipo(bool is_Tecnico, bool is_Admin);
        Ticket ProcuraTicket(int Id);
        List<Ticket> ProcuraTicketsTecnico(int nif);
        List<Ticket> ProcuraTicketsTipo(int tipo);
        List<Ticket> ProcuraTicketsPorEstado(String Estado); // Implementação para não ter os estados HardCoded
        List<Ticket> ProcuraTicketsPorAssociar(); // Esta Função deve ser abandonada em novos Interfaces Gráficos em favor da ProcuraTicketsPorEstado, estado Por Associar hardcoded com ID 2
        List<Ticket> ProcuraTicketsEncomendaPendente(); // Estado de Encomenda Pendente Harcoded na base de dados com ID 1
        List<Status> CarregaEstados(bool is_Ticket, bool is_request); // Devolve uma Lista de Estados por tipo(estado de ticket ou estado de Encomenda)
        bool InsereEstado(Status Estado);
        Status EliminaEstado(string Estado);
        bool InsereEquipamento(Equipamento Equip);
        List<Equipamento> ProcuraEquipamentos();
        Equipamento ProcuraEquipamento(string InventCode);
        Equipamento EliminaEquipamento(string InventCode);
        bool InsereArea(Area Area);
        List<Area> ProcuraAreas();
        Area EliminaArea(String Area);
        bool InsereHabilitacao(Habilitacao Habilitacao);
        List<Habilitacao> ProcuraHabilitacoes();
        Area EliminaHabilitacao(String Habilitacao);
        bool InsereMaterial(Material Material);
        List<Material> ProcuraMaterial();
        Area EliminaMaterial(String Material);
        double CustoMediaTickets();  // Media do Custo dos tickets fechados 
        double CustoMediaTipoTickets(int tipo); //  Media do Custo dos Tickets Fechados por Tecnico
        double CustoMedioTecnicoTickets(int nif); // Media do Custo dos Tickets Fechados por Tecnico
    }
}
