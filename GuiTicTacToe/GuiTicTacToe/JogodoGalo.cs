using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GuiTicTacToe
{
    public partial class JogodoGalo : Form
    {
        private int dificuldade = 3;  // the  field
        public int Dificuldade    // the  property
        {
            get
            {
                return dificuldade;
            }
            set
            {
                dificuldade = value;
            }
        }
        public JogodoGalo()
        {
            InitializeComponent();
        }
        

        private void JogodoGalo_Load(object sender, EventArgs e)
        {

            MostraGrelha(Dificuldade);
        }

        public void MostraGrelha(int dif)
        {
            
            List<CheckBox> buttons = new List<CheckBox>(dificuldade * dificuldade);
            int i = 0;
            


            for (int l = 0; l < dificuldade; l++)
            {
                for (int j = 0; j < dificuldade; j++)
                {
                    CheckBox newButton = new CheckBox();
                    newButton.Click += new EventHandler(button_Click);
                    buttons.Add(newButton);
                    this.Controls.Add(newButton);

                    buttons[i].Appearance = Appearance.Button;
                    buttons[i].AutoSize = false;
                    buttons[i].Height = 30;
                    buttons[i].Width = 30;
                    buttons[i].TabIndex = i;
                    buttons[i].Text = (i + 1).ToString();
                    buttons[i].TextAlign = ContentAlignment.MiddleCenter;
                    buttons[i].Top = 50 * (l + 1);
                    buttons[i].Left = 50 * (j + 1);
                    i++;
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            CheckBox button = sender as CheckBox;
            button.Text = "X";
            button.Enabled = false;
            // identify which button was clicked and perform necessary actions
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dificuldade = int.Parse(comboBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MostraGrelha(Dificuldade);
        }
    }
}
