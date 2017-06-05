using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    interface IBDTickets
    {
        
        string GetError();
        bool Login(int NIF, string Pass);
        Perfil GetCurrentUser();
        bool InsereColaborador(Colaborador colab);
        Colaborador EliminaColaborador(int NIF);
        bool InsereTecnico(Tecnico Colab);
        Tecnico EliminaTecnico(int NIF);
        bool InsereTicket(Ticket TK);
        Ticket EliminaTicket(int Id);
        Perfil ProcuraPerfil(int nif);
        List<Perfil> ProcuraPerfis();
        List<Perfil> ProcuraPerfisTipo(bool is_Tecnico, bool is_Admin);
        Ticket ProcuraTicket(int Id);
        List<Ticket> ProcuraTicketsTecnico(int nif);
        List<Ticket> ProcuraTicketsPorEstadoTipo(string Estado, int tipo); // Implementação para não ter os estados e tipos HardCoded 
                                                                           //se algums dos parametros for 0 são mostrados todos os tickets para esse parametro
        List<Ticket> ProcuraTicketsPorAssociar(); // Esta Função deve ser abandonada em novos Interfaces Gráficos em favor da ProcuraTicketsPorEstadoTipo, estado Por Associar hardcoded com ID 2
        List<Ticket> ProcuraTicketsEncomendaPendente(); // Estado de Encomenda Pendente Harcoded na base de dados com ID 1
        Status ProcuraEstado(string Estado);
        List<Status> ProcuraEstados(bool is_Ticket, bool is_request); // Devolve uma Lista de Estados por tipo(estado de ticket ou estado de Encomenda)
        bool InsereEstado(Status Estado);
        Status EliminaEstado(string Estado);
        bool InsereEquipamento(Equipamento Equip);
        List<Equipamento> ProcuraEquipamentos();
        Equipamento ProcuraEquipamento(string InventCode);
        Equipamento EliminaEquipamento(string InventCode);
        bool InsereArea(Area Area);
        Area ProcuraArea(string name);
        List<Area> ProcuraAreas(int NIF);
        List<Area> ProcuraAreas();
        Area EliminaArea(String Area);
        bool InsereHabilitacao(Habilitacao Habilitacao);
        Habilitacao ProcuraHabilitacao(string Descr);
        List<Habilitacao> ProcuraHabilitacoes();
        Habilitacao EliminaHabilitacao(string Descricao);
        bool InsereMaterial(Material Material);
        List<Material> ProcuraPecas(int InventCode); //procura peças de um equipamento
        Material ProcuraMaterial(string partnumber);
        List<Material> ProcuraMaterial();
        Prioridade EliminaPrioridade(String Prioridade);
        bool InserePrioridade(Prioridade Prioridade);
        List<Prioridade> ProcuraPrioridade();
        Material EliminaMaterial(string partnumber);
        double CustoMediaTickets();  // Media do Custo dos tickets fechados 
        double CustoMediaTipoTickets(int tipo); //  Media do Custo dos Tickets Fechados por Tecnico
        double CustoMedioTecnicoTickets(int nif); // Media do Custo dos Tickets Fechados por Tecnico
        
    }
}
