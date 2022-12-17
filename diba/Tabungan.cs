using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace diba
{
    public class Tabungan
    {
        private string noRekening;
        private Pengguna penggunaNik;
        private double saldo;
        private string status;
        private string keterangan;
        private DateTime tglBuat;
        private DateTime tglPerubahan;
        private Employee verifikator;
        private KodeBank bank;

        public Tabungan(string noRekening, Pengguna penggunaNik, string keterangan, Employee verifikator, KodeBank bank)
        {
            NoRekening = noRekening;
            PenggunaNik = penggunaNik;
            Saldo = 0;
            Status = "UNVERIFIED";
            Keterangan = keterangan;
            TglBuat = DateTime.Now;
            TglPerubahan = DateTime.Now;
            Verifikator = verifikator;
            Bank = bank;
        }
        public Tabungan()
        {
            NoRekening = "";
            PenggunaNik = new Pengguna();
            Saldo = 0;
            Status = "";
            Keterangan = "";
            TglBuat = DateTime.Now;
            TglPerubahan = DateTime.Now;
            Verifikator = new Employee();
            Bank = new KodeBank();
        }

        public string NoRekening { get => noRekening; set => noRekening = value; }
        public Pengguna PenggunaNik { get => penggunaNik; set => penggunaNik = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Status { get => status; set => status = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public DateTime TglBuat { get => tglBuat; set => tglBuat = value; }
        public DateTime TglPerubahan { get => tglPerubahan; set => tglPerubahan = value; }
        public Employee Verifikator { get => verifikator; set => verifikator = value; }
        public KodeBank Bank { get => bank; set => bank = value; }

        public static List<Tabungan> Bacadata(string Kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (Kriteria == "")
            {
                sql = "select * from tabungan t inner join pengguna p on t.pengguna_nik= p.nik inner join employee e on t.verifikator = e.id inner join kode_bank k on t.kode_bank_id = k.id ";
            }
            else
            {
                sql = "select * from tabungan t inner join pengguna p on t.pengguna_nik= p.nik inner join employee e on t.verifikator = e.id inner join kode_bank k on t.kode_bank_id = k.id where" + Kriteria + " like'%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Tabungan> listData = new List<Tabungan>();
            while (hasil.Read() == true)
            {
                Tabungan k = new Tabungan();
                int id = int.Parse(hasil.GetValue(0).ToString());
                string kode = hasil.GetValue(1).ToString();
                string nama = hasil.GetValue(2).ToString();
                
                listData.Add(k);
            }
            return listData;
        }
        public static void TambahData(Tabungan t)
        {
            string sql = "insert into tabungan value ('" + t.NoRekening + "','" + t.PenggunaNik.Nik + "','" + t.Saldo + "','UNVERIFIED','" + t.Keterangan + "','" + t.TglBuat.ToString("yyyy-MM-dd") + "','" + t.TglPerubahan.ToString("yyyy-MM-dd") + "','" + t.Verifikator.Nik + "','" + t.Bank.Kode + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void UpdateData(Tabungan k)
        {
            string sql = "UPDATE tabungan SET penggunaNik ='" + k.PenggunaNik + "', saldo ='" + k.Saldo + "', status ='" + k.Status + "', keterangan ='" + k.Keterangan + "'WHERE norekening='" + k.NoRekening + "';";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void DeleteData(string k)
        {
            string sql = "delete from tabungan where norekening = '" + k + "'";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
