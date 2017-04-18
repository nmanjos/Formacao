using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras
{
    class Linha
    {
        private Ponto inicial;
        private Ponto final;

        public Linha(Ponto inicial, Ponto final)
        {
            this.inicial = inicial;
            this.final = final;
        }
        public Ponto Inicial
        {
            get
            {
                return inicial;
            }
            set
            {
                inicial = value;
            }
        }
        public Ponto Final
        {
            get
            {
                return final;
            }
            set
            {
                final = value;
            }
        }
        public void Draw(Graphics graph, Color c)
        {
            Pen pen = new Pen(c);

            graph.DrawLine(pen, inicial.X, inicial.Y , final.X , final.Y);
        }

               public override string ToString()
        {
            return string.Format("L [{0}] , [{1}]",inicial.ToString(), final.ToString());
        }
    }

}
