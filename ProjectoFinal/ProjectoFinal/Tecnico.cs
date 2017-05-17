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
        public Tecnico() : base()
        {
            is_admin = false;
            areaintre = null;
        }
        public bool Is_Admin {
            get
            {
                return is_admin;
            }
            set
            {
                is_admin = value;
            }
        }
        public List<Area> AreaIntre
        {
            get
            {
                return areaintre;
            }
            set
            {
                areaintre = value;
            }
        }
        public void AddAreaIntre(Area Area)
        {
            areaintre.Add(Area);
        }
        public void DelAreaIntre(string Area)
        {
            areaintre.Find(x => x.Descr.Contains(Area));
        }
    }
}
