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
    public partial class FormAddTicket : Form
    {
        public FormAddTicket()
        {
            InitializeComponent();
            
        }

        private void addTicket_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Program.TicketDB.CurrentUser.Nome;
            this.Update();

            List<Area> Areas = Program.TicketDB.ProcuraAreas();
            foreach (Area Area in Areas)
            {
                cbxTAvaria.Items.Add(Area.ToString());
            }
            Program.TicketDB.ProcuraPerfis();

            List<Prioridade> Prioridades = Program.TicketDB.ProcuraPrioridade();
            foreach (Prioridade Prio in Prioridades)
            {
                cbxPrioridade.Items.Add(Prio.ToString());
            }
            Program.TicketDB.ProcuraPerfis();

            List<Equipamento> Equipamentos = Program.TicketDB.ProcuraEquipamentos();
            foreach (Equipamento Equip in Equipamentos)
            {
                cbxEquipamento.Items.Add(Equip.ToString());
            }
            Program.TicketDB.ProcuraPerfis();


        }
        private void GravaTicket()
        {
            Ticket TK = new Ticket();
            Equipamento Equip = new Equipamento();
            TK.Num = 0;
            TK.Description = rtxDescr.Text;
            TK.Createdate = DateTime.Now;
            TK.Areaintre = new Area(cbxTAvaria.Text);
            Equip.Inventcode = cbxEquipamento.Text.Split('-')[0].Trim() ;
            TK.Equipamento = Equip;

            if (Program.TicketDB.InsereTicket(TK))
            {
                MessageBox.Show("Ticket Inserido");
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
