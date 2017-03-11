using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using matrix 

namespace matrizes
{
    class Program
    {
 
        
        public Matrix  
        public static int[,] PreencheMatriz(int[,] mat)
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

        //Preenche a matriz com valores aleatórios de 1 a 9

        Exemplo: | 7 | 0 | 6 |
            | 0 | 9 | 5 |
            | 3 | 0 | 8 |
            public static string MostraMatriz(int[,] mat)
        {
            string matriz = "";
            for (int i = 0; i < mat.GetLength(0); i++) 
            {
                matriz += "|";
                for (int j = 0; j < mat.GetLength(1); j++) 
                {
                    matriz += " "+ mat[i, j] + "|";
                }
                matriz += "\n";
            }
            return matriz;
        }
        //Matriz Identidade
        public static int[,] MatrizIdentidade(int size)
        {
            int[,] mat = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                mat[i, i] = 1;
            }
            return mat;
        }
        //Matriz Transposta
        public static int[,] MatrizTransposta(int[,] mat)
        {
            int[,] matB = new int[mat.GetLength(0), mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    matB[j, i] = mat[i, j];
                }
            }return matB;
        }
        //Soma duas matrizes
        public static int[,] SomaMatrizes(int[,] matA, int[,] matB)
        {
            int[,] matC = new int[matA.GetLength(0), matA.GetLength(1)];
            if ((matA.GetLength(0) == matB.GetLength(0)) & (matA.GetLength(1) == matB.GetLength(1)))
            {
                
                for (int i = 0; i < matC.GetLength(0); i++)
                {
                    for (int j = 0; j < matC.GetLength(1); j++)
                    {
                        matC[i, j] = matA[i, j] + matB[i, j];
                    }
                }
            }
            return matC;
            
        } 

        //Multiplica duas matrizes
        public static int[,] MultiplicaMatrizes(int[,] matA, int[,] matB)
        {
            int[,] matC = new int[matA.GetLength(0), matA.GetLength(1)];
          
            if (matA.GetLength(0) == matB.GetLength(1))
            {
                for (int Ai = 0; Ai < matA.GetLength(0); Ai++)
                {
                    for (int Bj= 0; Bj < matB.GetLength(1); Bj++)
                    {
                        for (int Aj = 0; Aj < matA.GetLength(1);Aj++)
                        {
                                matC[Ai, Bj] += matA[Bj, Aj] * matB[Aj,Bj];
                        }
                    }
                   
                }

            }
            return matC;
        }
        //Calcula o determinante (Método de Sarrus)
        public static int[,] Determinante(int[,] matA)
        {

        }



        static void Main(string[] args)
        {

        }
    }
}
