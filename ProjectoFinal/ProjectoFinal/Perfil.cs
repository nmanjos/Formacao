using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    /// <summary>
    /// Classe abstrata dos Perfis de utilizador, na base de dados existirá uma unica tabela com toda a informação que é carregada para as classes conforme necessário! 
    /// </summary>
    abstract class Perfil
    {
        private string nome;
        private int nif; // primary key
        private string senha;
        private Habilitacao nivelhab;
        public  Perfil(string Nome, int NIF, string Senha, Habilitacao NivelHab)
        {
            nome = Nome;
            nif = NIF;
            senha = Senha;
            nivelhab = NivelHab;
        }
        public Perfil()
        {
            nome = "";
            nif = 0;
            senha = "";
            nivelhab = null;
        }

       public int NIF
        {
            get
            {
                return nif;
            }
            set
            {
                nif = value;
            }
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
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }
        public Habilitacao NivelHab
        {
            get
            {
                return nivelhab;
            }
            set
            {
                nivelhab = value;
            }
        }


    }
}
