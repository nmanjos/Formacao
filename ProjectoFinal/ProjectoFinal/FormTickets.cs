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
using System.Reflection;

namespace ProjectoFinal
{
    public partial class FormTickets : Form
    {
        List<Ticket> lTickets;

        private static void LoadlstView(ListView lstv, object[] lstobj)
        {


            ListViewItem lvi = new ListViewItem();
           
            PropertyInfo[] properties = lstobj[0].GetType().GetProperties();
            foreach (PropertyInfo Property in properties)
            {
                lstv.Columns.Add(Property.GetType().ToString());
            }
            foreach (object obj in lstobj)
            {
                foreach (PropertyInfo Property in properties)
                {
                    lvi.SubItems.Add(Property.GetValue(obj).ToString());
                }
                lstv.Items.Add(lvi);
            }
        }
        private void ValidaTab( TabPage Tab)
        {
            Tab.Hide();
            if (Program.TicketDB.CurrentUser != null)
            {
                if (((Tecnico)Program.TicketDB.CurrentUser).Is_Admin) Tab.Show();

            }

        }
    


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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tickets_Form_Load(object sender, EventArgs e)
        {
            if (lTickets != null) LoadlstView(lstTickets,lTickets.ToArray());
            ValidaTab(tabPerfil);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form Addticket = new FormAddTicket();
            Addticket.ShowDialog();
        }

        private void tbMateriais_Click(object sender, EventArgs e)
        {
            LoadAuxs(tbMateriais);
        }
        private void LoadAuxs(TabPage tab)
        {
            switch (tab.Name)
            {
                case "tbMateriais":

                    break;
                case "tbHabilit":

                    break;
                case "tbAreas":

                    break;
                case "tbStates":

                    break;
                case "tbPriority":

                    break;
                default:
                    break;
            }
        }

        private void tbAuxs_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPerfil_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tabPerfil_Enter ");
        }

        private void TicketsTabular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event TicketsTabular_Click ");
        }

        private void tbHabilit_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tbHabilit_Enter");
        }

        private void tabEquipamento_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tabEquipamento_Enter");
        }

        private void tabRequesicoes_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tabRequesicoes_Enter");
        }

        private void tabAuxs_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tabAuxs_Enter");
        }

        private void tabTickets_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You have Raised event tabTickets_Enter");
            //LoadlstView(lstTickets, Program.TicketDB.ProcuraTicketsTipo(1).ToArray());
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstTickets.SelectedItems[0].SubItems[0].ToString());
        }
    }
}
