using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diba
{
    public class Jenis_Transaksi
    {
        private int id;
        private string kode;
        private string nama;

        public Jenis_Transaksi(int id, string kode, string nama)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
        }

        public Jenis_Transaksi()
        {
            Id = 0;
            Kode = "";
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Kode
        {
            get => kode; set
            {
                if (value.Length <= 3)
                {
                    kode = value;
                }
                else
                {
                    throw new Exception("Kode Hanya bisa 3 DIGIT");
                }
            }
        }
        public string Nama { get => nama; set => nama = value; }

        public static List<Jenis_Transaksi> Bacadata(string Kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (Kriteria == "")
            {
                sql = "select * from jenistransaksi";
            }
            else
            {
                sql = "select * from jenistransaksi where " + Kriteria + " like'%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Jenis_Transaksi> listData = new List<Jenis_Transaksi>();
            while (hasil.Read() == true)
            {
                int id = int.Parse(hasil.GetValue(0).ToString());
                string kode = hasil.GetValue(1).ToString();
                string nama = hasil.GetValue(2).ToString();
                Jenis_Transaksi k = new Jenis_Transaksi(id, kode, nama);
                listData.Add(k);
            }
            return listData;
        }
        public static void TambahData(Jenis_Transaksi k)
        {
            string sql = "insert into jenistransaksi value ('" + k.Id + "','" + k.Kode + "','" + k.Nama + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void UpdateData(Jenis_Transaksi k)
        {
            string sql = "UPDATE jenistransaksi SET kode ='" + k.Kode + "', nama ='" + k.Nama + "'WHERE id_jenis_transaksi='" + k.Id + "';";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void DeleteData(string k)
        {
            string sql = "delete from jenistransaksi where id_jenis_transaksi = '" + k + "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
