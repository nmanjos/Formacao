using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mdc
{
    class Program
    {

        static int mdc(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
            {
                return divisor;
            }
            return mdc(divisor, dividendo % divisor);
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero para achar o maximo divisor comum com outro");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero" );
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("O Maximo divisor comum entre {0} e {1} é {2}", a, b, mdc(a, b));
            nuno.lib.
        }
    }
}
