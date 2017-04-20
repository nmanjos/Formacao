using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    abstract class Aluno
    {
        protected int matricula;
        protected string nome;
        protected int cc;
        protected DateTime dataNasc;
        
        public Aluno(int matricula, string nome, int cc, DateTime dataNasc)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cc = cc;
            this.dataNasc = dataNasc;
        }
        
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public string  Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public int CC
        {
            get
            {
                return cc;
            }
            set
            {
                cc = value;
            }
        }
        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }
            set
            {
                dataNasc = value;
            }
        }
        public int Idade
        {
            get
            {
                
                return DateTime.Today.Year - dataNasc.Year;
            }
        }
        public abstract string Avaliacao();

        public override string ToString()
        {
            string tostring = "Matricula: " + matricula + "\n";
            tostring += "Nome: " + nome + "\n";
            tostring += "Cartão de Cidadão: " + cc + "\n";
            tostring += "Data de Nascimento: " + dataNasc.ToShortDateString() + "\n";
            return tostring;
        }
    }
}
