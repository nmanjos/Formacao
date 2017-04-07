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
        public Form1()
        {
            InitializeComponent();
            pontos = new List<Ponto>();
            linhas = new List<Linha>();
        }
        public void FillCombo(ComboBox combo, List<object> list)
        {
            combo.Items.Clear();
            foreach (object obj in list)
            {
                
                combo.Items.Add(obj.ToString());
            }
        }

        private void btnAddPonto_Click(object sender, EventArgs e)
        {
            pontos.Add(new Ponto((float)nupX.Value, (float)nupY.Value));
            List<object> objPontos = new List<Object>(pontos);
            FillCombo(cmbPontos, objPontos);
            FillCombo(cmbPontoA, objPontos);
            FillCombo(cmbPontoB, objPontos);
            
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
    }
}
