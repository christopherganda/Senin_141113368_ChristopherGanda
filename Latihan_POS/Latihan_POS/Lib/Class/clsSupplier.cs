﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Latihan_POS
{
    class clsSupplier
    {
        public enum gender
        {
            Wanita=0,
            Pria=1
        }
        public int id { set; get; }
        public string nama { set; get; }
        public string nomorHp { set; get; }
        public gender jenisKelamin { set; get; }
        public clsSupplier(string kata)
        {
            if (kata != "")
            {
                DataRow row = GlobalSql.GetDataRow("select * from supplier where id = '" + kata + "'");
                id = (int)row["id"];
                nama = row["nama"].ToString();
                nomorHp = row["no_hp"].ToString();
                jenisKelamin = (gender)Convert.ToInt32(row["jenis_kelamin"]);
            }          
        }
    }
}
