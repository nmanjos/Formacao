using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        private List<Ponto> pontos;
        private List<Linha> linhas;
        private List<Triangulo> triangulos;
        public Form1()
        {
            InitializeComponent();
            pontos = new List<Ponto>();
            linhas = new List<Linha>();
            triangulos = new List<Triangulo>();
        }
        private void Drawline(Color c, Ponto a, Ponto b)
        {
            Graphics graph = this.panelDraw.CreateGraphics();
            Pen pen = new Pen(c);
            graph.DrawLine(pen, a.X*2, a.Y*2, b.X*2, b.Y*2);
            
        }
        private void DrawQuadrilatero(Quadrilatero Quadr)
        {
            List<Ponto> Arestas = new List<Ponto>();
            Arestas.Add(Quadr.AB.Inicial);
            Arestas.Add(Quadr.AB.Final);
            Arestas.Add(Quadr.CD.Inicial);
            Arestas.Add(Quadr.CD.Final);

            Poligono poli = new Poligono(Arestas);
            poli.Draw(panelDraw.CreateGraphics(), Color.Black);


        }
        private void DrawPoligon(Poligono poli)
        {

            poli.Draw(panelDraw.CreateGraphics(),Color.Black);
 

        }
        private void DrawTriangulo(Color c, Linha L1, Linha L2, Linha L3)
        {
            List<Ponto> Arestas = new List<Ponto>();
            Arestas.Add(L1.Inicial);
            Arestas.Add(L2.Inicial);
            Arestas.Add(L3.Inicial);
            Poligono poli = new Poligono(Arestas);
            poli.Draw(panelDraw.CreateGraphics(), Color.Black);

            Drawline(Color.Red, L1.Inicial, L1.Final);
            Drawline(Color.Red, L2.Inicial, L2.Final);
            Drawline(Color.Red, L3.Inicial, L3.Final);
        }
        public void FillCombo(ComboBox combo, List<object> list)
        {
            combo.Items.Clear();
            foreach (object obj in list)
            {
                combo.Items.Add(obj.ToString());
            }
        }
        private void CreateHeader(ListView lst, string[] header)
        {
            lst.Clear();
            foreach (string head in header)
            {
                lst.Columns.Add(head)
                .Width = lst.Width / header.Length;
            }
        }
        private void InsertItem(ListView lst , List<object> list)
        {
            string[] cabecalho = { "Pontos" };
            CreateHeader(lstPontos, cabecalho);
            
            foreach (object obj in list)
            {
                ListViewItem lvi = new ListViewItem(obj.ToString());
                lst.Items.Add(lvi);
            }

            
        }
        private void btnAddPonto_Click(object sender, EventArgs e)
        {
            
            //InsertItem(lstPontos, dados);

            pontos.Add(new Ponto((float)nupX.Value, (float)nupY.Value));
            List<object> objPontos = new List<Object>(pontos);
            
        }

        private void cmbPontos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddLinha_Click(object sender, EventArgs e)
        {
            int pA = cmbPontoA.SelectedIndex;
            int pB = cmbPontoB.SelectedIndex;
            if (pA<0 || pB < 0) 
            {
                MessageBox.Show("não selecionou um ou mais pontos");
            }
            else
            {
                Ponto inicial = pontos[pA];
                Ponto final = pontos[pB];

                Linha l = new Linha(inicial, final);
                linhas.Add(l);
                List<object> objLinhas = new List<object>(linhas);
                FillCombo(cmbLinhas, objLinhas);
            }
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            int linha = cmbLinhas.SelectedIndex;
            if (linha >= 0)
            {
                Linha line = linhas[linha];
                Drawline(Color.Black, line.Inicial, line.Final);
            }
        }

        private void btAddTri_Click(object sender, EventArgs e)
        {
            int pA = cmbPTriA.SelectedIndex;
            int pB = cmbPTriB.SelectedIndex;
            int pC = cmbPTriC.SelectedIndex;
            if (pA < 0 || pB < 0 || pC < 0)
            {
                MessageBox.Show("não selecionou um ou mais pontos");
            }
            else
            {
                Ponto A = pontos[pA];
                Ponto B = pontos[pB];
                Ponto C = pontos[pC];

                Triangulo t = new Triangulo(A, B, C);

                triangulos.Add(t);
                List<object> objTriangulos= new List<object>(triangulos);
                FillCombo(cmbtriang, objTriangulos);
            }
        }

        private void btnDrawTri_Click(object sender, EventArgs e)
        {
            int linha = cmbtriang.SelectedIndex;
            if (linha >= 0)
            {
                Triangulo tri = triangulos[linha];
                DrawTriangulo(Color.Navy,tri.AB,tri.BC,tri.CA );

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
