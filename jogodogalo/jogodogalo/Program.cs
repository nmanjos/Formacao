using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogodogalo
{
    // Autor: Nuno Anjos

    class Program
    {

        //Verifica se uma posição esta dentro da matriz
        

        public static bool ExistePosicao(int linha, int coluna, int[,] mat)
        {
            bool valor = false;
            if (linha < mat.GetLength(0) && coluna < mat.GetLength(1))
            {
                valor = true;
            }
            return valor;
        }
        //Verifica se uma posição da matriz está vazia (igual a 0)
        public static bool EstaVazio(int linha, int coluna, int[,] mat)
        {
            bool valor = false;
            if (mat[linha, coluna] == 0)
            {
                valor = true;
            }
            return valor;
        }
        //Adiciona um valor inteiro (1 a 4) a uma posição da matriz
        public static void AdicionaNaPosicao(int linha, int coluna, int valor, int[,] mat)
        {
            mat[linha, coluna] = valor;
        }
        //Devolve uma linha da matriz num array unidimensional
        public static int[] LinhaMatriz(int linha, int[,] mat)
        {
            int[] matriz = new int[mat.GetLength(1)];
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                matriz[i] = mat[linha, i];
            }
            return matriz;
        }
        //Devolve uma coluna da matriz num array unidimensional
        public static int[] ColunaMatriz(int coluna, int[,] mat)
        {
            int[] matriz = new int[mat.GetLength(0)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                matriz[i] = mat[i, coluna];
            }
            return matriz;
        }
        //Devolve a diagonal esquerda da matriz num array unidimensional
        public static int[] DiagonalEsquerdaMatriz(int[,] mat)
        {
            int[] result = new int[mat.GetLength(0)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                result[i] = mat[i, i];
            }
            return result;
        }
        //Devolve a diagonal direita da matriz num array unidimensional
        public static int[] DiagonalDireitaMatriz(int[,] mat)
        {
            int[] result = new int[mat.GetLength(0)];
            int j = 0;
            for (int i = mat.GetLength(0); i <= 0; --i)
            {
                result[j] = mat[i, j++];
            }
            return result;
        }
        //Altera uma linha da matriz somando 2 a todas as posições
        public static void GanhaLinhaMatriz(int linha, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                AdicionaNaPosicao(linha, i, mat[linha, i] + 2, mat);
            }
        }
        //Altera uma coluna da matriz somando 2 a todas as posições
        public static void GanhaColunaMatriz(int coluna, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                AdicionaNaPosicao(i, coluna, mat[i, coluna] + 2, mat);
            }
        }
        //Altera diagonal esquerda da matriz somando 2 a todas as posições
        public static void GanhaDiagonalEsquerda(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                AdicionaNaPosicao(i, i, mat[i, i] + 2, mat);
            }
        }
        //Altera diagonal direita da matriz somando 2 a todas as posições
        public static void GanhaDiagonalDireita(int[,] mat)
        {
            int j = 0;
            for (int i = mat.GetLength(0); i >= 0; --i)
            {
                AdicionaNaPosicao(i, j, mat[i, j++] + 2, mat);
            }
        }
        //Verifica se um array unidimensional tem todos os seus valores iguais, caso sejam 0 assume que são valores diferentes
        public static bool ValoresIguais(int[] tab)
        {
            bool result = false;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] == tab[i + 1] && tab[i] != 0)
                {
                    result = true;
                }
                else
                {
                    return false;
                }

            }
            return result;
        }

        //Verifica se todas as linhas, colunas ou diagonais têm os seus valores iguais
        public static bool MatrizIguais(int[,] mat)
        {
            if (ValoresIguais(DiagonalEsquerdaMatriz(mat)))
            {
                GanhaDiagonalEsquerda(mat);
                return true;
            }
            else if (ValoresIguais(DiagonalDireitaMatriz(mat)))
            {
                GanhaDiagonalDireita(mat);
                return true;
            }
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (ValoresIguais(ColunaMatriz(i, mat)))
                {
                    GanhaColunaMatriz(i, mat);
                    return true;
                }
                else if (ValoresIguais(LinhaMatriz(i, mat)))
                {
                    GanhaLinhaMatriz(i, mat);
                    return true;
                }
            }
            return false;
        }
        //Imprime uma matriz com o seguinte Layout:
        //Se na posição estiver 0, deve mostrar o contador correspondente (como no exemplo), caso contrário o próprio número
        //Atualize o Imprime Grelha para imprimir um X caso o número da posição seja 1 e um O caso seja 2. Se for 3 ou 4 o 
        //objetivo é imprimir o simbolo X ou Y com a cor verde respetivamente.
        public static void ImprimeGrelha(int[,] mat)
        {
            int counter = 0;
            for (int i = 0; i < mat.GetLength(0); i++)

            {
                Console.Write(" ");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    counter++;
                    switch (mat[i, j])
                    {
                        case 0:
                            if (counter < 10)
                            {
                                Console.Write("0"+ counter);
                            }
                            else
                            {
                                Console.Write(counter);
                            }
                            break;
                        case 1:
                            Console.Write(" X");
                            break;
                        case 2:
                            Console.Write(" O");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" X");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" O");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Console.Write(" ");
                            break;
                    }
                    if (j < mat.GetLength(1) - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.Write("\n");
                for (int l = 0; l < (mat.GetLength(1)); l++)
                {
                    Console.Write("-----");
                }

                Console.Write("\n");
            }
        }
        // 1 | 2 | 3
        // 4 | 5 | 6
        // 7 | 8 | 9
        //Retorna o índice da linha de um determinado contador
        public static int indiceLinha(int[,] mat, int pos)
        {
            int counter = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    counter++;
                    if (counter == pos)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
        //Retorna o índice da coluna de um determinado contador
        public static int indiceColuna(int[,] mat, int pos)
        {
            int counter = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    counter++;
                    if (counter == pos)
                    {
                        return j;
                    }
                }
            }
            return 0;
        }


        /*
        1 | 2 | 3
        4 | 5 | 6
        7 | 8 | 9
        */
        //Controla todas as funções anteriores de modo a arrancar o jogo
        public static void ControlaJogo()
        {
            Console.Clear();
            Console.WriteLine("Vamos Jogar ao Jogo do Galo, O jogo é jogado por dois jogadores, a grelha pode ser de 3,5,7,9 linhas por colunas");
            Console.WriteLine("Escolha o tamanho da grelha indique um numero Impar entre 3 e 9");
            int dificuldade = int.Parse(Console.ReadLine());
            int[,] grelha = new int[dificuldade, dificuldade];
            int gamestate = 0; // game not started
            if (dificuldade % 2 != 0 && dificuldade >=3 && dificuldade <= 9)
            
            {
                gamestate = 1; // game started
                Console.WriteLine("Tem {0} Jogadas", grelha.Length);
                int jogador = 1;
                int pos = 1;
                
                for (int jogada = 0; jogada < grelha.Length; jogada++)
                {
                    Console.Clear();
                    ImprimeGrelha(grelha);


                    Console.WriteLine("Jogador {0} indique um numero disponivel da grelha para jogar", jogador);
                    pos = int.Parse(Console.ReadLine());
                    int idLinha = indiceLinha(grelha, pos);
                    int idColuna = indiceColuna(grelha, pos);
                    if (ExistePosicao(idLinha, idColuna, grelha) && EstaVazio(idLinha,idColuna,grelha))
                    {
                        AdicionaNaPosicao(idLinha, idColuna, jogador, grelha);

                    }
                    else
                    {
                        Console.WriteLine("A posição que acabou de indicar não é uma posição válida da grelha, acabou de desperdiçar uma jogada!");
                        Console.ReadLine();
                    }
                    if (MatrizIguais(grelha))
                    {
                        Console.Clear();
                        Console.WriteLine("O Jogador {0} GANHOU !!!!", jogador);
                        ImprimeGrelha(grelha);
                        jogada = grelha.Length + 5;
                        gamestate = 2; // game Won

                    }
                    if (jogador == 1)
                    {
                        jogador = 2;
                    }
                    else
                    {
                        jogador = 1;
                    }

                }
                if (gamestate != 2) Console.WriteLine("O Jogo Ficou empatado !!!");
            }
            else
            {
                Console.WriteLine("Tem de introduzir um numero Impar de 3 as 9");

            }
                
                Console.Write("Quer Jogar de novo ?  (S/N)");
                      
            if (Console.ReadLine().ToUpper() == "S")
            {
                ControlaJogo();
            }
        }





        static void Main(string[] args)
        {
            ControlaJogo();
        }
    }
}
