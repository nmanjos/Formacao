using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculator
{

    public partial class Calculador : Form
    {
        public Stack<string> histf = new Stack<string>();
        public Stack<string> histb = new Stack<string>();
        public string Operador = "";
        public double valor = 0;
        public string sinal = "+";

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
                FazNumero( e.KeyChar.ToString());
            }
        }

        private void FazOperador(string op)
        {
                FazIgual();

            History.Text = History.Text + " " + op;
            Operador = op;

        }
        public void FazNumero(string num)
        {
            histf.Push(Numeric.Text);
            if (Numeric.Text != "0" || Numeric.Text != "-0")
            {
                Numeric.Text = Numeric.Text + num;

            }
            else
            {
                if (num != ",")
                {
                    Numeric.Text = num;
                }
                else
                {
                    Numeric.Text = "0,";
                }


            }
        }
        public void FazIgual()
        {
            if (Operador != "")
            {
                switch (Operador)
                {

                    case "+":
                        valor = valor + double.Parse(Numeric.Text);
                        break;
                    case "-":
                        valor = valor - double.Parse(Numeric.Text);
                        break;
                    case "X":
                        valor = valor * double.Parse( Numeric.Text);
                        break;
                    case "/":
                        valor = valor / double.Parse( Numeric.Text);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                if (Numeric.Text != "0") valor = double.Parse(Numeric.Text);

            }
            
            History.Text = valor.ToString();
            FazClearVal();
            Operador = "";
        }
        public void FazPonto()
        {
            FazNumero(",");
        }
        public void FazUndo()
        {
            if (histf.Count > 0)
            {
                histb.Push(Numeric.Text);
                Numeric.Text = histf.Peek();
                histf.Pop();
            }else
            {
                SystemSounds.Asterisk.Play();
            }

        }
        public void FazRedo()
        {
            if (histb.Count > 0)
            {
                histf.Push(Numeric.Text);
                Numeric.Text = histb.Peek();
                histb.Pop();
            }else
            {
                SystemSounds.Asterisk.Play();
            }
        }
        public void FazClear()
        {
            FazClearVal();
            History.Text = "";
            valor = 0;
        }
        public void FazClearVal()
        {
            Numeric.Text = "0";
            histf.Clear();
            histb.Clear();
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
            FazIgual();
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
            FazClear();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            FazUndo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            FazRedo();
        }

        private void Fraction_Click(object sender, EventArgs e)
        {
            FazPonto();
        }

        private void ClearValBt_Click(object sender, EventArgs e)
        {
            FazClearVal();
        }

        private void ClearBt_Click(object sender, EventArgs e)
        {
            FazClear();
        }

        private void SignalShift_Click(object sender, EventArgs e)
        {
            if(sinal == "+")
            {
                sinal = "-";
                Numeric.Text = sinal + Numeric.Text;
            }
            else
            {
                sinal = "+";
                Numeric.Text = Numeric.Text.Substring(2); 
            }
        }
    }
}
