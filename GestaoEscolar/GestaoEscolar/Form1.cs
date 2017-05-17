using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class Form1 : Form
    {
        private IBDEscolar bd;

        public Form1()
        {
            InitializeComponent();
            bd = new BDEscolarSQL();
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int matricula = int.Parse(txtMatricula.Text);
            int cc = int.Parse(txtCc.Text);
            string data = txtData.Text;
            DateTime dataNasc = Convert.ToDateTime(data);

            if (rbtnInterno.Checked)
            {
                string curso = cmbCurso.SelectedItem.ToString();
                string turma = cmbTurma.SelectedItem.ToString();
                bd.CriarAluno(matricula, nome, cc, dataNasc, curso, turma);
                MessageBox.Show("Aluno criado com sucesso.");
            }
            else if (rbtnExterno.Checked)
            {
                bd.CriarAluno(matricula, nome, cc, dataNasc);
                MessageBox.Show("Aluno criado com sucesso.");
            }
            else
                MessageBox.Show("Escolha um tipo de aluno.");

        }

        private void rbtnDados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDados.Checked)
            {
                if (txtMatVis.Text != "")
                {
                    int matricula = int.Parse(txtMatVis.Text);
                    string mensagem = bd.VisualizaDados(matricula);
                    txtVisualizacoes.Text = mensagem;
                }
                else
                    MessageBox.Show("Escolha um aluno.");
            }
        }

        private void rbtnAvaliacoes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAvaliacoes.Checked)
            {
                if (txtMatVis.Text != "")
                {
                    int matricula = int.Parse(txtMatVis.Text);
                    string mensagem = bd.VisualizaAvaliacoes(matricula);
                    txtVisualizacoes.Text = mensagem;
                }
                else
                    MessageBox.Show("Escolha um aluno.");
            }
        }

        private void btnAddMediaAnual_Click(object sender, EventArgs e)
        {
            if (txtMatAval.Text != "")
            {
                int matricula = int.Parse(txtMatAval.Text);
                if (txtMediaAnual.Text != "")
                {
                    double media = double.Parse(txtMediaAnual.Text);
                    string mensagem = bd.AddMediaAno(matricula, media);
                    MessageBox.Show(mensagem);
                }
                else
                    MessageBox.Show("Insira uma média.");
            }
            else
                MessageBox.Show("Escolha um aluno.");
        }

        private void btnAddDisc_Click(object sender, EventArgs e)
        {
            if (txtMatAval.Text != "")
            {
                int matricula = int.Parse(txtMatAval.Text);
                if (txtCodigo.Text != "")
                {
                    int code = int.Parse(txtCodigo.Text);
                    string nome = txtNomeDisc.Text;
                    if (txtNotaDisc.Text != "")
                    {
                        double nota = double.Parse(txtNotaDisc.Text);
                        string mensagem = bd.AddDisciplina(matricula, nome, code, nota);
                        MessageBox.Show(mensagem);
                    }
                    else
                        MessageBox.Show("Insira uma nota.");
                }
                else
                    MessageBox.Show("Insira um código de disciplina.");
            }
            else
                MessageBox.Show("Escolha um aluno.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbtnAvaliacoes.Checked = false;
            rbtnDados.Checked = false;
        }
    }
}
