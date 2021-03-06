﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras;
using System.Drawing;

namespace Figuras
{
    class Triangulo
    {
        private Linha ab;
        private Linha bc;
        private Linha ca;

        public Triangulo(Ponto A, Ponto B, Ponto C)
        {

            ab = new Linha(A, B);
            bc = new Linha(B, C);
            ca = new Linha(C, A);
        }
        public Linha AB 
            {
            get
            {
                return ab;
            }
            set
            {
                ab = value;
            }
        }
        public Linha BC
        {
            get
            {
                return bc;
            }
            set
            {
                bc = value;
            }
        }
        public Linha CA
        {
            get
            {
                return ca;
            }
            set
            {
                ca = value;
            }
        }
        public void Draw(Graphics graph, Color c)
        {
            Pen pen = new Pen(c);

            graph.DrawLine(pen, ab.Inicial.X, ab.Inicial.Y, ab.Final.X, ab.Final.Y);
            graph.DrawLine(pen, bc.Inicial.X, bc.Inicial.Y, bc.Final.X, bc.Final.Y);
            graph.DrawLine(pen, ca.Inicial.X, ca.Inicial.Y, ca.Final.X, ca.Final.Y);
        }
        public override string ToString()
        {
            return string.Format("L [{0}] , [{1}] , [{2}]", ab.Inicial.ToString(), ab.Final.ToString(), bc.Final.ToString() );
        }
    }

}
