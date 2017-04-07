using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Ponto
    {
        private float x;
        private float y;



        public Ponto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public override string ToString()
        {
            return string.Format("P ( {0} , {1} )",x,y);
        }
    }
}
