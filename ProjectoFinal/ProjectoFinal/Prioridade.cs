using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Prioridade

    {
        int nivel; // 1 maxima ... 99 minima
        string smallname; // nome breve da prioridade na base de dados terá 15 caracteres
        string Descr; //  Descricao mais detalhada

        public Prioridade(int nivel, string smallname, string descr)
        {
            this.nivel = nivel;
            this.smallname = smallname;
            Descr = descr;
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public string Smallname
        {
            get
            {
                return smallname;
            }

            set
            {
                smallname = value;
            }
        }

        public string Descr1
        {
            get
            {
                return Descr;
            }

            set
            {
                Descr = value;
            }
        }
    }
}
