using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectoFinal.Properties;
using Microsoft.Win32;
using System.IO;

namespace ProjectoFinal
{
    class BDTickets : IBDTickets
    {
       
        private string DBNAME = Settings.Default.Database;
        
        public Perfil CurrentUser;

        /// <summary>
        /// Meio de Autenticar o user na aplicação, o Programa tem os dados do utilizador para fazer as suas decisões sobre o interface
        /// </summary>
        /// <returns>Bool -> User Autenticou</returns>
        ///

        private void LoadLinked(object obj, string table, int id)
        {
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();
            string SQLstr = "Select * from " + table + " Where Id = @Id";
            myCommand.Parameters.AddWithValue("@Id", id); // Condition has 3 columns 0=Field, 1=Operand 2=Value example: Field = Operand 
            myCommand.CommandText = SQLstr;
            myCommand.Connection = OpenConnection(DBNAME);
            try
            {
                Reader = myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());  // write to app log
                Reader = null;
            }
            if (Reader.HasRows)
            {
                Reader.Read();

            }
            myCommand.Connection.Close();
            myCommand.Dispose();

        }
        private SqlDataReader ProcuraSQL(string Table, string[] Fields, string[,] condition)
        {
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();

            string qry = "Select ";
            for (int i = 0; i < Fields.Length; i++)
            {
                qry += Fields[i];
                if (i < Fields.Length - 1)
                {
                    qry += ", ";
                }
                else
                {
                    qry += " Where ";
                }
            }
            for (int i = 0; i < condition.GetLength(0); i++)
            {
                myCommand.Parameters.AddWithValue("@" + condition[i, 0], condition[i, 2]); // Condition has 3 columns 0=Field, 1=Operand 2=Value example: Field = Operand 
                if (i != (condition.GetLength(0) - 1))
                {
                    qry += condition[i, 0] + " " + condition[i, 1] + " @" + condition[i, 2] + ","; // Add the condition 
                }
                else
                {
                    qry += Fields[i] + " = " + "@" + Fields[i];
                }
            }
            string SQLstr = "UPDATE" + Table + "SET " + qry + ";";
            myCommand.CommandText = SQLstr;
            myCommand.Connection = OpenConnection(DBNAME);
            try
            {
                Reader = myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());  // write to app log
                Reader = null;
                myCommand.Connection.Close();
                myCommand.Dispose();


            }
            return Reader;
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
                        str += Fields[i] + " = " + "@" + Fields[i] + ",";
                    }
                    else
                    {
                        str += Fields[i] + " = " + "@" + Fields[i];
                    }
                }
                string SQLstr = "UPDATE" + Table + "SET " + str + ";";
                myCommand.CommandText = SQLstr;
                myCommand.Connection = OpenConnection(DBNAME);
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
        private SqlConnection OpenConnection(string Database)
        {


            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\" + Database + ";Integrated Security = True");


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



        public bool Login(int NIF, string Pass )
        {
            
            string[] Fields = { "NIF", "Senha" };
            string[,] Condition = { { "NIF", "=", NIF.ToString() }, { "Senha", "=", Pass } };
            SqlDataReader Reader =  ProcuraSQL( "Perfis", Fields, Condition);
            if (Reader.HasRows)
            {

                Reader.Read();
                if (Reader.GetBoolean(5)) CurrentUser = new Tecnico();


                CurrentUser.NIF = Reader.GetInt32(0);
                CurrentUser.Nome = Reader.GetString(0);
                CurrentUser.Senha = Reader.GetString(0);
                CurrentUser.NivelHab.Nivel = Reader.GetInt32(0);


            }   
            return false;
        }
        public Perfil GetCurrentUser()
        {
            return CurrentUser;
        }
        /// <summary>
        /// Devolve o Valor médio do Custo de todos os Tickets Fechados
        /// </summary>
        /// <returns></returns>
        public double CustoMediaTickets()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Devolve o Valor médio do Custo de todos os Tickets Fechados por Técnico
        /// </summary>
        /// <returns></returns>
        public double CustoMedioTecnicoTickets(int tipo)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Devolve o Valor médio do Custo de todos os Tickets Fechados por Tipo de Ticket
        /// </summary>
        /// <returns></returns>
        public double CustoMediaTipoTickets(int tipo)
        {
            throw new NotImplementedException();
        }
        public bool InsereColaborador(Colaborador Colab)
        {
            throw new NotImplementedException();
        }
        public Colaborador EliminaColaborador(int NIF)
        {
            throw new NotImplementedException();
        }
        public bool InsereTecnico(Tecnico Colab)
        {
            throw new NotImplementedException();
        }
        public Tecnico EliminaTecnico(int NIF)
        {
            throw new NotImplementedException();
        }
        public bool InsereTicket(int Id)
        {
            throw new NotImplementedException();
        }
        public Ticket EliminaTicket(int Id)
        {
            throw new NotImplementedException();
        }
        public Perfil ProcuraPerfil(int nif)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Mostra todos os Perfis
        /// </summary>
        /// <returns></returns>
        public List<Perfil> ProcuraPerfis()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Mostra Perfis por Tipo,corre query que filtra por tipo, ou seja: is_Tecnico =  True mostra todos os Técnicos, mas pode mostrar tambem os técnicos e os Admin se is_admin for True
        /// Funcão especialmente util para usar em combinação com checkboxs
        /// </summary>
        /// <param name="is_Tecnico">Se False mostra Colaboradores</param>
        /// <param name="is_Admin">Se False mostra Tecnicos</param>
        /// <returns>Lista de Perfis</returns>
        public List<Perfil> ProcuraPerfisTipo(bool is_Tecnico, bool is_Admin)
        {
            throw new NotImplementedException();
        }

        public Ticket ProcuraTicket(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ProcuraTicketsEncomendaPendente()
        {
            throw new NotImplementedException();
        }
        public List<Ticket> ProcuraTicketsPorEstado(String Estado)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Esta função usa a ProcuraTicketsPorEstado é mantida para compatibilidade com versões antigas do interface
        /// O estado Por Associar é Hardcoded na base de dados devido a isso 
        /// </summary>
        /// <returns></returns>
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

        public bool Login()
        {
            throw new NotImplementedException();
        }

        public List<Status> CarregaEstados(bool is_Ticket, bool is_request)
        {
            throw new NotImplementedException();
        }

        public bool InsereEstado(Status Estado)
        {
            throw new NotImplementedException();
        }

        public Status EliminaEstado(string Estado)
        {
            throw new NotImplementedException();
        }

        public bool InsereEquipamento(Equipamento Equip)
        {
            throw new NotImplementedException();
        }

        public List<Equipamento> ProcuraEquipamentos()
        {
            throw new NotImplementedException();
        }

        public Equipamento ProcuraEquipamento(string InventCode)
        {
            throw new NotImplementedException();
        }

        public Equipamento EliminaEquipamento(string InventCode)
        {
            throw new NotImplementedException();
        }

        public bool InsereArea(Area Area)
        {
            throw new NotImplementedException();
        }

        public List<Area> ProcuraAreas()
        {
            throw new NotImplementedException();
        }

        public Area EliminaArea(string Area)
        {
            throw new NotImplementedException();
        }

        public bool InsereHabilitacao(Habilitacao Habilitacao)
        {
            throw new NotImplementedException();
        }

        public List<Habilitacao> ProcuraHabilitacoes()
        {
            throw new NotImplementedException();
        }

        public Area EliminaHabilitacao(string Habilitacao)
        {
            throw new NotImplementedException();
        }

        public bool InsereMaterial(Material Material)
        {
            throw new NotImplementedException();
        }

        public List<Material> ProcuraMaterial()
        {
            throw new NotImplementedException();
        }

        public Area EliminaMaterial(string Material)
        {
            throw new NotImplementedException();
        }
        public Prioridade EliminaPrioridade(string Prioridade)
        {
            throw new NotImplementedException();
        }

        public bool InserePrioridade(Prioridade Prioridade)
        {
            throw new NotImplementedException();
        }

        public List<Prioridade> ProcuraPrioridade()
        {
            throw new NotImplementedException();
        }
    }
}
