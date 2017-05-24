using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class BDEscolar
    {
        private List<Aluno> alunos;

        public BDEscolar()
        {
            alunos = new List<Aluno>();
        }

        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma)
        {
            Aluno aluno = new AlunoInterno(matricula, nome, cc, dataNasc, curso, turma);
            alunos.Add(aluno);
        }

        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc)
        {
            Aluno aluno = new AlunoExterno(matricula, nome, cc, dataNasc);
            alunos.Add(aluno);
        }

        private Aluno GetAluno(int matricula)
        {
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Matricula == matricula)
                    return aluno;
            }
            return null;
        }

        public string AddMediaAno(int matricula, double valor)
        {
            string mensagem = "";

            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                if (aluno is AlunoInterno)
                {
                    AlunoInterno interno = (AlunoInterno)aluno;
                    bool addMedia = interno.AddMediaAno(valor);
                    if (addMedia)
                        mensagem = "Media inserida com sucesso!";
                    else
                        mensagem = "O aluno já concluiu o seu percurso escolar!";
                }
                else
                    mensagem = "Matrícula de um aluno externo.\nFuncionalidade exclusiva para alunos internos!";
            }
            else
                mensagem = "Matrícula inválida!";

            return mensagem;
        }

        public string AddDisciplina(int matricula, string nome, int code, double nota)
        {
            string mensagem = "";

            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                if (aluno is AlunoExterno)
                {
                    AlunoExterno externo = (AlunoExterno)aluno;
                    Disciplina disc = new Disciplina(nome, code, nota);
                    externo.AddDisciplina(disc);

                    mensagem = "Disciplina inserida com sucesso!";

                }
                else
                    mensagem = "Matrícula de um aluno interno.\nFuncionalidade exclusiva para alunos externos!";
            }
            else
                mensagem = "Matrícula inválida!";

            return mensagem;
        }

        public string VisualizaDados(int matricula)
        {
            string mensagem = "";

            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                mensagem = aluno.ToString();
            }
            else
                mensagem = "Matrícula inválida!";

            return mensagem;
        }

        public string VisualizaAvaliacoes(int matricula)
        {
            string mensagem = "";

            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                mensagem = aluno.Avaliacao();
            }
            else
                mensagem = "Matrícula inválida!";

            return mensagem;
        }
    }
}
