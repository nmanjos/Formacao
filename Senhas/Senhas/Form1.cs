using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Senhas
{
    public partial class Form1 : Form
    {
        Queue<string> listaG = new Queue<string>();
        char LetraG = 'A';
        int senhaG = 0;
        Queue<string> listaP = new Queue<string>();
        char LetraP = 'A';
        int senhaP = 0;
        int ContPrio = 0;
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public string FazSenha(char l, int s)
        {
            if (s<10)
            {
                return l + "0" + s.ToString();
            }
            return l + s.ToString();
        }

        public void diztexto(string texto)
        {
            {
                
                synth.Volume = 100;  // 0...100
                synth.Rate = -2;// -10...10
                synth.SelectVoice(comboBox1.Text);
                // Synchronous
                synth.Speak(texto);

                // Asynchronous
                //synthesizer.SpeakAsync("Hello World");



            }
        }
        public void ChamaSenha(int balcao)

        {
            if ((ContPrio == 2 || listaP.Count == 0) && listaG.Count > 0)
            {
                // processa lista G
                GeralPublico.Text="Balcão "+ balcao +" - " + listaG.Dequeue();
                diztexto("Geral  " + GeralPublico.Text);
                ContPrio = 0;


            }
            else
            {
                // Processa lista P
                if (listaP.Count > 0)
                {
                    PrioPublico.Text = "Balcão " + balcao + " - " + listaP.Dequeue();
                    diztexto("Prioritário  " + PrioPublico.Text);
                }
                
                if (ContPrio < 2)
                {
                    ContPrio++;
                }
                else
                {
                    ContPrio = 0;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void NovoGeral_Click(object sender, EventArgs e)
        {
            ultimasenha.Text = "A Sua Senha é: G - " + FazSenha(LetraG, senhaG);
            listaG.Enqueue(FazSenha(LetraG, senhaG));
            if (senhaG < 99)
            {
                senhaG++;
            }
            else
            {
                senhaG = 0;
            }
            if (senhaG == 0)
            {
                if (LetraG < 'Z')
                {
                    LetraG++;
                }
                else
                {
                    LetraG = 'A';
                }
            }
        }

        private void NovoPrio_Click(object sender, EventArgs e)
        {
            ultimasenha.Text = "A Sua Senha é: P - " + FazSenha(LetraP, senhaP);
            listaP.Enqueue(FazSenha(LetraP, senhaP));
            if (senhaP < 99 )
                {
                senhaP++;
            }
            else
            {
                senhaP = 0;
            }
            if (senhaP == 0)
            {
                if (LetraP < 'Z')
                {
                    LetraP++;
                }
                else
                {
                    LetraP = 'A';
                }
            }
        }

        private void Balcao1_Click(object sender, EventArgs e)
        {
            ChamaSenha(1);
        }

        private void Balcao2_Click(object sender, EventArgs e)
        {
            ChamaSenha(2);
        }

        private void Balcao3_Click(object sender, EventArgs e)
        {
            ChamaSenha(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeralPublico.Text = "Balcão  - ";
            PrioPublico.Text = "Balcão  - ";
            
            foreach (InstalledVoice voz in synth.GetInstalledVoices())
            {
                comboBox1.Items.Add(voz.VoiceInfo.Name);

            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
