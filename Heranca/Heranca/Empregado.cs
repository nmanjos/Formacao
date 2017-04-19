using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Empregado
    {
        private string nome;
        private int idade;
        public Empregado(String NomeDaPessoa, int IdadeDaPessoa):this(NomeDaPessoa)
        {
            
            idade = IdadeDaPessoa;

        }
        public Empregado(String NomeDaPessoa)
        {
            nome = NomeDaPessoa;
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
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }
        public virtual String MostraFuncao()
        {
            return "Empregado";
        }
    }
}
