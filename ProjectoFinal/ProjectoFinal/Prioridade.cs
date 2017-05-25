﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Prioridade

    {
        int nivel; // 1 maxima ... 99 minima
        string smallname; // nome breve da prioridade na base de dados terá 15 caracteres
        string descr; //  Descricao mais detalhada

        public Prioridade(int Nivel, string Smallname, string Descr)
        {
            this.nivel = Nivel;
            this.smallname = Smallname;
            this.descr = Descr;
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public string Smallname
        {
            get
            {
                return smallname;
            }

            set
            {
                smallname = value;
            }
        }

        public string Descr
        {
            get
            {
                return descr;
            }

            set
            {
                descr = value;
            }
        }
    }
}
