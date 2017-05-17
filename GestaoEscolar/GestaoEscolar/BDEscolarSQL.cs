using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class BDEscolarSQL:IBDEscolar
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public BDEscolarSQL()
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\AlunosBD.mdf;Integrated Security = True");
        }

        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc, string curso, string turma)
        {
            CriarAluno(matricula, nome, cc, dataNasc);
            cn.Open();
            cmd = new SqlCommand("insert into AlunosInternos(matricula,curso,turma,media10,media11,media12) values(@matricula, @curso, @turma, @media10, @media11, @media12);", cn);
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@curso", curso);
            cmd.Parameters.AddWithValue("@turma", turma);
            cmd.Parameters.AddWithValue("@media10", 0);
            cmd.Parameters.AddWithValue("@media11", 0);
            cmd.Parameters.AddWithValue("@media12", 0);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void CriarAluno(int matricula, string nome, int cc, DateTime dataNasc)
        {
            cn.Open();
            cmd= new SqlCommand("insert into Alunos(matricula,nome,cc,datanasc) values(@matricula, @nome, @cc, @datanasc);",cn);
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@datanasc", dataNasc);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public string AddMediaAno(int matricula, double valor)
        {
            throw new NotImplementedException();
        }

        public string AddDisciplina(int matricula, string nome, int code, double nota)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private Aluno GetAluno(int matricula)
        {
            //Aluno que será devolvido
            Aluno aluno = null;

            //Conexão à BD
            cn.Open();
            //Select que une as tabelas Alunos e AlunosInternos de modo a juntar todos os alunos da BD
            cmd = new SqlCommand("select * from Alunos left join AlunosInternos on Alunos.matricula = AlunosInternos.matricula where Alunos.matricula = @matricula;", cn);
            //Associa ao parâmetro @matricula a variável matricula
            cmd.Parameters.AddWithValue("@matricula", matricula);
            //Executa a consulta e a referência dr passa a conter os resultados da consulta
            dr = cmd.ExecuteReader();
            //Se resultarem linhas da consulta
            if (dr.HasRows)
            {
                //Ciclo para ler todas as linhas resultantes da consulta 
                while (dr.Read())
                {
                    //campos comuns a todos os alunos
                    int mat = int.Parse(dr["matricula"].ToString());
                    string nome = dr["nome"].ToString();
                    int cc = int.Parse(dr["cc"].ToString());
                    DateTime dataNasc = Convert.ToDateTime(dr["datanasc"].ToString());
                    //Se o campo curso estiver vazio indica que temos um externo
                    if (dr["curso"].ToString() == "")
                    {
                        /*
                         * Instanciação do AlunoExterno usando a informação recolhida 
                         * e associação do objeto à referência aluno que será retornada
                         */
                        aluno = new AlunoExterno(matricula, nome, cc, dataNasc);
                    }
                    else //caso contrário um Interno
                    {
                        //Campos do interno
                        string curso = dr["curso"].ToString();
                        string turma = dr["turma"].ToString();
                        int media10 = int.Parse(dr["media10"].ToString());
                        int media11 = int.Parse(dr["media11"].ToString());
                        int media12 = int.Parse(dr["media12"].ToString());

                        /*
                         * Instanciação do AlunoInterno usando a informação recolhida
                         * e associação do objeto a uma nova referência de AlunosInternos
                         * com o intuito de invocar o método AddMediaAno que é exclusivo à classe
                         */
                        AlunoInterno alunoi = new AlunoInterno(matricula, nome, cc, dataNasc, curso, turma);

                        //Verifica se o aluno tem alguma das 3 médias 
                        if (media10 > 0)
                        {
                            //adiciona a media encontrada ao objeto
                            alunoi.AddMediaAno(media10);
                            if (media11 > 0)
                            {
                                alunoi.AddMediaAno(media11);
                                if (media12 > 0)
                                    alunoi.AddMediaAno(media12);
                            }
                        }
                        //Associação do objeto à referência aluno que será retornada
                        aluno = alunoi;
                    }
                }
            }
            //Fechar conexões 
            dr.Close();
            cn.Close();
            //Devolve o aluno encontrado ou null
            return aluno;
        }
    }
}
