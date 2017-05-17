using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class Disciplina
    {
        private string nome;
        private int code;
        private double nota;

        public Disciplina(string nome, int code, double nota)
        {
            this.nome = nome;
            this.code = code;
            this.nota = nota;
        }

        public string Nome
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
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public double Nota
        {
            get
            {
                return nota;
            }
            set
            {
                nota = value;
            }
        }
    }
}
