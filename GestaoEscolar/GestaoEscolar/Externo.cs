using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class Externo : Aluno
    {
        List<Disciplina> disciplinas;
        public Externo(int matricula, string nome, int cc, DateTime dataNasc) : base(matricula, nome, cc, dataNasc)
        {
            disciplinas = new List<Disciplina>(); // Cria lista de disciplinas 
        }
        public void AddDisciplina(Disciplina disc)
        {
            disciplinas.Add(disc);
        }
        public bool AddNota(int codeDisc, double valor)
        {
            foreach (Disciplina disc in disciplinas)
            {
                if (disc.Code==codeDisc) // valida se o Externo está matriculado na disciplina
                {
                    disc.Nota = valor;
                    return true;
                }
            }
            return false; // Externo não está matriculado nesta disciplina
        }
        public override string Avaliacao()
        {
            throw new NotImplementedException();
        }
    }
}
