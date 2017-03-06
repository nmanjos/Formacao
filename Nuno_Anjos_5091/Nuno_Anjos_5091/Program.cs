/*
 * Resposta pergunta 1: teria de usar uma função visto no procedimento mais necessitar do valor do mesmo para processar o pagamento.
 * a Assinatuar seria algo do genero: public static double imposto(double rendimento)
 * 
 * Resposta pergunta 2:
 *                      a e c) o procedimento Main está a chamar outro procedimento Metodo1 que por sua vez imprime uma linha no ecran
 *                             com o valor passado no seu parametro var1, o metodo Main vai dar erro pois está a chamar um Procedimento como se fosse uma função
 *                             e atribuir esse valor a uma variavel inteira.
 *                      
 *                      b)  alterava várias instruções, a maneira mais simples é comentar a primeira instrução do método Main 
 *                          e alterar a segunda instrução para Console.WriteLine(100);
 *                          Opcionalmente para aproveitar o método Metodo1 para fazer tudo:  
                            public static string Metodo1(int var1)
                            {
                                Console.WriteLine(var1);
                            }
                            public static void Main()
                            {
                                Metodo1(100);
                            } 
 
*
* Resposta á pergunta 3:
* Recursividade permite explorar todas as respostas possiveis de uma estrutura de decisão independentemente do numero de variantes possiveis, numa estrutura de repetição só podemos repetir N vezes a mesma operação antes de sair, esse N é finito e sabido á partida, na recursividade não se sabe quantas repetições vai haver pois é determinado pelo input do utilizador!
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuno_Anjos_5091
{
    class Program
    {
        //1. Crie uma função que receba um número inteiro positivo e devolva um valor bool indicando se o número é ou não uma potência de 2. 
        //Pode utilizar ciclos ou recursividade.
        ///* Exemplo 6 FALSE – 8 TRUE. */
        public static bool isP2(int n)
        {
            int pot = 1;
            for (int i = 0; i < n; i++)
            {
                pot = pot * 2;
                if (n == pot || n == 1 || n == 0)
                {
                    return true;
                }
                if (n < pot)
                {
                    i = n;
                }
            }
            return false;
        }
        //2. Utilizando a função anterior(isP2), crie um procedimento recursivo que receba um valor N inteiro positivo e imprima as 
        //potências de 2, de N a 1. Atribua ao procedimento todos os argumentos que considerar necessários.
        ///* Exemplo: N = 15
            //8 4 2 1 */
        public static void ImprimeP2(int c)
        {

            if (isP2(c))
            {
                Console.Write("{0} ", c);
            }

            if (c > 0)
            {
                ImprimeP2(--c);
            }

        }

        //3. Crie uma função que receba um número inteiro e devolva os seguintes valores char:
        //a.O próprio número caso ele seja maior ou igual que 0 e menor que 10
        //b.As letras de A a F caso sejam os números de 10 a 15
        //c. 0 caso contrário
        //4.

        public static char int2Hex(int num)
        {
            if (num > 0 && num < 10)
            {
                return num.ToString()[0];
            }
            else if (num > 9 && num < 16)
            {
                switch (num)
                {
                    case 10:
                        return 'A';
                    case 11:
                        return 'B';
                    case 12:
                        return 'C';
                    case 13:
                        return 'D';
                    case 15:
                        return 'F';
                    default:
                        return '0';
                }

            }
            return '0';
        }

//        Crie uma função que receba como argumento um valor inteiro no sistema decimal e devolva-o no sistema hexadecimal mas como string. Utilize recursividade e a função anterior.Atribua à função todos os argumentos que considerar necessários.
///* Um valor em hexadecimal é calculado pelas sucessivas divisões por 16 de um valor decimal */
public static string DecToHex(int n, string valor)
        {
            if ( n / 16 != 0)
            {
                n = n % 16;
                return valor + int2Hex(int.Parse(DecToHex(n % 16, valor)));
            }
 
                return int2Hex(n % 16).ToString();
        }
            

        static void Main(string[] args)
        {
            Random num = new Random();


            ImprimeP2(num.Next(1, 30));
            Console.WriteLine(DecToHex(num.Next(1, 30),""));
        }
    }
}
