using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace diba
{
    public class KodeBank
    {
        private int id;
        private string kode;
        private string nama;

        public KodeBank(int id, string kode, string nama)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
        }
        public KodeBank()
        {
            Id = 0;
            Kode = "";
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Kode { get => kode; set => kode = value; }
        public string Nama { get => nama; set => nama = value; }
        public static List<KodeBank> Bacadata(string Kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (Kriteria == "")
            {
                sql = "select * from kode_bank";
            }
            else
            {
                sql = "select * from kode_bank where " + Kriteria + " like'%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<KodeBank> listData = new List<KodeBank>();
            while (hasil.Read() == true)
            {
                int id = int.Parse(hasil.GetValue(0).ToString());
                string kode = hasil.GetValue(1).ToString();
                string nama = hasil.GetValue(2).ToString();
                KodeBank k = new KodeBank(id, kode, nama);
                listData.Add(k);
            }
            return listData;
        }
        public static void TambahData(KodeBank k)
        {
            string sql = "insert into kode_bank value ('" + k.Id + "','" + k.Kode + "','" + k.Nama + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void UpdateData(Jenis_Transaksi k)
        {
            string sql = "UPDATE kode_bank SET kode ='" + k.Kode + "', nama ='" + k.Nama + "'WHERE id='" + k.Id + "';";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void DeleteData(string k)
        {
            string sql = "delete from kode_bank where id = '" + k + "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
