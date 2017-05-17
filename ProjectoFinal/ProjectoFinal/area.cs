﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    /// <summary>
    /// Areas de Intervencao do Ticket (Equipamentos, Rede, Software)
    /// </summary>
    class Area
    {   
        string descricao;
        Habilitacao nivelminimo;

        public Area(string Descr, Habilitacao NivelMinimo)
        {
            descricao = Descr;
            nivelminimo = NivelMinimo;
        }
        public string Descr
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }
            
        public Habilitacao NivelMinimo
        {
            get
            {
                return nivelminimo;
            }
            set
            {
                nivelminimo = value;
            }
        }
        public override string ToString()
        {
            return descricao;
        }
    }
}
