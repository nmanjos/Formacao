using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        //   Crie as seguintes constantes:
        public const int AZUL = 1;
        public const int AMARELO = 2;
        public const int VERDE = 3;
        public const int ROSA = 4;
        public const int ROXO = 5;
        public const int LARANJA = 6;
        public const int BRANCO = 7;
        public const int PRETO = 8;
        public const int NADA = 9;
        //   Crie os seguintes métodos:
        /*
        Mostra as 6 cores disponiveis:
        1 – Azul 
        2 – Amarelo 
        3 – Verde 
        4 – Cor-de-rosa 
        5 – Roxo 
        6 – Laranja 
        */
        public static void MostraCores()
        {
            Console.WriteLine("Lista de cores: \r\n 1 – Azul \r\n 2 –  \r\n 3 – Verde \r\n 4 – Cor - de - rosa \r\n 5 – Roxo \r\n 6 – Laranja");
        }
        /*
        Devolve um char diferente consoante o índice escolha:
        1 – devolve U
        2 – devolve A
        3 – devolve V
        4 – devolve R
        5 – devolve O
        6 – devolve L
        7 – devolve B (BRANCO)
        8 – devolve P (PRETO)
        9 – devolve N (NADA)
        */
        public static char EscolheCor(int escolha)
        {
            switch (escolha)
            {
                case AZUL:
                    return 'U';
                case AMARELO:
                    return 'A';
                case VERDE:
                    return 'V';
                case ROSA:
                    return 'R';
                case ROXO:
                    return 'O';
                case LARANJA:
                    return 'L';
                case BRANCO:
                    return 'B';
                case PRETO:
                    return 'P';
                case NADA:
                    return 'N';
                default:
                    return 'N';
            }
        }
        //Devolve uma tabela unidimensional com 4 cores(CHAR) escolhidas pelo computador
        //aleatoriamente utilizando a função EscolheCor
        public static bool ValidaCor(char[] escolha, char cor)
        {
            for (int i = 0; i < escolha.Length; i++)
            {
                if (escolha[i] == cor)
                {
                    return false;
                }
            }
            return true;
        }


        public static char[] Escolhas()
        {

            Random rnd = new Random();
            char cor = EscolheCor(rnd.Next(1, 6));
            char[] Escolha = new char[4];
            for (int i = 0; i < 4; i++) {
                while (ValidaCor(Escolha, cor) == false)
                {
                    cor = EscolheCor(rnd.Next(1, 6));
                }
                Escolha[i] = cor;
            }
            return Escolha;
         }
            
    

//Devolve uma tabela unidimensional com 4 cores escolhidas pelo utilizador pelos métodos
//MostraCores e EscolheCor
public static char[] Apostas()
        {
            char[] aposta = new char[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Indique a cor que quer para o furo {0}", i);
                MostraCores();
                resposta [i]= EscolheCor(int.Parse(Console.ReadLine()));
                Console.Clear;
            }
            return aposta;
        }
//Devolve TRUE caso o conteúdo das posições das tabelas coincidam naquele índice
public static bool ValidaBrancos(int index, char[] apostas, char[] escolhas)
        {
            if (apostas[i] == escolhas[i])
            {
                return true;
            }
            return false;
        }
//Devolve TRUE caso a aposta exista na tabela escolhas
public static bool ValidaPretos(char aposta, char[] escolhas)
        {
            for (int i = 0; i < escolhas.Length; i++)
            {
                if (escolhas[i] == aposta)
                {
                    return true;
                }
            }
            return false;
        }
        //Devolve uma tabela unidimensional com 4 cores decididas pelo computador consoante as
        //apostas do utilizador.Utiliza as funções ValidaBrancos, ValidaPretos e EscolheCor
        public static char[] Resposta(char[] aposta, char[] escolhas)
        {
            char[] result = new char[4];
            for (int i = 0; i < aposta.Length; i++)
            {
                if (ValidaBrancos(i,aposta,escolhas ))
                {
                    result[i] = EscolheCor(BRANCO);
                }
                else
                {
                    ValidaPretos(aposta[i], escolhas);
                }
            }
            return result;
        }
//Devolve TRUE caso só existam brancos
public static bool ValidaGanhou(char[] resposta)
        {
            bool result = false;
            for (int i = 0; i < resposta.Length; i++)
            {
                if (resposta[i] == EscolheCor(BRANCO))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
        }

        //Devolve uma string com o conteúdo da tabela
        //Exemplo: [O | O | O | O]
        public static MostraTabela(char[] tabela)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray
            string result;
            Console.Write = "[ ";
            for (int i = 0; i < tabela.Length; i++)
            {
                switch (tabela[i])
                {


                    case 'U':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'V':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'R':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'O':
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'L':
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'B':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                    case 'P':
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" | ");
                }
            }
            Console.WriteLine 
            Console.ResetColor();
        }
//Controla todas as funções anteriores de modo a arrancar o jogo
public static void ControlaJogo()
        {
            char[] escolha = new char[4];
            escolha = Escolhas();
            ValidaGanhou(Resposta(Apostas(), escolha));
        }

 
        static void Main(string[] args)
        {
            ControlaJogo();
        }
    }
}
