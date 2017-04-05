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
    public partial class Form1 : Form
    {

        private const string TODOS = "TODOS";
        private const string CLIENTES = "CLIENTES";
        private const string VISITANTES = "VISITANTES";

        public Form1()
        {
            InitializeComponent();
        }

        public List<string[]> ReadCSVFile(string tipo)
        {

            FileStream fs = File.OpenRead(@"csvfile.csv");
            StreamReader reader = new StreamReader(fs);
            
            List<string[]> list = new List<string[]>();

            while (!reader.EndOfStream)
            {   
                //Decidir consoante o tipo os registos que interessam
                string line = reader.ReadLine();
                string[] values = line.Split(';');
                list.Add(values);
            }
            reader.Close();
            fs.Close();
            return list;
        }
        public void WriteCSVFile(string nome, string morada, string contacto, string profissao)
        {

            FileStream fs = new FileStream(@"csvfile.csv", FileMode.Append, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("{0};{1};{2};{3}", nome,morada,contacto, profissao);
            writer.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtClientes.Text = ReadCSVFile(null)[0][0];
            foreach (string[] item in ReadCSVFile(null))
            {

            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }
    }
}
