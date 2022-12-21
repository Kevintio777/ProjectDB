using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace diba
{
    public class Transaksi
    {
        private string rekening_sumber;
        private int id;
        private DateTime tgl_transaksi;
        private int id_jenis_transaksi;
        private string rekening_tujuan;
        private double nominal;
        private string keterangan;

        public string Rekening_sumber { get => rekening_sumber; set => rekening_sumber = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Tgl_transaksi { get => tgl_transaksi; set => tgl_transaksi = value; }
        public int Id_jenis_transaksi { get => id_jenis_transaksi; set => id_jenis_transaksi = value; }
        public string Rekening_tujuan { get => rekening_tujuan; set => rekening_tujuan = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }

        public Transaksi(string rekening_sumber, int id, DateTime tgl_transaksi, int id_jenis_transaksi, string rekening_tujuan, double nominal, string keterangan)
        {
            this.Rekening_sumber = rekening_sumber;
            this.Id = id;
            this.Tgl_transaksi = tgl_transaksi;
            this.Id_jenis_transaksi = id_jenis_transaksi;
            this.Rekening_tujuan = rekening_tujuan;
            this.Nominal = nominal;
            this.Keterangan = keterangan;
        }

        public Transaksi()
        {
            this.Rekening_sumber = "";
            this.Id = GenerateId();
            this.Tgl_transaksi = DateTime.Now;
            this.Id_jenis_transaksi = 0;
            this.Rekening_tujuan = "";
            this.Nominal = 0;
            this.Keterangan = "";
        }

        public Transaksi(string rekening_sumber, int id_jenis_transaksi, string rekening_tujuan, int nominal, string keterangan)
        {
            this.Rekening_sumber = rekening_sumber;
            this.Id = GenerateId();
            this.Tgl_transaksi = tgl_transaksi;
            this.Id_jenis_transaksi = id_jenis_transaksi;
            this.Rekening_tujuan = rekening_tujuan;
            this.Nominal = nominal;
            this.Keterangan = keterangan;
        }

        public static int GenerateId()
        {
            int identifier = int.Parse(DateTime.Now.ToString("yyMMdd") + (new Random()).Next(0, 99).ToString("D2"));

            return identifier;
        }

        public static void TambahData(Transaksi t)
        {
            string sql = "INSERT INTO transaksi (rekening_sumber, transaksi_id, tgl_transaksi, id_jenis_transaksi," +
                " rekening_tujuan, nominal, keterangan) VALUES('" + t.Rekening_sumber + ", " + t.Id + ", " + t.Tgl_transaksi.ToString("yyyy-MM-dd") + ", " + t.Id_jenis_transaksi + ", "
                + t.Rekening_tujuan + ", " + t.Nominal + ", " + t.Keterangan + ")";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static List<Transaksi> BacaData(string kolom = "", string nilai = "")
        {
            string sql;
            if (kolom == "")
                sql = "select * from transaksi;";
            else
                sql = "select * from transaksi where " + kolom + " like '%" + nilai + "%';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Transaksi> listData = new List<Transaksi>();
            while (hasil.Read() == true)
            {
                string tRekening_sumber = hasil.GetValue(0).ToString();
                int tTransaksi_id = int.Parse(hasil.GetValue(1).ToString());
                DateTime tTgl_transaksi = DateTime.Parse(hasil.GetValue(2).ToString());
                int tJenis_transaksi = int.Parse(hasil.GetValue(3).ToString());
                string tRekening_Tujuan = hasil.GetValue(4).ToString();
                int tNominal = int.Parse(hasil.GetValue(5).ToString());
                string tKeterangan = hasil.GetValue(6).ToString();


                Transaksi t = new Transaksi(tRekening_sumber, tTransaksi_id, tTgl_transaksi, tJenis_transaksi, tRekening_Tujuan, tNominal, tKeterangan);
                listData.Add(t);
            }
            return listData;
        }
    }
}
