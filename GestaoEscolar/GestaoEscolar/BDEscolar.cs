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
        /// <summary>
        /// CriarAluno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma)
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="nome"></param>
        /// <param name="cc"></param>
        /// <param name="dataNasc"></param>
        /// <param name="curso"></param>
        /// <param name="turma"></param>
        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma)
        {
            Interno aluno = new Interno(matricula, nome, cc, dataNasc, curso, turma);
            alunos.Add(aluno);
        }
        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc)
        {
            Externo aluno = new Externo(matricula, nome, cc, dataNasc);
            alunos.Add(aluno);
        }
        private Aluno GetAluno(int matricula)
        {
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Matricula == matricula)
                {
                    return aluno;
                }
            }
           
            return null;
        }
        public string AddMediaAno(double valor, int matricula)
        {
            string mensagem = "";
            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                if(aluno is Interno)
                {
                    Interno interno = (Interno)aluno;
                    if (interno.AddMediaAno(valor))
                    {
                        mensagem = "Media inserida com sucesso";

                    }
                    else
                    {
                        mensagem = "O Aluno já concluiu o percurso curricular";
                    }
                }
                else
                {
                    mensagem = "Matricula de Aluno Externo, esta funcionalidade (Gravar Media do Ano), Só está disponivel para alunos internos";
                }
            }
            else
            {
                mensagem = "Matricula Inválida !?!?!?!?!?!?!";
            }
            return mensagem;
        }
        public string AddDisciplina(double nota, int code,string nome,int matricula)
        {
            string mensagem = "";
            Aluno aluno = GetAluno(matricula);
            if (aluno != null)
            {
                if (aluno is Externo)
                {
                    Externo externo = (Externo)aluno;
                    Disciplina disc = new Disciplina(nome, code, nota);
                    externo.AddDisciplina(disc);
                    mensagem = "Disciplina Gravada";
                }
                else
                {
                    mensagem = "Matricula de Aluno Interno, esta funcionalidade (Gravar Disciplina), Só está disponivel para alunos internos";
                }
            }
            else
            {
                mensagem = "Matricula Inválida !?!?!?!?!?!?!";
            }
            return mensagem;
        }
    }
}
