using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    abstract class Perfil
    {
        private String nome;
        private int nif; // primary key
        private string senha;
        private Habilitacao nivelhab;
        public  Perfil(String Nome, int NIF, string Senha, Habilitacao NivelHab)
        {
            nome = Nome;
            nif = NIF;
            senha = Senha;
            nivelhab = NivelHab;
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
