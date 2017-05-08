using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Tecnico : Perfil
    {
        public Tecnico(string Nome, int NIF, string Senha, Habilitacao NivelHab) : base(Nome, NIF, Senha, NivelHab)
        {
        }
    }
}
