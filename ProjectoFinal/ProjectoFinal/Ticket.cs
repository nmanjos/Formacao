using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Ticket
    {
        private int num;   //Número do Ticket
        private DateTime createdate;   //Data e hora do pedido;
        private DateTime lastupdate;   // data do ultimo update
        private Colaborador requester;     //Colaborador que criou o Ticket
        private int priority;//Nível de Urgência
        private Equipamento equipamento;   //Elemento que gerou a anomalia
        private string description;    //Descrição da anomalia
        private List<Tecnico> tecnicos;   //Técnico ou técnicos associados
        private Status estado;   //Estado (Por associar, Aguarda Validação Técnico, Em Análise, Resolvido, Rejeitado)
        private List<MaterialRequest> requesicoes;  //Registo de eventuais pedidos de material com custo associado
        private int horas;  //Horas gastas
        private Tecnico quemfechou;
        public Ticket(int Num, DateTime CreateDate, DateTime LastUpdate, Colaborador Requester, int Priority, Equipamento Equipamento, string Description, List<Tecnico> Tecnicos, Status Estado, List<MaterialRequest> Requesicoes, int Horas, Tecnico QuemFechou)
        {
            this.num = Num;
            this.createdate = CreateDate;
            this.lastupdate = LastUpdate;
            this.requester = Requester;
            this.priority = Priority;
            this.equipamento = Equipamento;
            this.description = Description;
            this.tecnicos = Tecnicos;
            this.estado = Estado;
            this.requesicoes = Requesicoes;
            this.horas = Horas;
            this.quemfechou = QuemFechou;
        }
        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }
        public DateTime Createdate
        {
            get
            {
                return createdate;
            }

            set
            {
                createdate = value;
            }
        }
        public DateTime Lastupdate
        {
            get
            {
                return lastupdate;
            }

            set
            {
                lastupdate = value;
            }
        }
        public Colaborador Requester
        {
            get
            {
                return requester;
            }

            set
            {
                requester = value;
            }
        }
        public int Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public Equipamento Equipamento
        {
            get
            {
                return equipamento;
            }

            set
            {
                equipamento = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        public List<Tecnico> Tecnicos
        {
            get
            {
                return tecnicos;
            }

            set
            {
                tecnicos = value;
            }
        }

        public Status Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public List<MaterialRequest> Requesicoes
        {
            get
            {
                return requesicoes;
            }

            set
            {
                requesicoes = value;
            }
        }

        public int Horas
        {
            get
            {
                return horas;
            }

            set
            {
                horas = value;
            }
        }

        public Tecnico Quemfechou
        {
            get
            {
                return quemfechou;
            }

            set
            {
                quemfechou = value;
            }
        }

        
    }
}
