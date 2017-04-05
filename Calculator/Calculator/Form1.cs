using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Calculador : Form
    {
        public Stack<string> histf = new Stack<string>();
        public Stack<string> histb = new Stack<string>();
        public string Operador = "";
        public double valor = 0;

        public bool nonNumberEntered = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)

              
        {
            // Initialize the flag to false.
           

            // Determine whether the keystroke is a number from the top of the keyboard.

            
            
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift) {
                nonNumberEntered = true;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
            else
            {
                Numeric.Text = Numeric.Text + e.KeyChar.ToString();
            }
        }

        private void FazOperador(string op)
        {
            switch (op)
            {
                case "+":
                    if (Operador != "")
                    {
                        valor = valor + double.Parse(Numeric.Text);

                    }
                    Operador = op;
                    History.Text = Numeric.Text + " " + op;
                    Numeric.Text = "";

                    break;
                default:
                    break;
            }
        }
        public void FazNumero(string num)
        {

        }
        public void FazIgual()
        {

        }
        public void FazPonto()
        {

        }
        public void FazUndu()
        {

        }
        public void FazRedo()
        {

        }

        public Calculador()
        {
            InitializeComponent();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{

        //}

        //private void button11_Click(object sender, EventArgs e)
        //{

        //}

        //private void button9_Click(object sender, EventArgs e)
        //{

        //}

        private void EqualBt_Click(object sender, EventArgs e)
        {

        }

        private void Calculador_Load(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {

        }

        private void Numeric_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Button numero = sender as Button;
            FazNumero(numero.Text);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button ope = sender as Button;
            FazOperador(ope.Text);
        }

        private void ONOFF_Click(object sender, EventArgs e)
        {
            Numeric.Text = "";
            History.Text = "";
            histf.Clear();
            histb.Clear();

        }
    }
}
