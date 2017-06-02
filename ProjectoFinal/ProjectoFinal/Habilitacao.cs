using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Habilitacao
    {
        string descricao;
        int nivel; // Nivel Académico
        public Habilitacao()
        {

        }
        public Habilitacao(string Descr,int Nivel )
        {
            descricao = Descr;
            nivel = Nivel; 
        }
        public string Descr
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
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
        public override string ToString()
        {
            return nivel.ToString() + " - " + descricao;
        }
    }
}
