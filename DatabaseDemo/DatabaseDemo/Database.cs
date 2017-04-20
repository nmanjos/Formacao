using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
All Code made By: Nuno Anjos
Possible Snippets taken from MSDN , w3schools . dotnetperls, stackoverflow

*/
namespace DatabaseDemo
{
    class Database
    {
        private SqlConnection OpenConnection(string Server, string DataBase, string UserName, string Secret)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=" + Server +";" +
            "Initial Catalog=" + DataBase + ";" +
            "User id="+ UserName + ";" +
            "Password=" + Secret + ";";
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        
            return conn;
        }
        private void UpdateData(string Table, string[] Fields, string[] Values, string Condition)
        {
            // This Method will insert a new record in a table, constructing the "INSERT INTO"
            // Remember Values must come already Formated, that means '' for text fields but not for numerical, if you are getting an error it is propably that !
            // SQL Injection by the user of this class is avoided Since the SQL Command is constructed here
            if (Fields.Length == Values.Length)  // Validate if Fields and Values have the same number of elements
            {
                
                string str="";
                for (int i = 0; i < Fields.Length; i++)
                {
                    if (i != (Fields.Length - 1))
                    {
                        str += Fields[i] + " = " + Values[i] + ",";
                    }
                    else
                    {
                        str += Fields[i] + " = " + Values[i] ;
                    }
                }
                string SQLstr = "UPDATE" + Table + "SET " + str +";";
                SqlCommand myCommand = new SqlCommand(SQLstr, OpenConnection(@"(localdb)\MSSQLLocalDB", "Teste", "appSQL", "appSQL"));
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        private void InsertData(string Table, string[] Fields, string[] Values)
        {
            // This Method will insert a new record in a table, constructing the "INSERT INTO"
            // Remember Values must come already Formated, that means '' for text fields but not for numerical, if you are getting an error it is propably that !
            // SQL Injection by the user of this class is avoided Since the SQL Command is constructed here
            if (Fields.Length == Values.Length)  // Validate if Fields and Values have the same number of elements
            {
                string vl = "";
                string fld = "";
                for (int i = 0; i < Fields.Length; i++)
                {
                    if (i != (Fields.Length - 1))
                    {
                        fld += Fields[i] + ",";
                        vl += Values[i] + ",";
                    }
                    else
                    {
                        fld += Fields[i];
                        vl += Values[i];
                    }
                }
                string SQLstr = "INSERT INTO" + Table + "(" + fld + ") VALUES (" + vl + ");";
                SqlCommand myCommand = new SqlCommand(SQLstr, OpenConnection(@"(localdb)\MSSQLLocalDB", "Teste", "appSQL", "appSQL"));
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        private DataSet ReadData(string query)
        {

            // This Method Starts the connection, Reads data returned by a query and stores it in a DataSet Object, 
            // this object is a C# data Object that can be direcly connected to any Data Control in a Form
            
            DataSet ds = new DataSet();
            try
            {
                
                
                SqlCommand myCommand = new SqlCommand(query,OpenConnection(@"(localdb)\MSSQLLocalDB", "Teste", "appSQL", "appSQL"));
                DataTable table = new DataTable();
                table.Load(myCommand.ExecuteReader());
                ds.Tables.Add(table);
                myCommand.Connection.Close();  // Closes the connection, the data is now disconnected from the database
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return ds;
        } 
    }
}
