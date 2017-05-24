using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prova5118
{
    public partial class ComputerRepair : Form
    {
        BDComputadores RepairList = new BDComputadores();
        public ComputerRepair()
        {
            InitializeComponent();
        }

        private void btAddComputer_Click(object sender, EventArgs e)
        {
            if (rbtNotebook.Checked)
            {
                 RepairList.AddComputador(txtSerial.Text, txtMarca.Text, txtModelo.Text, txtMotherboard.Text, double.Parse(txtScreenSize.Text));
            }
            if (rbtDesktop.Checked)
            {
                RepairList.AddComputador(txtSerial.Text, txtMarca.Text, txtModelo.Text, txtMotherboard.Text,txtProcessador.Text,int.Parse(txtPSU.Text));
            }
        }

        private void ComputerRepair_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           txtResultado.Text += RepairList.CalculaCustoReparacao(int.Parse(txtCalcSerial.Text), double.Parse(txtCalcHoras.Text), double.Parse(txtCalcPecas.Text));
        }
    }
}
