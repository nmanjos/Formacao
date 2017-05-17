using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class AlunoExterno:Aluno
    {
        private List<Disciplina> disciplinas;

        public AlunoExterno(int matricula, string nome, int cc, DateTime dataNasc)
            : base(matricula, nome, cc, dataNasc)
        {
            disciplinas = new List<Disciplina>();
        }

        public void AddDisciplina(Disciplina disc)
        {
            disciplinas.Add(disc);
        }
        public bool AddNota(int codeDisc, double valor)
        {
            foreach (Disciplina disc in disciplinas)
            {
                if (disc.Code == codeDisc)
                {
                    disc.Nota = valor;
                    return true;
                }
            }
            return false;
        }

        public override string Avaliacao()
        {
            string avaliacao = "Avaliação do aluno " + nome + "\n";
            
            double mediaFinal = 0;

            foreach (Disciplina disc in disciplinas)
            {
                avaliacao += disc.Nome + " - " + disc.Nota + " valores\n";
                mediaFinal += disc.Nota;
            }
            int count = disciplinas.Count;
            if (count > 0)
                mediaFinal /= count;
            
            avaliacao += "Media Final - " + mediaFinal + " valores\n";
            return avaliacao;
        }

        public override string ToString()
        {
            string tostring = base.ToString();
            tostring += "Nº de Disciplinas inscritas: " + disciplinas.Count + "\n";
            return tostring;
        }
    }
}
