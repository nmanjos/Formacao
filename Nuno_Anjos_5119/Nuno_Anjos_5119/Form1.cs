using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Nuno_Anjos_5119
{

    public partial class Form1 : Form

    {
        public Random rr = new Random();
        public int aposta;
        public int[,] matriz;
        public Stack<int[]> scores = new Stack<int[]>();

        public string validaaposta(int[] tab)
        {
            string bet;
            if ((tab[0] > tab[1] && tab[2] == 1) || (tab[0] < tab[1] && tab[2] == 2))
            {
                bet = "ACERTOU NA APOSTA";
            }
            else
            {
                bet = "ERROU NA APOSTA";
            }
            return bet;
        }
        public  int[] matstat(int[,] mat)
        {
            int[] tab = new int[3];
            foreach (int item in mat)
            {
                if (item == 1) tab[0] = tab[0] + 1;
                if (item == 2) tab[1] = tab[1] + 1;
            }

            tab[2] = aposta;
            scores.Push(tab);
   
            
            return tab;
        }
        public void CriaMatriz(int dimen)
        {
            
            
            matriz = null;
            matriz = new int[dimen, dimen];
            for (int i = 0; i < dimen; i++)
            {
                for (int j = 0; j < dimen; j++)
                {
                    matriz[i,j]= rr.Next(1,3);
                }
            }

        }

        public void printmatrix(int[,] mat)
        {
            rtxtResultA.Text = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    rtxtResultA.Text +=  " " + mat[i, j];
                }
                rtxtResultA.Text +=  "\n" ;
            }
            txtInputA.Text = "";
            txtInputB.Text = "";
            rtxtResultB.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btMatriz_Click(object sender, EventArgs e)
        {
            if (txtInputA.Text != "")
            {
                try
                {
                    CriaMatriz(int.Parse(txtInputA.Text));
                }
                catch (InvalidCastException c)
                {
                    MessageBox.Show("Erro, Por Favor introduza um numero inteiro");
                    throw;
                }
                if (txtInputB.Text != "")
                {
                    int a = int.Parse(txtInputB.Text);
                    if (a >= 1 && a <= 2)
                    {
                        aposta = a;
                    }
                    else
                    {
                        MessageBox.Show("O Input B tem de ser um Inteiro entre 1 e 2");
                    }
                }
                else
                {
                    MessageBox.Show("O Input B tem de ser Preenchido");
                }
                printmatrix(matriz);
            }
        }

        private void btContagem_Click(object sender, EventArgs e)
        {
            int[] tab = matstat(matriz);

            rtxtResultB.Text = "1’s[" + tab[0] + "] - 2’s[" + tab[1] + "] - Aposta: " + tab[2] + "\n " + validaaposta(tab);
        }

        private void btScores_Click(object sender, EventArgs e)
        {
            rtxtResultA.Text = "";
            foreach (int[] tab in scores)
            {
                rtxtResultA.Text += "1’s[" + tab[0] + "] - 2’s[" + tab[1] + "] - Aposta: " + tab[2] + "\n";
            }
                

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            
            aposta = 0;
            matriz=null;
            scores.Clear();

            txtInputA.Text = "";
            txtInputB.Text = "";
            rtxtResultA.Text = "";
            rtxtResultB.Text = "";

        }
    }
}
