using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProjectoFinal
{
    public partial class FormTickets : Form
    {
        List<Ticket> Tickets;
        public FormTickets()
        {
            InitializeComponent();
            Form Login = new FormLogin();
            Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tickets_Form_Load(object sender, EventArgs e)
        {
            Tickets = ProcuraTicketsTipo()
            lstTickets.Items.AddRange()
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form Addticket = new FormAddTicket();
            Addticket.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
