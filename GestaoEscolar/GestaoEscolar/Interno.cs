using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class Interno : Aluno
    {
        private string curso;
        private string turma;
        private List<int> mediasnotasanual;
        public Interno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma) : base(matricula, nome, cc, dataNasc)
        {
            this.curso = curso;
            this.turma = turma;
            mediasnotasanual = new List<int>();

        }

        public override string Avaliacao()
        {

            throw new NotImplementedException();
        }
        public bool AddMediaAno( double valor)
        {
            if (mediasnotasanual.Count < 3)
            {
                mediasnotasanual.Add((int)Math.Round(valor, 0));
                return true;
            }
            return false; // Externo não está matriculado nesta disciplina
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
