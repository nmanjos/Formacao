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
using System.Windows.Forms;

namespace ProjectoFinal
{
    class BDTickets : IBDTickets
    {
       
        private string DBNAME = @Settings.Default.Database;
        
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
        /// <summary>
        /// Procura uma só tabela, devolve os campos definidos no segundo array, segundo a condição do terceiro array
        /// ultimo parametro pode ser null, nesse caso devolve todos os registos da tabela!
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Fields"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
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
            }
            if (condition != null)
            {
                qry += " Where ";
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
            }
           
            myCommand.CommandText = qry;
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
        private SqlDataReader ProcuraSQL(string[] Tables,string[,] JoinFields, string[] Fields, string[,] Condition)
        {
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();

            string qry = "SELECT ";
            for (int i = 0; i < Fields.Length; i++)
            {
                qry += Fields[i];
                if (i < Fields.Length - 1)
                {
                    qry += ",";
                }
            }
            qry += " FROM ";
            int joincounter = 0;
            for (int i = 0; i < Tables.Length; i++)
            {
                
                qry += Tables[i];
                if (joincounter > 0)
                {
                    qry += " ON " + JoinFields[joincounter - 1, 0] + " = " + JoinFields[joincounter - 1, 1];
                }
                if (i < Tables.Length - 1)
                {
                    qry += " INNER JOIN ";
                    joincounter++;
                }

            }
            if (Condition != null)
            {
                qry += " WHERE ";
                for (int i = 0; i < Condition.GetLength(0); i++)
                {
                    myCommand.Parameters.AddWithValue("@" + Condition[i, 0], Condition[i, 2]); // Condition has 3 columns 0=Field, 1=Operand 2=Value
                    qry += Condition[i, 0] + " " + Condition[i, 1] + " @" + Condition[i, 0];
                    if (i < (Condition.GetLength(0) - 1))
                    {
                         qry += " AND "; // Add the condition 
                    }
                }

            }
            qry += ";";
            myCommand.CommandText = qry;
            myCommand.Connection = OpenConnection(DBNAME);
            try
            {
                Reader = myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());  // write to app log
                Reader = null;
                myCommand.Connection.Close();
                myCommand.Dispose();


            }
            return Reader;
        }

        private bool InsereRegisto(string Table, string[] Fields, string[] Values)
        {
            bool result = false;

            if (Fields.Length == Values.Length)  // Validate if Fields and Values have the same number of elements
            {
                SqlCommand myCommand = new SqlCommand();
                string fld = "";
                string vlu = "";
                for (int i = 0; i < Fields.Length; i++)
                {
                    if (Values[i] == "True") 
                    {
                        Values[i] = "1";
                    }
                    else if (Values[i] == "False")
                    {
                        Values[i] = "0";
                    }
                    myCommand.Parameters.AddWithValue("@" + Fields[i], Values[i]);
                    if (i != (Fields.Length - 1))
                    {
                        fld += Fields[i] + ",";
                        vlu += "@" + Fields[i] + ",";
                    }
                    else
                    {
                        fld += Fields[i] ;
                        vlu += "@" + Fields[i] ;
                    }
                }
                string SQLstr = "INSERT INTO " + Table + " (" + fld + ") VALUES (" + vlu +  ");";
                myCommand.CommandText = SQLstr;
                myCommand.Connection = OpenConnection(DBNAME);
                try
                {
                    myCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                myCommand.Connection.Close();
                myCommand.Dispose();
            }
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
                MessageBox.Show(e.ToString());
                return null;
            }
            return conn;
        }



        public bool Login(int NIF, string Pass )
        {
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao", "Habilitacoes.Nivel" };
            string[,] Condition = { { "NIF", "=", NIF.ToString() }, { "Senha", "=", Pass } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Nivel" } };
            SqlDataReader Reader =  ProcuraSQL(Tables,JointFields, Fields, Condition);
            if (Reader.HasRows)
            {
                bool is_tec=false;
                Reader.Read();
                
                if (!(Reader.GetValue(5) is DBNull))
                {
                    is_tec = Reader.GetBoolean(5);
                }
                if (is_tec)
                {
                    CurrentUser = new Tecnico();
                    
                    ((Tecnico)CurrentUser).AreaIntre = ProcuraAreas(Reader.GetInt32(0));
                } else
                {
                    CurrentUser = new Colaborador();
                }
                CurrentUser.NIF = Reader.GetInt32(0);
                CurrentUser.Nome = Reader.GetString(2);
                CurrentUser.Senha = Reader.GetString(1);
                 
                CurrentUser.NivelHab = new Habilitacao(Reader.GetString(7), Reader.GetInt32(8));
                Reader.Close();
                Reader = null;
                return true;

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
            return InsereRegisto("Perfil", new string[] { "NIF", "Nome","senha","NivelHab2" }, new string[] { Colab.NIF.ToString(), Colab.Nome.ToString() });
        }
        public Colaborador EliminaColaborador(int NIF)
        {
            throw new NotImplementedException();
        }
        public bool InsereTecnico(Tecnico Colab)
        {
            return InsereRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab", "Is_Admin", "Is_Tec", "Is_Super" }, new string[] { Colab.NIF.ToString(), Colab.Nome, Colab.Senha, Colab.NivelHab.Nivel.ToString(), Colab.Is_Admin.ToString(), "1", "0" });
        }
        public bool InsereTecnico(Tecnico Colab,bool super)
        {
            return InsereRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab", "Is_Admin", "Is_Tec", "Is_Super" }, new string[] { Colab.NIF.ToString(), Colab.Nome, Colab.Senha, Colab.NivelHab.Nivel.ToString(), Colab.Is_Admin.ToString(), "1", super.ToString() });
        }
        public Tecnico EliminaTecnico(int NIF)
        {
            throw new NotImplementedException();
        }
        public bool InsereTicket(Ticket TK)
        {
            return InsereRegisto("Ticket", new string[] { "createdate", "Descricao" }, new string[] { TK.Createdate.ToString(), TK.Description.ToString() });
        }
        public Ticket EliminaTicket(int Id)
        {
            throw new NotImplementedException();
        }
        public Perfil ProcuraPerfil(int nif)
        {
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao", "Habilitacoes.Nivel" };
            string[,] Condition = { { "NIF", "=", nif.ToString() } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Id" } };
            SqlDataReader Reader = ProcuraSQL(Tables, JointFields, Fields, Condition);
            Perfil Perf;
            if (Reader.HasRows)
            {
                bool is_tec = false;
                Reader.Read();

                if (!(Reader.GetValue(5) is DBNull))
                {
                    is_tec = Reader.GetBoolean(5);
                }
                if (is_tec)
                {
                    Perf = new Tecnico();

                    ((Tecnico)Perf).AreaIntre = ProcuraAreas(Reader.GetInt32(0));
                    ((Tecnico)Perf).Is_Admin = Reader.GetBoolean(4);
                }
                else
                {
                    Perf = new Colaborador();
                }
                Perf.NIF = Reader.GetInt32(0);
                Perf.Nome = Reader.GetString(2);
                Perf.Senha = Reader.GetString(1);
                Perf.NivelHab.Nivel = Reader.GetInt32(8);
                Perf.NivelHab.Descr = Reader.GetString(7);
                Reader.Close();
                Reader = null;
                return Perf;

            }
            return null;
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
            string[,] cond = new string[1, 3];
            cond[0, 0] = "Area_Id";
            cond[0, 1] = "=";
            cond[0, 2] = tipo.ToString();

            SqlDataReader Reader = ProcuraSQL("Tickets", new string[] { "ID", "Descricao", "Equipamento", "lastupdate" }, cond);
            List<Ticket> lsttks = new List<Ticket>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Ticket tk = new Ticket();
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    tk.Num = Reader.GetInt32(0);
                    lsttks.Add(tk);
                }
            }

            return lsttks;
        }

        
        public List<Status> CarregaEstados(bool is_Ticket, bool is_request)
        {
            throw new NotImplementedException();
        }

        public bool InsereEstado(Status Estado)
        {
            return InsereRegisto("States", new string[] { "Is_final", "Descricao" }, new string[] { Estado.Is_final.ToString(), Estado.Descr.ToString() });
        }

        public Status EliminaEstado(string Estado)
        {
            throw new NotImplementedException();
        }

        public bool InsereEquipamento(Equipamento Equip)
        {
            return InsereRegisto("Equipamento", new string[] { "Inventcode", "Descricao" }, new string[] { Equip.Inventcode.ToString(), Equip.Descr.ToString() });
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
            return InsereRegisto("Areas", new string[] { "NivelMinimo", "Descricao" }, new string[] { Area.NivelMinimo.ToString(), Area.Descr.ToString() });
        }

        public List<Area> ProcuraAreas()
        {
            throw new NotImplementedException();
        }
        public List<Area> ProcuraAreas(int NIF)
        {
            List<Area> areas = new List<Area>();
            
            SqlDataReader reader = ProcuraSQL(new string[] { "AreaIntre", "Areas" },new string[,] { {"AreaIntre.Area_Id","Areas.Id" } }, new string[] { "Areas.Descricao", "Areas.NivelMinimo" }, new string[,] { { "NIF", "=", NIF.ToString() } });
            if (reader != null)
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        areas.Add(new Area(reader.GetString(0), reader.GetInt32(1)));
                    }
                }
            }
            
            reader.Close();
            reader = null;
            return areas;
        }
        public Area EliminaArea(string Area)
        {
            throw new NotImplementedException();
        }

        public bool InsereHabilitacao(Habilitacao Habilitacao)
        {
            return InsereRegisto("Habilitacoes", new string[] { "Nivel", "Descricao" }, new string[] { Habilitacao.Nivel.ToString(), Habilitacao.Descr.ToString() });
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
            return InsereRegisto("Materiais", new string[] { "partnumber", "price","issoftware","name","supplier" }, new string[] { Material.Partnumber.ToString(), Material.Price.ToString(), Material.Issoftware.ToString(), Material.Descr.ToString(), Material.Supplier.ToString() });

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
           return InsereRegisto("Priority", new string[] { "Nivel", "Descr" }, new string[] { Prioridade.Nivel.ToString(), Prioridade.Descr.ToString() });
        }

        public List<Prioridade> ProcuraPrioridade()
        {
            throw new NotImplementedException();
        }
    }
}
