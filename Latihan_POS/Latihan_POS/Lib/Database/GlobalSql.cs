using System;
using System.Net;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
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
    }
}