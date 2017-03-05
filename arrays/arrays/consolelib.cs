using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;



namespace consolelib
{
    public class lib
    {
        public static double[] formunaresolvente(double A, double B, double C)
        { 
            double[] resultado = new double[2];
            resultado[0] = (-B + Sqrt(Pow(B, 2) - 4 * A * C)) / (2 * A);
            resultado[1] = (-B - Sqrt(Pow(B, 2) - 4 * A * C)) / (2 * A);



            return resultado;
        }
        public static string pergunta(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }
        public static void mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
