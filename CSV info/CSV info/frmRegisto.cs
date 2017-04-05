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
            List<string[]> RegistoAux = new List<string[]>();
            if (tipo != RegType)
            {

                switch (tipo)
                {
                    case CLIENTES:
                        Registo.AddRange(ReadCSVFile(CLIENTES));
                        break;
                    case VISITANTES:

                        break;
                    case TODOS:

                        break;
                    case SORTED:
                        foreach (string[] item in Registo)
                        {
                            if (RegType == CLIENTES)
                            {
                                if (item[4].Contains(txtProfissaoC.Text))
                                {
                                    RegistoAux.Add(item);
                                }
                            } 
                            
                        }
                        break;
                    default:
                        break;
                }

            }

            foreach (string[] item in Registo)
            {
                for (int i = 0; i < length; i++)
                {

                }
                ListViewItem lvi = new ListViewItem(item[1]);
                lvi.SubItems.Add(item[2]);
                lvi.SubItems.Add(item[3]);
                lvi.SubItems.Add(item[4]);
                lvi.SubItems.Add(item[5]);
                lstRegisto.Items.Add(lvi);
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
                string line = reader.ReadLine();
                string[] values = line.Split(';');
                if (values[0]==VISITANTES) list.Add(values);
            }
            break;
                case CLIENTES:
            while (!reader.EndOfStream)
            {
                //Decidir consoante o tipo os registos que interessam
                string line = reader.ReadLine();
                string[] values = line.Split(';');
                if (values[0] == CLIENTES) list.Add(values);
            }
            break;
                case TODOS:
            while (!reader.EndOfStream)
            {
                //Decidir consoante o tipo os registos que interessam
                string line = reader.ReadLine();
                string[] values = line.Split(';');
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
                cliente[1] = txtNomeC.Text;
                cliente[2] = txtMoradaC.Text;
                cliente[3] = txtContactoC.Text;
                cliente[4] = txtProfissaoC.Text;
                WriteCSVFile(cliente);

            }
            else if (tipo == VISITANTES)
            {
                string[] Visitante = new string[4];
                Visitante[0] = tipo;
                Visitante[1] = txtNomeC.Text;
                Visitante[2] = txtMoradaC.Text;
                Visitante[3] = txtContactoC.Text;
                Visitante[4] = txtProfissaoC.Text;
                WriteCSVFile(Visitante);
            }
            Registo.AddRange(ReadCSVFile(tipo));
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
            if (Registo.Count == 0)
            {
                Registo.AddRange(ReadCSVFile(TODOS));
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }
    }
}
