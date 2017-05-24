using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5118
{
    class BDComputadores
    {
        private List<Computador> computadores;
        public BDComputadores()
        {
            computadores = Computadores;
        }
        public List<Computador> Computadores=new List<Computador>();
 
        /// <summary>
        /// Adiciona um objeto NoteBook à lista 
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="Marca"></param>
        /// <param name="Modelo"></param>
        /// <param name="Motherboard"></param>
        /// <param name="ScreenSize"></param>
        public void AddComputador(string Serial, string Marca, string Modelo, string Motherboard, double ScreenSize)
        {
            NoteBook Computas = new NoteBook(Serial, Marca, Modelo, Motherboard, ScreenSize);
            Computadores.Add(Computas);
        }
        /// <summary>
        /// Adiciona um objeto Desktop à lista
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="Marca"></param>
        /// <param name="Modelo"></param>
        /// <param name="Motherboard"></param>
        /// <param name="Processador"></param>
        /// <param name="PSUWATT"></param>
        public void AddComputador(string Serial, string Marca, string Modelo, string Motherboard, string Processador, int PSUWATT)
        {
            Desktop Computas = new Desktop( Serial,Marca,  Modelo,  Motherboard,  Processador,  PSUWATT);
            Computadores.Add(Computas);
        }
        /// <summary>
        /// Calcula o custo de reparação de um determinado computador segundo o nº de horas e o valor das peças utilizadas.
        /// </summary>
        /// <param name="nserie"></param>
        /// <param name="horas"></param>
        /// <param name="valorPecas"></param>
        /// <returns>String</returns>
        public string CalculaCustoReparacao(int nserie, double horas, double valorPecas)
        {
            foreach (Computador computas in Computadores)
            {
                if (nserie.ToString() == computas.Serial)
                {
                    return computas.CustoReparacao(horas, valorPecas).ToString()+ "\n";
                }
            }
            return "\n";
        }

    }

}
