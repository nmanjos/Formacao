using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5118
{
    public class NoteBook : Computador
    {
        private double screensize;

        public NoteBook(string Serial, string Marca, string Modelo, string Motherboard, double ScreenSize) : base(Serial, Marca, Modelo, Motherboard)
        {
            screensize = ScreenSize;
        }
        public double ScreenSize
        {
            get
            {
                return screensize;
            }
            set
            {
                screensize = value;
            }
        }
        public override double CustoReparacao(double horas, double valorPecas)
        {
            double Custodeabertura = 25;
            double CustoHora = 15;
            double CustoFinal = (CustoHora * horas) + Custodeabertura + valorPecas;
            return CustoFinal;
        }
    }
}
