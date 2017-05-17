using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class AlunoInterno:Aluno
    {
        private string curso;
        private string turma;
        private List<int> mediasNotasAnual;

        public AlunoInterno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma)
            :base(matricula, nome, cc, dataNasc)
        {
            this.curso = curso;
            this.turma = turma;
            mediasNotasAnual = new List<int>();
        }

        public bool AddMediaAno(double valor)
        {
            if(mediasNotasAnual.Count<3)
            {
                //double round = Math.Round(valor, 0);
                //int intRound = (int)round;
                //mediasNotasAnual.Add(intRound);

                mediasNotasAnual.Add((int)Math.Round(valor,0));
                return true;
            }
            return false;
        }

        public override string Avaliacao()
        {
            string avaliacao = "Avaliação do aluno " + nome + "\n";
            int ano = 10;
            double mediaFinal = 0;

            foreach (int media in mediasNotasAnual)
            {
                avaliacao += ano + "º - " + media + " valores\n";
                mediaFinal += media;
                ano++;
            }
            if(ano > 10)
                mediaFinal /= (ano - 10);

            //mediaFinal = mediaFinal / (ano - 10);
            avaliacao += "Media Final - " + mediaFinal + " valores\n";
            return avaliacao;
        }

        public override string ToString()
        {
            string tostring = base.ToString();
            tostring += "Curso: " + curso + "\n";
            tostring += "Turma: " + turma + "\n";
            return tostring;
        }
    }
}
