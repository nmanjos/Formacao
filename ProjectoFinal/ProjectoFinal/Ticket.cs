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
        private Area areaintre; //Area de Intrevencao, Define o tipo de Intreveção a ser realizado, só pode ser alterada na criacao do registo e pelo Administrador atravez do processo de atribuição.
        private int priority;//Nível de Urgência
        private Equipamento equipamento;   //Elemento que gerou a anomalia
        private string description;    //Descrição da anomalia
        private List<Tecnico> tecnicos;   //Técnico ou técnicos associados
        private Status estado;   //Estado (Por associar, Aguarda Validação Técnico, Em Análise, Resolvido, Rejeitado)
        private List<MaterialRequest> encomendas;  //Registo de eventuais pedidos de material com custo associado
        private int horas;  //Horas gastas
        private string resolution;
        private Tecnico quemfechou;

        public Ticket(int Num, DateTime Createate, DateTime Lastupdate, Colaborador Requester, int Priority, Equipamento Equipamento, string Description, List<Tecnico> Tecnicos, Status Estado, List<MaterialRequest> Encomendas, int Horas, string Resolution, Tecnico Quemfechou)
        {
            this.num = Num;
            this.createdate = Createate;
            this.lastupdate = Lastupdate;
            this.requester = Requester;
            this.priority = Priority;
            this.equipamento = Equipamento;
            this.description = Description;
            this.tecnicos = Tecnicos;
            this.estado = Estado;
            this.encomendas = Encomendas;
            this.horas = Horas;
            this.resolution = Resolution;
            this.quemfechou = Quemfechou;
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

        internal Colaborador Requester
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

        internal Equipamento Equipamento
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

        internal List<Tecnico> Tecnicos
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

        internal Status Estado
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

        internal List<MaterialRequest> Encomendas
        {
            get
            {
                return encomendas;
            }

            set
            {
                encomendas = value;
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

        public string Resolution
        {
            get
            {
                return resolution;
            }

            set
            {
                resolution = value;
            }
        }

        internal Tecnico Quemfechou
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
