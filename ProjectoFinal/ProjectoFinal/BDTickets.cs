using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectoFinal.Properties;




namespace ProjectoFinal
{
    class BDTickets : IBDTickets
    {
        private string SERVERNAME = Settings.Default.ServerName;
        private string DBNAME = Settings.Default.Database;
        private string USERNAME = Settings.Default.DBUser;
        private string PASSWORD = Settings.Default.DBPass;
        

        public double CustoMediaTickets()
        {
            throw new NotImplementedException();
        }

        public double CustoTecnicoTickets(int tipo)
        {
            throw new NotImplementedException();
        }

        public double CustoTipoTickets(int tipo)
        {
            throw new NotImplementedException();
        }

        public Colaborador EliminaColaborador()
        {
            throw new NotImplementedException();
        }

        public Colaborador EliminaColaborador(int nif)
        {
            throw new NotImplementedException();
        }

        public Tecnico EliminaTecnico()
        {
            throw new NotImplementedException();
        }

        public Ticket EliminaTicket()
        {
            throw new NotImplementedException();
        }

        public bool InsereColaborador()
        {
            throw new NotImplementedException();
        }

        public bool InsereTecnico()
        {
            throw new NotImplementedException();
        }

        public bool InsereTicket()
        {
            throw new NotImplementedException();
        }

        public bool InsereTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Perfil ProcuraPerfil(int nif)
        {
            throw new NotImplementedException();
        }

        public List<Perfil> ProcuraPerfis()
        {
            throw new NotImplementedException();
        }

        public List<Perfil> ProcuraPerfisTipo(int TIPO)
        {
            throw new NotImplementedException();
        }

        public Ticket ProcuraTicket(int numero)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsEncomendaPendente()
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsPorAssociar()
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsTecnico(int nif)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsTipo(int tipo)
        {
            throw new NotImplementedException();
        }
        private SqlDataReader ProcuraSQL(string Table, string[] Fields, string[,] condition)
        {
            SqlDataReader Reader;


            SqlCommand myCommand = new SqlCommand();

            string qry = "Select ";
            for (int i = 0; i < Fields.Length; i++)
            {
                qry += Fields[i];
                if (i < Fields.Length-1 )
                {
                    qry += ", ";
                }
                else
                {
                    qry += " Where ";
                }
            }
            for (int i = 0; i < Fields.Length; i++)
            {
                myCommand.Parameters.AddWithValue("@" + condition[i, 0], condition[i, 2]); // Condition has 3 columns 0=Field, 1=Operand 2=Value example: Field = Operand 
                if (i != (Fields.Length - 1))
                {
                    qry += condition[i, 0] + " " + = " " + "@" + condition[i, 0] + ","; // Add the condition 
                }
                else
                {
                    qry += Fields[i] + " = " + "@" + Fields[i];
                }
            }
            string SQLstr = "UPDATE" + Table + "SET " + qry + ";";
            myCommand.CommandText = SQLstr;
            myCommand.Connection = OpenConnection(@SERVERNAME, DBNAME, USERNAME, PASSWORD);
            try
            {
                return myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
        }
        private List<object> ProcuraSQL(string[] table, string[] fields, string condition)
        {
            List<object> lst = new List<object>();
            return lst;
        }

        private bool InsereRegisto(string table, string[] fields, string[] values)
        {
            bool result = false;

            return result;
        }
        private bool UpdateRegisto(string Table, string[] Fields, string[] values, string Values)
        {
            bool result = false;

            return result;
        }
        private SqlCommand UpdateRegisto(string Table, string[] Fields, string[] Values)
        {
            SqlCommand result = new SqlCommand();

            if (Fields.Length == Values.Length)  // Validate if Fields and Values have the same number of elements
            {
                SqlCommand myCommand = new SqlCommand();
                string str = "";
                for (int i = 0; i < Fields.Length; i++)
                {
                    myCommand.Parameters.AddWithValue("@" + Fields[i], Values[i]);
                    if (i != (Fields.Length - 1))
                    {
                        str +=  Fields[i] + " = " + "@" + Fields[i] + ",";
                    }
                    else
                    {
                        str += Fields[i] + " = " + "@" + Fields[i];
                    }
                }
                string SQLstr = "UPDATE" + Table + "SET " + str + ";";
                myCommand.CommandText = SQLstr;
                myCommand.Connection = OpenConnection(@SERVERNAME, DBNAME, USERNAME, PASSWORD);
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }



            return result;
        }
        private SqlConnection OpenConnection(string Server, string Database, string username, string password)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=" + Server + ";" +
            "Initial Catalog=" + Database + ";" +
            "User id=" + username + ";" +
            "Password=" + password + ";";
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            return conn;
        }
         
    }
}
