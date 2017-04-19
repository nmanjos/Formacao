using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Patrao:Empregado
    {
        private int naccoes;
        public Patrao(string NomeDoPatrao,int IdadeDoPatrao,int nAccoes)
            :base(NomeDoPatrao,IdadeDoPatrao)
        {
            naccoes = nAccoes;
        }

        public override string MostraFuncao()
        {
            return base.MostraFuncao() + " - " + "Patrão";
        }
        public int MostraAccoes()
        {
            return naccoes;
        }
    }
}
