using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Tecnico : Perfil
    {
        List<Area> areaintre = new List<Area>();
        bool is_admin = false;
        public Tecnico(string Nome, int NIF, string Senha, Habilitacao NivelHab, List<Area> AreaIntre, bool Is_Admin) : base(Nome, NIF, Senha, NivelHab)
        {
            is_admin = Is_Admin;
            areaintre = AreaIntre;
        }
    }
}
