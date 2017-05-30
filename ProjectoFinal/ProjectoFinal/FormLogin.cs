using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectoFinal
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Program.TicketDB.Login(int.Parse(txtUsername.Text), txtPass.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("There was an error authenticating your user, try again or close the app", "AUTHENTICATION ERROR");
            }

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }
    }
}
