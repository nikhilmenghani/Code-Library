using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Collections;
namespace database_connectiom
{
    public class DBConnect
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "server=SREERAJ-PC;integrated security=true;database=MyDb";
        
        public DBConnect()
        {
            con = new SqlConnection(str);

        }
        
        public void openConnection()
        {
            con.Open();
        }
        
        public void closeConnection()
        {
            con.Close();
        }
        
        //Connected Architecture
        public void executeIUD(string query)
        {
            cmd = new SqlCommand(query, con);
            openConnection();
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public SqlDataReader executeSelectQueryWithDR(string query)
        {
            cmd = new SqlCommand(query, con);
            openConnection();
            return cmd.ExecuteReader();
        }

        //Disconnected Arhitecture
        public SqlDataAdapter getSqlDataAdapter(string query)
        {
            cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            return sda;
        }

        public DataTable executeSelectQueryWithDT(string query)
        {
            DataTable dt = new DataTable();
            getSqlDataAdapter(query).Fill(dt);
            return dt;
        }

        public DataSet executeSelectQueryWithDS(string query)
        {
            DataSet ds = new DataSet();
            getSqlDataAdapter(query).Fill(ds);
            return ds;
        }

        //function to call any procedure
        public void callProcedure(string procedureName, string parameters)
        {
            string[] arr = parameters.Split(',');
            ArrayList list = new ArrayList();
            foreach (var item in arr)
            {
                list.Add(item);
            }
            Hashtable ht = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                ht.Add("@value" + i, list[i]);
            }
            IDictionaryEnumerator hashenum = ht.GetEnumerator();

            cmd = new SqlCommand(procedureName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            while (hashenum.MoveNext())
            {
                cmd.Parameters.Add(new SqlParameter(hashenum.Key.ToString(), hashenum.Value.ToString()));
            }
            openConnection();
            cmd.ExecuteNonQuery();
            closeConnection();
        }
    }
}