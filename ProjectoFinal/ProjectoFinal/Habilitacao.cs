using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Habilitacao
    {
        int nivel;
        string descricao;
        public Habilitacao(int Nivel, string Descricao)
        {
            descricao = Descricao;
            nivel = Nivel;
        }
        public string Descricao
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
    }
}
