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
using System.Reflection;

namespace ProjectoFinal
{
    class BDTickets : IBDTickets
    {
        
        private string DBNAME = @Settings.Default.Database;

        public Perfil CurrentUser;
        private Stack<string> Errors = new Stack<string>();

        /// <summary>
        /// Meio de Autenticar o user na aplicação, o Programa tem os dados do utilizador para fazer as suas decisões sobre o interface
        /// </summary>
        /// <returns>Bool -> User Autenticou</returns>
        ///
        public string GetError()
        {
            string error = "";
            if (Errors.Count() > 0)

            {
                error = Errors.Pop();
                Errors.Clear();
            }
            return error;
        }
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
                Errors.Push(e.Message);  // write to app log
                Reader = null;
            }
            if (Reader.HasRows)
            {
                Reader.Read();

            }
            myCommand.Connection.Close();
            myCommand.Dispose();

        }
        private SqlDataReader ProcuraSQL(string Table, string[] Fields, List<string[]> condition)
        {
            int i = condition.Count();
            int j = condition[0].Length;
            string[,] cond = new string[i,j];
            

            for (int s = 0; s < i; s++)
            {
                for (int k = 0; k < j; k++)
                {
                    cond[s, k] = condition[s][k];
                }
            }
            return ProcuraSQL(Table, Fields, cond);
        }

        private SqlDataReader ProcuraSQL(string Table, string[] Fields)
        {
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();

            string qry = "SELECT ";
            if (Fields != null)
            {
                for (int i = 0; i < Fields.Length; i++)
                {
                    qry += Fields[i];
                    if (i < Fields.Length - 1)
                    {
                        qry += ", ";
                    }
                }
            }
            else
            {
                qry += "*";
            }
            qry += " FROM " + Table;
            
            qry += ";";
            myCommand.CommandText = qry;
            myCommand.Connection = OpenConnection(DBNAME);
            try
            {
                Reader = myCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Errors.Push(e.Message);  // write to app log
                Reader = null;
                myCommand.Connection.Close();
                myCommand.Dispose();


            }
            return Reader;
        }
        /// <summary>
        /// Procura uma só tabela, devolve os campos definidos no segundo array, segundo a condição do terceiro array
        /// o unico parametro que não poder ser null é o primeiro, nesse caso devolve todos os registos da tabela!
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Fields"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        private SqlDataReader ProcuraSQL(string Table, string[] Fields, string[,] condition)
        {
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();

            string qry = "SELECT ";
            if (Fields != null)
            {
                for (int i = 0; i < Fields.Length; i++)
                {
                    qry += Fields[i];
                    if (i < Fields.Length - 1)
                    {
                        qry += ", ";
                    }
                }
            }
            else
            {
                qry += "*";
            }
            qry += " FROM " + Table;
            if (condition != null)
            {
                qry += " WHERE ";
                for (int i = 0; i < condition.GetLength(0); i++)
                {

                    myCommand.Parameters.AddWithValue("@" + condition[i, 0], condition[i, 2]);// Condition has 3 columns 0=Field, 1=Operand 2=Value example: Field = Operand 
                    qry += condition[i, 0] + " " + condition[i, 1] + " @" + condition[i, 0];
                    if (i != (condition.GetLength(0) - 1))
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
                Errors.Push(e.Message);  // write to app log
                Reader = null;
                myCommand.Connection.Close();
                myCommand.Dispose();


            }
            return Reader;
        }
        private bool RecExists(string Table, string FieldIn, string condval)
        {
            SqlDataReader Reader = ProcuraSQL(Table, new string[] { FieldIn }, new string[,] { { FieldIn, "=", condval } });
            bool result = Reader.HasRows;
            Reader.Close();
            return result;
        }
        private int GetID(string Table, string FieldIn, string FieldOut, string condval)
        {
            SqlDataReader Reader = ProcuraSQL(Table, new string[] { FieldOut }, new string[,] { { FieldIn, "=", condval } });
            int result = 0;
            if (Reader.HasRows)
            {
                Reader.Read();
                result = Reader.GetInt32(0);
            }
            Reader.Close();
            return result;
        }
        private SqlDataReader ProcuraSQL(string[] Tables, string[,] JoinFields, string[] Fields, string[,] Condition)
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
                    
                    myCommand.Parameters.AddWithValue("@" + Condition[i, 0].Replace(".", ""), Condition[i, 2]); // Condition has 3 columns 0=Field, 1=Operand 2=Value
                    qry += Condition[i, 0] + " " + Condition[i, 1] + " @" + Condition[i, 0].Replace(".", "");
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
                Errors.Push(e.Message);   // write to app log
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
                        fld += Fields[i];
                        vlu += "@" + Fields[i];
                    }
                }
                string SQLstr = "INSERT INTO " + Table + " (" + fld + ") VALUES (" + vlu + ");";
                myCommand.CommandText = SQLstr;
                myCommand.Connection = OpenConnection(DBNAME);
                try
                {
                    myCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    Errors.Push(e.Message);
                }
                myCommand.Connection.Close();
                myCommand.Dispose();
            }
            return result;
        }
        private bool DeleteRegisto(string Table, string[,] Condition)
        {
            bool result = false;
            SqlDataReader Reader;
            SqlCommand myCommand = new SqlCommand();
            string qry = "SELECT ";
            qry += Table;


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
                result = true;
            }
            catch (Exception e)
            {
                Errors.Push(e.Message);  // write to app log
                Reader = null;
                myCommand.Connection.Close();
                myCommand.Dispose();


            }
            return result;
        }
        private bool UpdateRegisto(string Table, string[] Fields, string[] Values, string[,] Condition)
        {
            bool result = false;

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
                if (Condition != null)
                {
                    string qry = " WHERE ";
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
                string SQLstr = "UPDATE" + Table + "SET " + str + ";";
                myCommand.CommandText = SQLstr;
                myCommand.Connection = OpenConnection(DBNAME);
                try
                {
                    myCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    Errors.Push(e.Message);
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
                Errors.Push(e.Message);
                return null;
            }
            return conn;
        }



        public bool Login(int NIF, string Pass)
        {
            bool result = false;
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao", "Habilitacoes.Nivel" };
            string[,] Condition = { { "NIF", "=", NIF.ToString() }, { "Senha", "=", Pass } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Nivel" } };
            SqlDataReader Reader = ProcuraSQL(Tables, JointFields, Fields, Condition);
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
                    CurrentUser = new Tecnico();

                    ((Tecnico)CurrentUser).AreaIntre = ProcuraAreas(Reader.GetInt32(0));
                }
                else
                {
                    CurrentUser = new Colaborador();
                }
                CurrentUser.NIF = Reader.GetInt32(0);
                CurrentUser.Nome = Reader.GetString(2);
                CurrentUser.Senha = Reader.GetString(1);

                CurrentUser.NivelHab = new Habilitacao(Reader.GetString(7), Reader.GetInt32(8));
                Reader.Close();
                Reader = null;
                result = true;

            }
            return result;
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
            bool result = false;
            if (RecExists("Perfil", "NIF", Colab.NIF.ToString())) // se o registo já existe ? Actualiza em vez de Inserir
            {
                result = UpdateRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab" }, new string[] { Colab.NIF.ToString(), Colab.Nome, Colab.Senha, Colab.NivelHab.Nivel.ToString() }, new string[,] { { "NIF", "=", Colab.NIF.ToString() } });


            }
            else
            {
                result = InsereRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab" }, new string[] { Colab.NIF.ToString(), Colab.Nome.ToString(), Colab.Senha.ToString(), Colab.NivelHab.Nivel.ToString() });
            }



            return result;
        }
        public Colaborador EliminaColaborador(int NIF)
        {
            Colaborador Colab = (Colaborador)ProcuraPerfil(NIF);
            DeleteRegisto("Perfis", new string[,] { { "NIF", "=", NIF.ToString() } });
            return Colab;
        }
        public bool InsereTecnico(Tecnico Colab)
        {
            bool result = false;
            if (RecExists("Perfil", "NIF", Colab.NIF.ToString())) // se o registo já existe ? Actualiza em vez de Inserir
            {
                result = UpdateRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab", "Is_Admin", "Is_Tec", "Is_Super" }, new string[] { Colab.NIF.ToString(), Colab.Nome, Colab.Senha, Colab.NivelHab.Nivel.ToString(), Colab.Is_Admin.ToString(), "1", Colab.Is_Super.ToString() }, new string[,] { { "NIF", "=", Colab.NIF.ToString() } });
                if (result)
                {
                    foreach (Area area in Colab.AreaIntre)
                    {
                        int AreaID = GetID("Areas", "Descricao", "Id", area.Descr);
                        result = UpdateRegisto("AreaIntre", new string[] { "NIF", "Aread_ID" }, new string[] { Colab.NIF.ToString(), AreaID.ToString() }, new string[,] { { "NIF", "=", Colab.NIF.ToString() }, { "Aread_ID", "=", AreaID.ToString() } });
                    }
                }

            }
            else
            {
                result = InsereRegisto("Perfil", new string[] { "NIF", "Nome", "senha", "NivelHab", "Is_Admin", "Is_Tec", "Is_Super" }, new string[] { Colab.NIF.ToString(), Colab.Nome, Colab.Senha, Colab.NivelHab.Nivel.ToString(), Colab.Is_Admin.ToString(), "1", Colab.Is_Super.ToString() });
                if (result)
                {
                    foreach (Area area in Colab.AreaIntre)
                    {
                        result = InsereRegisto("AreaIntre", new string[] { "NIF", "Aread_ID" }, new string[] { Colab.NIF.ToString(), GetID("Areas", "Descricao", "Id", area.Descr).ToString() });
                    }
                }
            }
            return result;
        }

        public Tecnico EliminaTecnico(int NIF)
        {
            Tecnico Colab = (Tecnico)ProcuraPerfil(NIF);
            DeleteRegisto("Perfis", new string[,] { { "NIF", "=", NIF.ToString() } });
            return Colab;
        }
        private Status GetState(string Table, string record)
        {
            SqlDataReader Reader = ProcuraSQL(Table, new string[] { "State" }, new string[,] { { "Id", "=", record } });
            int result = 0;
            Status State = new Status();
            if (Reader.HasRows)
            {
                Reader.Read();
                result = Reader.GetInt32(0);
            }
            Reader.Close();
            Reader = ProcuraSQL("States", new string[] { "Name", "isFinalState", "isRejectState", "is_Ticket", "is_Request" }, new string[,] { { "Id", "=", result.ToString() } });

            if (Reader.HasRows)
            {
                Reader.Read();
                State.Descr = Reader.GetString(0);
                State.Is_final = Reader.GetBoolean(1);
                State.Is_rejected = Reader.GetBoolean(2);
                State.Is_request = Reader.GetBoolean(3);
                State.Is_ticket = Reader.GetBoolean(4);
            }
            Reader.Close();
            return State;
        }
        public bool InsereTicket(Ticket TK)
        {

            bool result = false;
            if (TK.Num == 0) // se o registo já existe ? Actualiza em vez de Inserir
            {
                string[] Fields = { "Descricao", "createdate", "prioridade", "State", "Aread_ID", "Requester" };
                string[] Values = new string[Fields.Length];
                Values[0] = TK.Description;
                Values[1] = TK.Createdate.ToString();
                Values[2] = TK.Priority.ToString();
                Values[3] = TK.Estado.ToString();
                Values[4] = GetID("Areas", "Descricao", "Id", TK.Areaintre.Descr).ToString();
                Values[5] = TK.Requester.NIF.ToString();

                result = InsereRegisto("Ticket", Fields, Values);
            }
            else
            {
                PropertyInfo[] properties = TK.GetType().GetProperties();
                List<string> Fields = new List<string>();
                List<string> Values = new List<string>();
                foreach (PropertyInfo Property in properties)
                {
                    if (!(string.IsNullOrEmpty(Property.GetValue(TK).ToString())))
                    {
                        switch (Property.Name)
                        {
                            case "Createdate":
                                Fields.Add("createdate");
                                break;
                            case "Priority":
                                Fields.Add("prioridade");
                                break;
                            case "Requester":
                                Fields.Add("Requester");
                                break;
                            case "Horas":
                                Fields.Add("horas");
                                break;
                            case "Estado":
                                Fields.Add("State");
                                break;
                            case "Equipamento":
                                Fields.Add("Equipamento");
                                break;
                            case "Lastupdate":
                                Fields.Add("lastupdate");
                                break;
                            case "Quemfechou":
                                Fields.Add("quemfechou");
                                break;
                            case "Description":
                                Fields.Add("Descricao");
                                break;
                            case "Resolution":
                                Fields.Add("Resolucao");
                                break;
                            case "Areaintre":
                                Fields.Add("Area_Id");
                                break;

                            default:
                                break;
                        }
                        Values.Add(Property.GetValue(TK).ToString());
                    }
                }
                string[,] Condition = { { "Id", "=", TK.Num.ToString() } };
                result = UpdateRegisto("Ticket", Fields.ToArray(), Values.ToArray(), Condition);

            }
            return result;
        }


        public Ticket EliminaTicket(int Id)
        {
            Ticket Record = ProcuraTicket(Id);
            DeleteRegisto("Ticket", new string[,] { { "Id", "=", Id.ToString() } });
            return Record;
        }

        public Perfil ProcuraPerfil(int nif)
        {
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao" };
            string[,] Condition = { { "NIF", "=", nif.ToString() } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Nivel" } };
            SqlDataReader Reader = ProcuraSQL(Tables, JointFields, Fields, Condition);
            Perfil Perf = null;
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
                Perf.NivelHab = new Habilitacao(Reader.GetString(7), Reader.GetInt32(3));

                Reader.Close();
                Reader = null;


            }
            return Perf;
        }
        /// <summary>
        /// Mostra todos os Perfis
        /// </summary>
        /// <returns></returns>
        public List<Perfil> ProcuraPerfis()
        {
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao" };
            string[,] Condition = { { "is_Super", "=", "0" } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Nivel" } };
            SqlDataReader Reader = ProcuraSQL(Tables, JointFields, Fields, Condition);
            List<Perfil> Perfs = new List<Perfil>();
            Perfil Perf = null;
            if (Reader.HasRows)
            {
                bool is_tec = false;
                while (Reader.Read())
                {

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
                    Perf.NivelHab = new Habilitacao(Reader.GetString(7), Reader.GetInt32(3));
                    Perfs.Add(Perf);
                }
                Reader.Close();
                Reader = null;


            }
            return Perfs;
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
            string[] Fields = { "Perfil.NIF", "Perfil.Senha", "Perfil.Nome", "Perfil.NivelHab", "Perfil.Is_Admin", "Perfil.Is_Tec", "Perfil.Is_Super", "Habilitacoes.Descricao" };
            string tec = "0"; string adm = "0";
            if (is_Tecnico) tec = "1";
            if (is_Admin) adm = "1";
            string[,] Condition = { { "is_Super", "=", "0" }, { "is_Tec", "=", tec }, { "Is_Admin", "=", adm } };
            string[] Tables = { "Perfil", "Habilitacoes" };
            string[,] JointFields = { { "Perfil.NivelHab", "Habilitacoes.Nivel" } };
            SqlDataReader Reader = ProcuraSQL(Tables, JointFields, Fields, Condition);
            List<Perfil> Perfs = new List<Perfil>();
            Perfil Perf = null;
            if (Reader.HasRows)
            {
                bool is_tec = false;
                while (Reader.Read())
                {

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
                    Perf.NivelHab = new Habilitacao(Reader.GetString(7), Reader.GetInt32(3));
                    Perfs.Add(Perf);
                }
                Reader.Close();
                Reader = null;


            }
            return Perfs;
        }


        public Ticket ProcuraTicket(int Id)
        {
            
            SqlDataReader Reader = ProcuraSQL("Tickets", new string[] { "Id", "prioridade", "createdate", "Requester", "horas", "State", "Equipamento", "lastupdate", "quemfechou", "Descricao", "Resolucao","Area_Id" }, new string[,]{ { "Id","=",Id.ToString()} });
            Ticket TK = new Ticket();
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();

                    TK.Num = Reader.GetInt32(0);
                    TK.Priority = ProcuraPrioridade(Reader.GetInt32(1));
                    TK.Createdate = Reader.GetDateTime(2);
                    TK.Requester = (Colaborador)ProcuraPerfil(Reader.GetInt32(3));
                    TK.Horas = Reader.GetInt32(4);
                    TK.Estado = ProcuraEstado(Reader.GetInt32(5));
                    TK.Num = Reader.GetInt32(0);
                        
                }
            }
            return TK;
        }

        public List<Ticket> ProcuraTicketsEncomendaPendente()
        {
            throw new NotImplementedException();
        }
        public List<Ticket> ProcuraTicketsPorEstadoTipo(string Estado, int tipo)
        {
            List<string[]> cond = new List<string[]>();



            if (tipo > 0) cond.Add(new string[] { "Area_Id", "=", tipo.ToString() });
            cond.Add(new string[] { "State", "=", GetID("States", "name", "Id", Estado).ToString() });
            



            SqlDataReader Reader = ProcuraSQL("Tickets", new string[] { "ID", "Descricao", "Equipamento", "lastupdate" }, cond );
            List<Ticket> lstTK = new List<Ticket>();
            if (Reader != null)
            {


                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Ticket tk = new Ticket();
                        tk.Num = Reader.GetInt32(0);
                        tk.Num = Reader.GetInt32(1);
                        tk.Num = Reader.GetInt32(2);
                        tk.Num = Reader.GetInt32(3);
                        tk.Num = Reader.GetInt32(4);
                        tk.Num = Reader.GetInt32(5);
                        tk.Num = Reader.GetInt32(0);
                        lstTK.Add(tk);
                    }
                }
            }
            return lstTK;
        }
        /// <summary>
        /// Esta função usa a ProcuraTicketsPorEstadoTipo é mantida para compatibilidade com versões antigas do interface
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

        public Status ProcuraEstado(int Id)
        {
            Status ST = new Status();
            string[,] cond = new string[1, 3];
            cond[0, 0] = "Id";
            cond[0, 1] = "=";
            cond[0, 2] = Id.ToString();

            SqlDataReader Reader = ProcuraSQL("States", new string[] { "Name", "IsFinalState", "IsRejectState", "Is_Ticket", "Is_Request" }, cond);
            List<Status> lstST = new List<Status>();
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    ST.Descr = Reader.GetString(0);
                    ST.Is_final = Reader.GetBoolean(1);
                    ST.Is_rejected = Reader.GetBoolean(2);
                    ST.Is_request = Reader.GetBoolean(3);
                    ST.Is_ticket = Reader.GetBoolean(4);
                }
                Reader.Close();
            }
            return ST;
        }

        public Status ProcuraEstado(string name)
        {
            Status ST = new Status();
            string[,] cond = new string[1, 3];
            cond[0, 0] = "name";
            cond[0, 1] = "=";
            cond[0, 2] = name;
            
            SqlDataReader Reader = ProcuraSQL("States", new string[] { "Name", "IsFinalState", "IsRejectState", "Is_Ticket", "Is_Request" }, cond);
            List<Status> lstST = new List<Status>();
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();     
                    ST.Descr = Reader.GetString(0);
                    ST.Is_final = Reader.GetBoolean(1);
                    ST.Is_rejected = Reader.GetBoolean(2);
                    ST.Is_request = Reader.GetBoolean(3);
                    ST.Is_ticket = Reader.GetBoolean(4);
                }
                Reader.Close();
            }
            return ST;
        }
        public List<Status> ProcuraEstados(bool is_Ticket, bool is_Request)
        {
            List<string[]> cond = new List<string[]>();
            if (is_Ticket)
            {
                cond.Add(new string[] { "Is_Ticket", "=", "1" });
            }
            if (is_Request)
            {
                cond.Add(new string[] { "Is_Request", "=", "1" });
            }

            SqlDataReader Reader = ProcuraSQL("States", new string[] { "Name", "IsFinalState", "IsRejectState", "Is_Ticket", "Is_Request" }, cond);
            List<Status> lstST = new List<Status>();
            if (Reader != null)
            {

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Status ST = new Status();
                        ST.Descr = Reader.GetString(0);
                        ST.Is_final = Reader.GetBoolean(1);
                        ST.Is_rejected = Reader.GetBoolean(2);
                        ST.Is_request = Reader.GetBoolean(3);
                        ST.Is_ticket = Reader.GetBoolean(4);
                        lstST.Add(ST);
                    }
                }
                Reader.Close();
            }

            return lstST;
        }
        public bool InsereEstado(Status Estado)
        {
            return InsereRegisto("States", new string[] { "Is_final", "Descricao" }, new string[] { Estado.Is_final.ToString(), Estado.Descr.ToString() });
        }

        public Status EliminaEstado(string Estado)
        {
            
            Status Record = ProcuraEstado(Estado);
            DeleteRegisto("States", new string[,] { { "name", "=", Estado } });
            return Record;
        }

        public bool InsereEquipamento(Equipamento Equip)
        {
            return InsereRegisto("Equipamento", new string[] { "Descricao", "PartNum", "ModelNum", "Location", "Price", "Employee" }, new string[] {Equip.Descr, Equip.Partnumber, Equip.Modelnum,Equip.Localizacao,Equip.Price.ToString(),Equip.Empregado.NIF.ToString()});
        }

        public List<Equipamento> ProcuraEquipamentos()
        {
            List<Equipamento> Equipamentos = new List<Equipamento>();

            SqlDataReader Reader = ProcuraSQL("Equipamento", new string[] { "InventCode",  "Descricao", "PartNum", "ModelNum", "Location", "Price", "Employee" });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Perfil user = ProcuraPerfil(Reader.GetInt32(6));
                        
                        List<Material> pecas = ProcuraPecas(Reader.GetInt32(0));
                        Equipamento equip = new Equipamento();
                        equip.Inventcode = Reader.GetInt32(0);
                        equip.Partnumber = Reader.GetString(2);
                        equip.Modelnum = Reader.GetString(3);
                        equip.Descr = Reader.GetString(1);
                        equip.Pecas = pecas;
                        equip.Localizacao = Reader.GetString(4);
                        equip.Empregado = user;
                        equip.Price = (double)Reader.GetValue(5);
                        Equipamentos.Add(equip);
                    }
                }
            }

            Reader.Close();
            Reader = null;
            return Equipamentos;
        }

        public Equipamento ProcuraEquipamento(string InventCode)
        {
            throw new NotImplementedException();
        }

        public Equipamento EliminaEquipamento(string InventCode)
        {
            Equipamento Record = ProcuraEquipamento(InventCode);
            DeleteRegisto("Equipamento", new string[,] { { "InventCode", "=", InventCode } });
            return Record;
        }

        public bool InsereArea(Area Area)
        {
            return InsereRegisto("Areas", new string[] { "NivelMinimo", "Descricao" }, new string[] { Area.NivelMinimo.ToString(), Area.Descr.ToString() });
        }
        public Area ProcuraArea(string name)
        {
            Area area = new Area(name);

            SqlDataReader Reader = ProcuraSQL("Areas", new string[] { "Descricao", "NivelMinimo" }, new string[,] { { "Descricao", "=", name } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    area.Descr = Reader.GetString(0);
                    area.NivelMinimo =  Reader.GetInt32(1);
                }
            }

            Reader.Close();
            Reader = null;
            return area;
        }
        /// <summary>
        /// Devolve as areas todas da tabela Areas
        /// </summary>
        /// <returns></returns>
        public List<Area> ProcuraAreas()
        {
            List<Area> Areas = new List<Area>();

            SqlDataReader Reader = ProcuraSQL("Areas", new string[] { "Descricao", "NivelMinimo" });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Areas.Add(new Area(Reader.GetString(0), Reader.GetInt32(1)));
                    }
                }
            }

            Reader.Close();
            Reader = null;
            return Areas;
        }
        /// <summary>
        /// Devolve Areas por Técnico
        /// </summary>
        /// <param name="NIF"></param>
        /// <returns></returns>
        public List<Area> ProcuraAreas(int NIF)
        {
            List<Area> areas = new List<Area>();

            SqlDataReader reader = ProcuraSQL(new string[] { "AreaIntre", "Areas" }, new string[,] { { "AreaIntre.Area_Id", "Areas.Id" } }, new string[] { "Areas.Descricao", "Areas.NivelMinimo" }, new string[,] { { "NIF", "=", NIF.ToString() } });
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
            Area Record = ProcuraArea(Area);
            DeleteRegisto("Areas", new string[,] { { "Descricao", "=", Area } });
            return Record;
        }

        public bool InsereHabilitacao(Habilitacao Habilitacao)
        {
            return InsereRegisto("Habilitacoes", new string[] { "Nivel", "Descricao" }, new string[] { Habilitacao.Nivel.ToString(), Habilitacao.Descr.ToString() });
        }
        public Habilitacao ProcuraHabilitacao(string Descr)
        {
            Habilitacao Habilit = new Habilitacao();

            SqlDataReader Reader = ProcuraSQL("Habilitacoes", new string[] { "Nivel", "Descricao" }, new string[,] { { "Descricao", "=", Descr } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Habilit.Descr = Reader.GetString(1);
                    Habilit.Nivel = Reader.GetInt32(0);
                    
                }
            }
            Reader.Close();
            Reader = null;
            return Habilit;
        }
        public List<Habilitacao> ProcuraHabilitacoes()
        {
            List<Habilitacao> Habilitacoes = new List<Habilitacao>();

            SqlDataReader Reader = ProcuraSQL("Habilitacoes", new string[] { "Nivel", "Descricao" });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Habilitacoes.Add(new Habilitacao(Reader.GetString(1), Reader.GetInt32(0)));
                    }
                }
            }

            Reader.Close();
            Reader = null;
            return Habilitacoes;
        }

        public Habilitacao EliminaHabilitacao(string Descricao)
        {
            Habilitacao Record = ProcuraHabilitacao(Descricao);
            DeleteRegisto("Materiais", new string[,] { { "Descricao", "=", Descricao } });
            return Record;
        }

        public bool InsereMaterial(Material Material)
        {
            return InsereRegisto("Materiais", new string[] { "partnumber", "price", "issoftware", "name", "supplier" }, new string[] { Material.Partnumber.ToString(), Material.Price.ToString(), Material.Issoftware.ToString(), Material.Descr.ToString(), Material.Supplier.ToString() });

        }
        public List<Material> ProcuraPecas(int InventCode)
        {
            List<Material> Materiais = new List<Material>();

            SqlDataReader Reader = ProcuraSQL(new string[] { "EquipPart", "Materiais"}, new string[,] { { "EquipPart.PartNumber", "Materiais.partnumber" } }, new string[] { "Materiais.partnumber", "Materiais.name", "Materiais.supplier", "Materiais.price", "Materiais.issoftware" }, new string[,] { { "EquipPart.InventCode", "=", InventCode.ToString() } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Material mat = new Material();
                        mat.Partnumber = Reader.GetString(0);
                        mat.Descr = Reader.GetString(1);
                        mat.Supplier = Reader.GetString(2);
                        mat.Price = (double)Reader.GetValue(3);
                        mat.Issoftware = Reader.GetBoolean(4);
                        Materiais.Add(mat);
                    }
                }
                Reader.Close();
            }

            
            
            return Materiais;
        }
        public Material ProcuraMaterial(string partnumber )
        {
            Material Material = new Material();

            SqlDataReader Reader = ProcuraSQL("Materiais", new string[] { "partnumber", "name", "supplier", "price", "issoftware" }, new string[,] { { "partnumber", "=", partnumber } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Material.Partnumber = Reader.GetString(0);
                    Material.Descr = Reader.GetString(1);
                    Material.Supplier = Reader.GetString(2);
                    Material.Price = Reader.GetDouble(3);
                    Material.Issoftware = Reader.GetBoolean(4);
                }
            }

            Reader.Close();
            Reader = null;
            return Material;
        }
        public List<Material> ProcuraMaterial()
        {
            List<Material> Materiais = new List<Material>();

            SqlDataReader Reader = ProcuraSQL("Materiais", new string[] { "partnumber", "name", "supplier", "price", "issoftware" });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Materiais.Add(new Material(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetDouble(3), Reader.GetBoolean(4)));
                    }
                }
            }

            Reader.Close();
            Reader = null;
            return Materiais;
        }
        
        public Material EliminaMaterial(string partnumber)
        {
            Material Record = ProcuraMaterial(partnumber);
            DeleteRegisto("Materiais", new string[,] { { "partnumber", "=", partnumber } });
            return Record;
        }
        public Prioridade EliminaPrioridade(string SmallName)
        {
            Prioridade Record = ProcuraPrioridade(SmallName);
            DeleteRegisto("Priority", new string[,] { { "SmallName", "=", SmallName } });
            return Record;
        }

        public bool InserePrioridade(Prioridade Prioridade)
        {
            return InsereRegisto("Priority", new string[] { "Nivel", "Descr" }, new string[] { Prioridade.Nivel.ToString(), Prioridade.Descr.ToString() });
        }
        public Prioridade ProcuraPrioridade(int Id)
        {
            Prioridade Prio = new Prioridade();

            SqlDataReader Reader = ProcuraSQL("Priority", new string[] { "Nivel", "SmallName", "Descr" }, new string[,] { { "Id", "=", Id.ToString() } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Prio.Nivel = Reader.GetInt32(0);
                    Prio.Smallname = Reader.GetString(1);
                    Prio.Descr = Reader.GetString(2);

                }
            }

            Reader.Close();
            Reader = null;
            return Prio;
        }
        public Prioridade ProcuraPrioridade(string SmallName)
        {
            Prioridade Prio = new Prioridade();

            SqlDataReader Reader = ProcuraSQL("Priority", new string[] { "Nivel", "SmallName", "Descr" }, new string[,] { { "SmallName", "=", SmallName } });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Prio.Nivel = Reader.GetInt32(0);
                    Prio.Smallname = Reader.GetString(1);
                    Prio.Descr = Reader.GetString(2);
                    
                }
            }

            Reader.Close();
            Reader = null;
            return Prio;
        }
        public List<Prioridade> ProcuraPrioridade()
        {
            List<Prioridade> Prioridades = new List<Prioridade>();

            SqlDataReader Reader = ProcuraSQL("Priority", new string[] { "Nivel", "SmallName", "Descr" });
            if (Reader != null)
            {
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Prioridades.Add(new Prioridade(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2)));
                    }
                }
            }

            Reader.Close();
            Reader = null;
            return Prioridades;
        }
    }
}
