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
            Console.WriteLine("Lista de cores: \r\n1 – Azul \r\n2 – Amarelo  \r\n3 – Verde \r\n4 – Cor - de - rosa \r\n5 – Roxo \r\n6 – Laranja");
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
        public static string EscreveCor(char escolha)
        {
            switch (escolha)
            {
                case 'U':
                    return "AZUL";
                case 'A':
                    return "AMARELO";
                case 'V':
                    return "VERDE";
                case 'R':
                    return "ROSA";
                case 'O':
                    return "ROXO";
                case 'L':
                    return "LARANJA";
                case 'B':
                    return "BRANCO";
                case 'P':
                    return "PRETO";
                case 'N':
                    return "NADA";
                default:
                    return "NADA";
            }
        }
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

            for (int i = 0; i < aposta.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Indique a cor que quer para o pino {0}", i+1);
                MostraCores();
                aposta[i] = EscolheCor(int.Parse(Console.ReadLine()));
            }
            return aposta;
        }
        //Devolve TRUE caso o conteúdo das posições das tabelas coincidam naquele índice
        public static bool ValidaBrancos(int index, char[] apostas, char[] escolhas)
        {
            if (apostas[index] == escolhas[index])
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
                if (ValidaBrancos(i, aposta, escolhas))
                {
                    result[i] = EscolheCor(BRANCO);
                }
                else if (ValidaPretos(aposta[i], escolhas))
                {
                    result[i] = EscolheCor(PRETO);
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
                    return result;
                }
            }
            return result;
        }

        //Devolve uma string com o conteúdo da tabela
        //Exemplo: [O | O | O | O]
        public static void MostraTabela(char[] tabela)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("[ ");
            for (int i = 0; i < tabela.Length; i++)
            {
                switch (tabela[i])
                {
                    case 'U':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("O");
                        break;
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O");
                        break;
                    case 'V':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("O");
                        break;
                    case 'R':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("O");
                        break;
                    case 'O':
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("O");
                        break;
                    case 'L':
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("O");
                        break;
                    case 'B':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("O");
                        break;
                    case 'P':
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("O");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (i == tabela.Length - 1)
                {
                    Console.Write(" ] \r\n");
                }
                else
                {
                    Console.Write(" | ");
                }

            }
            Console.ResetColor();
        }

        public static string pergunta(string mens)
        {
            Console.WriteLine("P:" + mens);
            return Console.ReadLine();
        }
        //Controla todas as funções anteriores de modo a arrancar o jogo
        public static void ajuda(char[] resposta, char[] escolha)
        {
            Console.WriteLine("Vamos lhe dar uma ajuda com base na sua ultima resposta! \r\n Vamos lhe revelar a cor do primeiro pino desconhecido!");

            for (int i = 0; i < escolha.Length; i++)
            {
                if (!(resposta[i] == EscolheCor(BRANCO)))
                {
                    Console.WriteLine("A Cor do pino {0} é {1}, Carregue em qualquer tecla para continuar!", i+1, EscreveCor(escolha[i]));
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Algo correu mal não devia ter chegado a este ponto do código, valide a lógica da função ajuda!");
            Console.ReadLine();
            return;
        }
        public static void ControlaJogo()
        {


            char[] escolha = new char[4];
            char[] resp = new char[4];
            bool continua = false;  

            int ajudas = 2; // contador das ajudas
            do
            {
                continua = false;
                escolha = Escolhas();
                MostraTabela(escolha);
                Console.WriteLine("Vamos jogar ao MasterMind ........ \r\n Regras:  \r\n Tem 4 pinos para escolher 10 tentativas e 2 ajudas, quando chegar ás 5 tentativas passa a só ter 1 ajuda");
                Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    resp = Resposta(Apostas(), escolha);
                    if (!ValidaGanhou(resp))
                    {
                        Console.WriteLine("Acabou de Jogar a Tentativa {0}", i + 1);
                        MostraTabela(resp);
                        if (pergunta("Quer uma ajuda ? (S/N)") == "S")
                        {
                            if (ajudas > 0)
                            {
                                if (i > 4)
                                {
                                    ajudas = ajudas - 1;
                                }
                                else
                                {
                                    ajudas = 0;
                                }
                            }

                            ajuda(resp, escolha);
                        }
                    }
                    else if (ValidaGanhou(resp))
                                        {
                        MostraTabela(escolha);
                        MostraTabela(resp);
                        i = 11;
                        if (pergunta("Ganhou !!!! quer continuar a jogar ? (S/N)") == "S")
                        {
                            continua = true;
                        }
                    }

                }
                if (continua == false && pergunta("Acabaram as 10 tentativas, quer continuar a jogar ? (S/N)") == "S")
                {
                    continua = true;
                }

            } while (continua);
            }



         

    static void Main(string[] args)
    {
        ControlaJogo();
    }
}
}

