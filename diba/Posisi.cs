using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diba
{
    public class Posisi
    {
        private int id;
        private string nama;
        private string keterangan;

        public Posisi(int id, string nama, string keterangan)
        {
            this.id = id;
            this.nama = nama;
            this.keterangan = keterangan;
        }

        public Posisi()
        {
            this.id = 0;
            this.nama = "";
            this.keterangan = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }

        public static List<Posisi> BacaData(string kolom = "", string nilai = "")
        {
            // STEP 1. susun perintah query
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from position;";
            else //jika ada filter
                sql = "select * from position where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Posisi> listData = new List<Posisi>();
            while (hasil.Read() == true)
            {
                int id = int.Parse(hasil.GetValue(0).ToString()); //ambil isi datareader per kolom
                string nama = hasil.GetValue(1).ToString();
                string keterangan = hasil.GetValue(2).ToString();
                Posisi p = new Posisi(id, nama, keterangan); //buat 1 objek kategori
                listData.Add(p); //tambahkan objek kategori ke list
            }
            return listData;
        }
        public static void TambahData(Posisi p)
        {
            string sql = "INSERT INTO position (id,nama,keterangan) VALUES ('" + p.Id + "','" + p.Nama + "','" + p.Keterangan + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void UbahData(Posisi p)
        {
            string sql = "UPDATE position SET nama='" + p.Nama + "', keterangan='" + p.Keterangan + "'WHERE id='" + p.Id + "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void HapusData(string id)
        {
            string sql = "delete from position where id='" + id + "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public override string ToString()
        {   //menggantikan method tostring, dengan mengembalikan field nama dari jabatan
            return Nama;
        }
    }
}
