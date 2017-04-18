using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figuras
{
    class Poligono
    {
        List<Linha> Linhas = new List<Linha>();
        public Poligono(List<Ponto> arestas)
        {
            
            
            
            for (int i = 0; i < arestas.Count; i++)
            {
                if (i == arestas.Count - 1)
                {
                    Linha line = new Linha(arestas[i], arestas[0]);
                    Linhas.Add(line);
                }else
                {
                    Linha line = new Linha(arestas[i], arestas[i + 1]);
                    Linhas.Add(line);
                }

            }
        }
        public List<Linha> GetLinhas()
        {
            return Linhas;
        }
        public void Draw(Graphics graph, Color c)
        {
            Pen pen = new Pen(c);
            foreach (Linha line in Linhas)
            {
                graph.DrawLine(pen, line.Inicial.X * 3, line.Inicial.Y * 3, line.Final.X * 3, line.Final.Y *3);
            }
            
        }
    }
}
