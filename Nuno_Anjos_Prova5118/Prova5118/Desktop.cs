using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5118
{
    public class Desktop : Computador
    {
        private int psuwatt;

        public Desktop(string Serial, string Marca, string Modelo, string Motherboard, string Processador, int PSUWATT) : base(Serial, Marca, Modelo, Motherboard, Processador)
        {
            psuwatt = PSUWATT;
        }
        public int PSUWATT
        {
            get
            {
                return psuwatt;
            }
            set
            {
                psuwatt = value;
            }
        }
        public override double CustoReparacao(double horas, double valorPecas)
        {
            return (10 * horas) + 15 + valorPecas;
        }
    }
}
