using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formacao
{
    class Program
    {
        public static string Dec2bin(int dec)
        // returns an array of integers 
        {


            if (dec == 0)
            {
                return "";
            }
            else
            {
                return Dec2bin(dec / 2) + (dec % 2);
            }

        }
        // exemplo de recursividade
        public static int Soma1aN(int vinicial, int n)
        {
            if(vinicial == n)
            {
                return vinicial;
            }
            else
            {
                return vinicial + Soma1aN(++vinicial, n);
            }
        }
        public static int Fatorial(int n)
        {
            int resultado = 1;
            if (n == 1)
            {
                return resultado;
                
            }
            else
            {
               
                return n = n * Fatorial(--n); ;
            }
            
        }

        public static int Multiplicacao(int n, int m)
        {
                      
            if (n == 1)
            {
                return m;
            }
            else
            {

                return m + Multiplicacao(--n, m);

            }
        }
        static void Main(string[] args)
        {
            int pri = 0;
            int sec = 0;
            Console.WriteLine("Indique um numero");
            pri = int.Parse(Console.ReadLine());
            Console.WriteLine("o binario de {0} é {1}", pri, Dec2bin(pri));
            //    Console.WriteLine("Indique outro numero");
            //    sec = int.Parse(Console.ReadLine());
            //    Console.WriteLine("O Factorial de {0} é {1} e a multiplicação de {0} por {2} é {3}", pri, Fatorial(pri), sec, Multiplicacao(pri, sec));
            //
        }
    }
}
