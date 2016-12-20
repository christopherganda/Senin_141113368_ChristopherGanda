using System;
using System.Net;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Latihan_POS
{
    public class GlobalSql
    {
        static String mySqlConnString = "server=localhost;user=root;password=password;database= pos" +
        ";Convert Zero Datetime=True;allow user variables=true";
        public static MySqlConnection mySqlConn = new MySqlConnection(mySqlConnString);
        public static void bukaKoneksi()
        {
            try{
                if(mySqlConn.State!= ConnectionState.Open )
                    mySqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 


        }
        public static void tutupKoneksi()
        {
            if (mySqlConn.State != ConnectionState.Closed)
                mySqlConn.Close();
        }
        #region insert,update,delete
        public static void InsertData(string table, Dictionary<string, object> parameters)
        {
            int i = 0;
            MySqlCommand cmd = mySqlConn.CreateCommand();
            string cmdText = "INSERT INTO " + table + "(";

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += parameter.Key;
                cmd.Parameters.AddWithValue('@' + parameter.Key, parameter.Value);
                i++;
            }
            cmdText += ", created_at, updated_at) VALUES (";
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
            i = 0;
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += '@' + parameter.Key;
                i++;
            }
            cmdText += ", @created_at, @updated_at)";
            cmd.CommandText = cmdText;
            try
            {
                bukaKoneksi();
                cmd.ExecuteNonQuery();
                tutupKoneksi();
            }
            catch (Exception ex)
            {
                tutupKoneksi();
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateData(string table, Dictionary<string, object> parameters, int id)
        {
            int i = 0;
            MySqlCommand cmd = mySqlConn.CreateCommand();
            string cmdText = "UPDATE " + table + " SET ";

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += parameter.Key + " = @" + parameter.Key;
                cmd.Parameters.AddWithValue('@' + parameter.Key, parameter.Value);
                i++;
            }
            cmdText += ", updated_at = @updated_at WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
            cmd.CommandText = cmdText;
            try
            {
                bukaKoneksi();
                cmd.ExecuteNonQuery();
                tutupKoneksi();
            }
            catch (Exception ex)
            {
                tutupKoneksi();
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteData(string table, int id)
        {
            int i = 0;
            MySqlCommand cmd = mySqlConn.CreateCommand();
            string cmdText = "DELETE FROM " + table + " WHERE id = @id";
            Console.WriteLine(cmdText);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = cmdText;
            try
            {
                bukaKoneksi();
                cmd.ExecuteNonQuery();
                tutupKoneksi();
            }
            catch (Exception ex)
            {
                tutupKoneksi();
                throw new Exception(ex.Message);
            }
        }

        public static DataTable SelectData(string table)
        {
            bukaKoneksi();
            string select = "SELECT * FROM " + table;
            MySqlDataAdapter da = new MySqlDataAdapter(select, mySqlConn);

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tutupKoneksi();

            DataTable dt = ds.Tables[0].Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.DataType = typeof(string);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dt.ImportRow(row);
            }
            return dt;
        }
        

        #endregion 
        #region table,row,obj

        public static DataTable GetDataTable(MySqlDataAdapter da){
            bukaKoneksi();
            DataTable tabel = new DataTable();
            da.Fill(tabel);
            tutupKoneksi();
            return tabel;
        }
        public static DataTable GetDataTable(MySqlCommand cmd)
        {
            return GetDataTable(new MySqlDataAdapter(cmd));
        }
        public static DataTable GetDataTable(string query)
        {
            return GetDataTable(new MySqlDataAdapter(query,mySqlConn ));
        }
        public static DataRow GetDataRow(MySqlDataAdapter da)
        {
            bukaKoneksi();
            DataTable tabel = GetDataTable(da);
            tutupKoneksi();
            if(tabel.Rows.Count>0)return tabel.Rows[0];
            else return tabel.NewRow();
        }
        public static DataRow GetDataRow(MySqlCommand cmd)
        {
            return GetDataRow(new MySqlDataAdapter(cmd));
        }
        public static DataRow GetDataRow(string query)
        {
            return GetDataRow(new MySqlDataAdapter(query,mySqlConn ));
        }
        public static object GetObject(MySqlDataAdapter da)
        {
            bukaKoneksi();
            DataRow row = GetDataRow(da);
            tutupKoneksi();
            if(row!= null)
                return row[0];
            else return null;
        }
        public static object GetObject(MySqlCommand cmd)
        {
            return GetObject(new MySqlDataAdapter(cmd));
        }
        public static object GetObject(string query)
        {
            return GetObject(new MySqlDataAdapter(query,mySqlConn ));         
        }
        public static T GetObject<T>(MySqlDataAdapter da)
        {
            DataRow row = GetDataRow(da);  
            return (T)row[0];
        }
        public static T GetObject<T>(MySqlCommand cmd)
        {
            return GetObject<T>(new MySqlDataAdapter(cmd));
        }
        public static T GetObject<T>(string query)
        {
            return GetObject<T>(new MySqlDataAdapter(query,mySqlConn ));
        }
        #endregion
    }
}