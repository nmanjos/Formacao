using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Area
    {
        string descricao;
        Habilitacao nivelminimo;

        public Area(string Descricao, Habilitacao NivelMinimo)
        {
            descricao = Descricao;
            nivelminimo = NivelMinimo;
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
            
        public Habilitacao NivelMinimo
        {
            get
            {
                return nivelminimo;
            }
            set
            {
                nivelminimo = value;
            }
        }
        public override string ToString()
        {
            return descricao;
        }
    }
}
