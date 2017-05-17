using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    interface IBDEscolar
    {
        void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma);

        void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc);

        string AddMediaAno(int matricula, double valor);

        string AddDisciplina(int matricula, string nome, int code, double nota);

        string VisualizaDados(int matricula);

        string VisualizaAvaliacoes(int matricula);
    }
}
