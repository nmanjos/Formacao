﻿using System;
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
        string EditMode;     // variavel para controlar em que estado está o ecran "New" para novo Registo, "Edit" para modo de Actualização, qualquer outro para não fazer alterações. 

        private static void LoadlstView(ListView lstv, object[] lstobj)
        {
            if (lstobj.Length > 0)
            {
                lstv.Clear();
                lstv.View = View.Details;
                PropertyInfo[] properties = lstobj[0].GetType().GetProperties();
                foreach (PropertyInfo Property in properties)
                {
                    lstv.Columns.Add(Property.Name.Trim())
                        .Width = lstv.Width / properties.Length;
                }
                foreach (object obj in lstobj)
                {
                    ListViewItem lvi = null;
                    for (int i = 0; i < properties.Length; i++)
                    {
                        if (i == 0)
                        {
                            lvi = new ListViewItem(properties[i].GetValue(obj).ToString().Trim());
                        }
                        else
                        {
                            lvi.SubItems.Add(properties[i].GetValue(obj).ToString().Trim());
                        }
                    }
                    lstv.Items.Add(lvi);
                }
                lstv.Refresh();
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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tickets_Form_Load(object sender, EventArgs e)
        {
            if (Program.TicketDB.CurrentUser != null) this.Text += " - " + Program.TicketDB.CurrentUser.Nome;
            this.Update();
            if (lTickets != null) LoadlstView(lstTickets,lTickets.ToArray());
            ValidaTab(tabPerfil);
            Application.DoEvents();
            if (Program.TicketDB.CurrentUser == null)
            {
                Application.Exit();
            }

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
                    LoadlstView(lstMateriais, Program.TicketDB.ProcuraMaterial().ToArray());
                    break;
                case "tbHabilit":
                   LoadlstView(lstHabilit, Program.TicketDB.ProcuraHabilitacoes().ToArray());
                    break;
                case "tbAreas":
                    LoadlstView(lstAreas, Program.TicketDB.ProcuraAreas().ToArray());
                    
                    break;
                case "tbStates":
                    List<Status> Estados = Program.TicketDB.ProcuraEstados(true, true);
                    if (Estados.Count() != 0)
                    {
                        LoadlstView(lstStates, Estados.ToArray());
                    }else
                    {
                        StatusBar.Text = Program.TicketDB.GetError();
                    }
                    
                    break;
                case "tbPriority":
              //      LoadlstView(lstMateriais, Program.TicketDB.ProcuraMaterial().ToArray());
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
            List<Habilitacao> HAbilits = Program.TicketDB.ProcuraHabilitacoes();
            foreach (Habilitacao habilit in HAbilits)
            {
                cbxPerfilHabilit.Items.Add(habilit.ToString());
            }
            LoadlstView(lstPerfil, Program.TicketDB.ProcuraPerfis().ToArray());
        }

        private void TicketsTabular_Click(object sender, EventArgs e)
        {
           
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
            List<Ticket> TKs = Program.TicketDB.ProcuraTicketsTipo(1);
            if (TKs.Count() != 0)
            {
                LoadlstView(lstStates, TKs.ToArray());
            }
            else
            {
                StatusBar.Text = Program.TicketDB.GetError();
            }
            // LoadlstView(lstTickets, Program.TicketDB.ProcuraTicketsTipo(1).ToArray());
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstTickets.SelectedItems[0].SubItems[0].ToString());
        }

        private void tbMateriais_Enter(object sender, EventArgs e)
        {
            LoadAuxs(tbMateriais);
        }

        private void tbStates_Enter(object sender, EventArgs e)
        {
            LoadAuxs(tbStates);
        }

        private void tabPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfilNovo_Click(object sender, EventArgs e)
        {
            EditMode = "New";
            txtPerfilNIF.Text = "";
            txtPerfilNome.Text = "";
            txtPerfilSenha.Text = "";
            lsbAreasIntre.Items.Clear();
            lsbAreas.Items.AddRange(Program.TicketDB.ProcuraAreas().ToArray());
        }

        private void btnPerfilSave_Click(object sender, EventArgs e)
        {
            if (EditMode == "New" )
            {
                Habilitacao habilit = new Habilitacao();
                habilit.Nivel = int.Parse(cbxPerfilHabilit.Text.Split('-')[0]);
                habilit.Descr = cbxPerfilHabilit.Text.Split('-')[1].Trim();
                if (chkIsTec.Checked)
                {

                    List<Area> AreasIntre = new List<Area>();
                    foreach (object item in lsbAreasIntre.Items)
                    {
                        AreasIntre.Add(new Area(item.ToString()));
                    }
                    
                    Program.TicketDB.InsereTecnico(new Tecnico(txtPerfilNome.Text, int.Parse(txtPerfilNIF.Text), txtPerfilSenha.Text, habilit, AreasIntre, chkIsAdmin.Checked,false));
                }
                else
                {
                    Program.TicketDB.InsereColaborador(new Colaborador(txtPerfilNome.Text, int.Parse(txtPerfilNIF.Text), txtPerfilSenha.Text, habilit));
                }
                
            }
        }

        private void btnAreaAdd_Click(object sender, EventArgs e)
        {
            
            foreach (object item in lsbAreas.SelectedItems)
            {
                lsbAreasIntre.Items.Add(item);
            }
            while (lsbAreas.SelectedItems.Count > 0)
            {
                lsbAreas.Items.Remove(lsbAreas.SelectedItems[0]);
            }
            
        }

        private void btnAreaDel_Click(object sender, EventArgs e)
        {
            foreach (object item in lsbAreasIntre.SelectedItems)
            {
                lsbAreas.Items.Add(item);
            }
            while (lsbAreasIntre.SelectedItems.Count > 0)
            {
                lsbAreasIntre.Items.Remove(lsbAreasIntre.SelectedItems[0]);
            }
        }

        private void lsbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAreas_Enter(object sender, EventArgs e)
        {
            LoadAuxs(tbAreas);
        }

        private void tabTickets_Click(object sender, EventArgs e)
        {

        }
    }
}
