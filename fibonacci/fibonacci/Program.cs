using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static Int64 fibonacci(Int64 numero)
        {
            Console.Write("  {0}  ",numero);

            if (numero == 0)
            {   
                return 0;
            }
            if (numero == 1)
            {
                return 1;
            }
            return fibonacci(numero - 1) + fibonacci(numero - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a sequencia de fibonacci para um numero que indicar !");
            Int64 a = Int64.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("O fibonacci de {0} é {1}", a, fibonacci(a));
        }
    }
}
