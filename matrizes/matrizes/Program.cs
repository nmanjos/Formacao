using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes
{
    class Program
    {
        public static int[,] PreencheMatriz(int [,] mat)
        {
            Random r = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat(i, j) = r.Next(1, 10);
                }
            }
            return mat;
        }
        static void Main(string[] args)
        {

        }
    }
}
