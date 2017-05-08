using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Ticket
    {
        int num;   //Número do Ticket
        DateTime recdate;   //Data e hora do pedido;
        Colaborador requester;     //Colaborador que criou o Ticket
        int priority;//Nível de Urgência
                     //Elemento que gerou a anomalia
        string description;    //Descrição da anomalia
        List<Tecnico> tecnicos;   //Técnico ou técnicos associados
        string Estado;   //Estado (Por associar, Aguarda Validação Técnico, Em Análise, Resolvido)
        List<MaterialRequest> requesicoes;
        //Registo de eventuais pedidos de material com custo associado
        int horas;
        //Horas gastas
    }
}
