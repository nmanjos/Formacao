using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CSV_info
{
    public partial class frmRegisto : Form
    {
        
        private const string TODOS = "TODOS";
        private const string CLIENTES = "CLIENTES";
        private const string VISITANTES = "VISITANTES";
        private const string SORTED = "SORTED";

        private List<string[]> Registo = new List<string[]>();
        private String RegType = TODOS;

        public frmRegisto()
        {
            InitializeComponent();
        }

        public void loadlistview(string tipo)
        {

                lstRegisto.Clear();
                switch (tipo)
                {
                    case CLIENTES:
                        lstRegisto.Columns.Add("NOME");
                        lstRegisto.Columns.Add("MORADA");
                        lstRegisto.Columns.Add("CONTACTO");
                        lstRegisto.Columns.Add("PROFISSÃO");
                        foreach (string[] item in Registo)
                        {
                            if (item[0] == CLIENTES)
                            {
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }

                        break;
                    case VISITANTES:

                        lstRegisto.Columns.Add("NOME");
                        lstRegisto.Columns.Add("CONTACTO");
                        lstRegisto.Columns.Add("MOTIVO");
                        foreach (string[] item in Registo)
                        {
                            if (item[0] == VISITANTES)
                            {
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }

                        break;
                    case TODOS:
                        lstRegisto.Columns.Add("NOME");
                        lstRegisto.Columns.Add("MORADA");
                        lstRegisto.Columns.Add("CONTACTO");
                        lstRegisto.Columns.Add("PROFISSÃO");
                        lstRegisto.Columns.Add("MOTIVO");
                        foreach (string[] item in Registo)
                        {
                            if (item[0] == VISITANTES)
                            {
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add("");
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }else if (item[0] == CLIENTES)
                            {
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                        lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }

                        break;
                    case SORTED:

                    if (RegType == CLIENTES)
                    {
                        foreach (string[] item in Registo)
                        {
                            if (item[4].Contains(txtProfissao.Text))
                            {
                                lstRegisto.Clear();
                                lstRegisto.Columns.Add("NOME");
                                lstRegisto.Columns.Add("MORADA");
                                lstRegisto.Columns.Add("CONTACTO");
                                lstRegisto.Columns.Add("PROFISSÃO");
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }
                    }
                    else if (RegType == VISITANTES)
                    {
                        foreach (string[] item in Registo)
                        {
                            if (item[3].Contains(cbxMotivo.Text))
                            {
                                lstRegisto.Clear();
                                lstRegisto.Columns.Add("NOME");
                                lstRegisto.Columns.Add("CONTACTO");
                                lstRegisto.Columns.Add("MOTIVO");
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }
                    }
                    else if (RegType == TODOS)
                    {
                        foreach (string[] item in Registo)
                        {
                            if (item[0].Text = C   item[3].Contains(cbxMotivo.Text) )
                            {
                                lstRegisto.Clear();
                                lstRegisto.Columns.Add("NOME");
                                lstRegisto.Columns.Add("MORADA");
                                lstRegisto.Columns.Add("CONTACTO");
                                lstRegisto.Columns.Add("PROFISSÃO");
                                lstRegisto.Columns.Add("MOTIVO");
                                ListViewItem lvi = new ListViewItem(item[1]);
                                for (int i = 2; i < item.Length; i++)
                                {
                                    lvi.SubItems.Add(item[i]);
                                }
                                lstRegisto.Items.Add(lvi);
                            }
                        }

                    }

                    break;

                    default:
                    break;
                }

            

        }
        public List<string[]> ReadCSVFile(string tipo)
        {
           
            FileStream fs = File.OpenRead(@"csvfile.csv");
            StreamReader reader = new StreamReader(fs);

            List<string[]> list = new List<string[]>();
            switch (tipo)
            {
                case VISITANTES:
            while (!reader.EndOfStream)
            {
                        //Decidir consoante o tipo os registos que interessam
                        string[] values = reader.ReadLine().Split(';');
                        if (values[0]==VISITANTES) list.Add(values);
            }
            break;
                case CLIENTES:
            while (!reader.EndOfStream)
            {
                        //Decidir consoante o tipo os registos que interessam
                        string[] values = reader.ReadLine().Split(';');
                        if (values[0] == CLIENTES) list.Add(values);
            }
            break;
                case TODOS:
            while (!reader.EndOfStream)
            {
               // Carrega todos
                
                string[] values = reader.ReadLine().Split(';');
                list.Add(values);
            }
            break;
                default:
                    break;
            }
            reader.Close();
            fs.Close();
            RegType = tipo;
            return list;
        }


        public void WriteRecord(string tipo)
        {
            
            if (tipo == CLIENTES)
            {
                string[] cliente = new string[5];
                cliente[0] = tipo;
                cliente[1] = txtNome.Text;
                cliente[2] = txtMorada.Text;
                cliente[3] = txtContacto.Text;
                cliente[4] = txtProfissao.Text;
                WriteCSVFile(cliente);

            }
            else if (tipo == VISITANTES)
            {
                string[] Visitante = new string[4];
                Visitante[0] = tipo;
                Visitante[1] = txtNome.Text;
                Visitante[2] = txtContacto.Text;
                Visitante[3] = cbxMotivo.Text;
                WriteCSVFile(Visitante);
            }
            Registo.Clear();
        }
        public void WriteCSVFile(string[] dados)
        {

            FileStream fs = new FileStream(@"csvfile.csv", FileMode.Append, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(fs);
            string linha = "";
            for (int i = 0; i < dados.Length; i++)
            {
                if (i < dados.Length - 1)
                {
                    linha = linha + dados[i] + ";";
                }
                else
                {
                    linha = linha + dados[i];
                }
            }
            writer.WriteLine(linha);
            writer.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (Registo.Count == 0 || RegType != TODOS )
            {
                Registo.Clear();
                Registo.AddRange(ReadCSVFile(TODOS));
            }
            loadlistview(TODOS);

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (rbClientes.Checked)
                {
                    WriteRecord(CLIENTES);
                    Registo.Clear();
                    Registo.AddRange(ReadCSVFile(CLIENTES));
                    loadlistview(CLIENTES);
                }
                else if (rbVisitantes.Checked)
                {
                    WriteRecord(VISITANTES);
                    Registo.Clear();
                    Registo.AddRange(ReadCSVFile(VISITANTES));
                    loadlistview(VISITANTES);
                }
            }else
            {
                SystemSounds.Beep.Play();
            }
            txtNome.Text = "";
            txtMorada.Text = "";
            txtContacto.Text = "";
            txtProfissao.Text = "";
            cbxMotivo.Text = "";
        }

        //private void btnADDV_Click(object sender, EventArgs e)
        //{

        //}

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            loadlistview(SORTED);
        }

        private void rbVisitantes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVisitantes.Checked)
            {
                lblMorada.Enabled = false;
                lblProfissao.Enabled = false;
                txtMorada.Enabled = false;
                txtProfissao.Enabled = false;
                lblMotivo.Enabled = true;
                cbxMotivo.Enabled = true;
                Registo.Clear();
                Registo.AddRange(ReadCSVFile(VISITANTES));
                loadlistview(VISITANTES);
            }
        }

        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClientes.Checked)
            {
                lblMorada.Enabled = true;
                lblProfissao.Enabled = true;
                txtMorada.Enabled = true;
                txtProfissao.Enabled = true;
                lblMotivo.Enabled = false;
                cbxMotivo.Enabled = false;
                Registo.Clear();
                Registo.AddRange(ReadCSVFile(CLIENTES));
                loadlistview(CLIENTES);
            }
        }

        private void frmRegisto_Load(object sender, EventArgs e)
        {
            lblMorada.Enabled = false;
            lblProfissao.Enabled = false;
            txtMorada.Enabled = false;
            txtProfissao.Enabled = false;
            lblMotivo.Enabled = true;
            cbxMotivo.Enabled = true;
            Registo.Clear();
            Registo.AddRange(ReadCSVFile(VISITANTES));
            loadlistview(VISITANTES);
        }
    }
}
