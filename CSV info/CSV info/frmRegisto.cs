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

        private List<string[]> Registo = new List<string[]>();  //Lista que mantem os dados actuais da ListView para poder fazer filtragem sem ter de ler de novo o ficheiro
        private String RegType = TODOS; // Variavel que diz que tipo de dados o Registo tem de momento, afectado cada vez que o registo é carregado do ficheiro

        public frmRegisto()
        {
            InitializeComponent();
        }
        private void CreateHeader(ListView lst, string[] header)
        {
            lst.Clear();
            foreach (string head in header)
            {
                lst.Columns.Add(head)
                .Width = lst.Width / header.Length;
                
            }
        }
        public void loadlistview(string tipo)
        {
            //Carrega a ListView com os dados da Lista Registo 
            // Variaveis com os Header das Colunas
            string[] HEADCLIENTES = { "NOME", "MORADA", "CONTACTO", "PROFISSÃO" };
            string[] HEADVISITANTES = { "NOME", "CONTACTO", "MOTIVO" };
            string[] HEADTODOS = { "NOME", "MORADA", "CONTACTO", "PROFISSÃO", "MOTIVO" };

            switch (tipo)
            {
                case CLIENTES:
                    CreateHeader(lstRegisto, HEADCLIENTES);

                    foreach (string[] item in Registo)
                    {
                        if (item[0] == CLIENTES) InsertItem(item);
                    }

                    break;
                case VISITANTES:

                    CreateHeader(lstRegisto, HEADVISITANTES);
                    foreach (string[] item in Registo)
                    {
                        if (item[0] == VISITANTES) InsertItem(item);

                    }
                    break;
                case TODOS:
                    CreateHeader(lstRegisto, HEADTODOS);
                    foreach (string[] item in Registo)
                    {
                        InsertItem(item);
                    }

                    break;
                case SORTED:
                    if (cbxMotivo.Text != "" || txtNome.Text != "" || txtProfissao.Text != "")
                    {
                       // Tipo especial que filtra os dados da Lista em função dos campos preenchidos e do tipo de dados que já lá está (RegType)
                        if (RegType == CLIENTES)
                        {
                            CreateHeader(lstRegisto, HEADCLIENTES);
                            foreach (string[] item in Registo)
                            {
                                if ((item[4].Contains(txtProfissao.Text) && txtProfissao.Text != "") || (item[1].Contains(txtNome.Text) && txtNome.Text != "")) InsertItem(item);
                            }
                        }
                        else if (RegType == VISITANTES)
                        {
                            CreateHeader(lstRegisto, HEADVISITANTES);
                            foreach (string[] item in Registo)
                            {
                                if ((item[3].Contains(cbxMotivo.Text) && cbxMotivo.Text != "") || (item[1].Contains(txtNome.Text) && txtNome.Text != "")) InsertItem(item);
                            }
                        }
                        else if (RegType == TODOS)
                        {
                            CreateHeader(lstRegisto, HEADTODOS);
                            foreach (string[] item in Registo)
                            {
                                if (item[0] == CLIENTES && (item[4].Contains(txtProfissao.Text) && txtProfissao.Text != "")) InsertItem(item);
                                if ((item[1].Contains(txtNome.Text) && txtNome.Text != "") || (item[3].Contains(cbxMotivo.Text) && cbxMotivo.Text != "")) InsertItem(item);
                            }
                        }


                    }
                    break;
                default:
                    break;

            }

        } 

        
        private void InsertItem(string[] item)
        {
            ListViewItem lvi = new ListViewItem(item[1]);
            for (int i = 2; i < item.Length; i++)
            {
                lvi.SubItems.Add(item[i]);
            }
            lstRegisto.Items.Add(lvi);
        }
        public List<string[]> ReadCSVFile(string tipo)
        {
            FileStream fs;
            if (!File.Exists(@"csvfile.csv"))
            {
                fs = File.Create(@"csvfile.csv");
                fs.Close();
            }

            fs = File.OpenRead(@"csvfile.csv");
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
            ClearText();
        }

        

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            loadlistview(SORTED);
        }

        private void rbVisitantes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVisitantes.Checked)
            {
                ClearText();
                txtMorada.Enabled = false;
                txtProfissao.Enabled = false;
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
                ClearText();
                txtMorada.Enabled = true;
                txtProfissao.Enabled = true;
                cbxMotivo.Enabled = false;
                Registo.Clear();
                Registo.AddRange(ReadCSVFile(CLIENTES));
                loadlistview(CLIENTES);
            }
        }

        private void ClearText()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType().ToString().Contains("TextBox") || ctrl.GetType().ToString().Contains("ComboBox"))
                {
                    ctrl.Text = "";
                }
            }
        }
        private void frmRegisto_Load(object sender, EventArgs e)
        {
            ClearText();
            btnADD.Enabled = true;
            txtMorada.Enabled = false;
            txtProfissao.Enabled = false;
            cbxMotivo.Enabled = true;
            Registo.Clear();
            Registo.AddRange(ReadCSVFile(VISITANTES));
            loadlistview(VISITANTES);
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                ClearText();
                btnADD.Enabled = false;
                txtMorada.Enabled = true;
                txtProfissao.Enabled = true;
                cbxMotivo.Enabled = true;
                if (Registo.Count == 0 || RegType != TODOS)
                {
                    Registo.Clear();
                    Registo.AddRange(ReadCSVFile(TODOS));
                }
                loadlistview(TODOS);
            }
        }
    }
}
