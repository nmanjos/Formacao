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
           // Program.TicketDB.Login(int.Parse(txtUsername.Text),txtPass.Text);

        }
    }
}
