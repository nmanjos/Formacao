using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras
{
    class Quadrilatero
    {
        private Linha ab;
        private Linha bc;
        private Linha cd;
        private Linha da;

        public Quadrilatero(Ponto A, Ponto B, Ponto C, Ponto D)
        {

            ab = new Linha(A, B);
            bc = new Linha(B, C);
            cd = new Linha(C, D);
            da = new Linha(D, A);
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
        public Linha CD
        {
            get
            {
                return cd;
            }
            set
            {
                cd = value;
            }
        }
        public Linha DA
        {
            get
            {
                return da;
            }
            set
            {
                da = value;
            }
        }

        public void Draw(Graphics graph, Color c)
        {
            Pen pen = new Pen(c);

            graph.DrawLine(pen, ab.Inicial.X, ab.Inicial.Y, ab.Final.X, ab.Final.Y);
            graph.DrawLine(pen, bc.Inicial.X, bc.Inicial.Y, bc.Final.X, bc.Final.Y);
            graph.DrawLine(pen, cd.Inicial.X, cd.Inicial.Y, cd.Final.X, cd.Final.Y);
            graph.DrawLine(pen, da.Inicial.X, da.Inicial.Y, da.Final.X, da.Final.Y);

        }
        public override string ToString()
        {
            return string.Format("L [{0}] , [{1}] , [{2}] , [{3}]", ab.Inicial.ToString(), ab.Final.ToString(), bc.Final.ToString(), cd.Final.ToString());
        }
    }
}
