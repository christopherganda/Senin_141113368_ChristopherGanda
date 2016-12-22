using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Latihan_POS
{
    class clsItem
    {
        public int id { set; get; }
        public string namaBarang { set; get; }
        public string kodeBarang{set;get;}
        public double jumlahAwal { set; get; }
        public double hargaHpp { set; get; }
        public double hargaJual { set; get; }
        public clsItem(string kata)
        {
            if (kata != "")
            {
                DataRow row = GlobalSql.GetDataRow("select * from item where id = '" + kata + "'");
                id = (int)row["id"];
                namaBarang = row["nama_barang"].ToString();
                kodeBarang = Convert.ToString(row["kode_barang"]);
                jumlahAwal = Convert.ToDouble(row["jumlah_awal"]);
                hargaHpp = Convert.ToDouble(row["harga_hpp"]);
                hargaJual = Convert.ToDouble(row["harga_jual"]);
            }
            

        }
    }
}
