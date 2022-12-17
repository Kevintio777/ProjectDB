using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace diba
{
    public class Pengguna
    {
        private string nik;
        private string nama_depan;
        private string nama_keluarga;
        private string alamat;
        private string email;
        private string no_telepon;
        private string password;
        private string pin;
        private DateTime tgl_buat;
        private DateTime tgl_perubahan;
        private string pertanyaan_proteksi;
        private string jawaban;
        private List<AdressBook> adressBooks;

        public string Nik { get => nik; set => nik = value; }
        public string Nama_depan { get => nama_depan; set => nama_depan = value; }
        public string Nama_keluarga { get => nama_keluarga; set => nama_keluarga = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string No_telepon { get => no_telepon; set => no_telepon = value; }
        public string Password { get => password; set => password = value; }
        public string Pin { get => pin; set => pin = value; }
        public DateTime Tgl_buat { get => tgl_buat; set => tgl_buat = value; }
        public DateTime Tgl_perubahan { get => tgl_perubahan; set => tgl_perubahan = value; }
        public string Pertanyaan_proteksi { get => pertanyaan_proteksi; set => pertanyaan_proteksi = value; }
        public string Jawaban { get => jawaban; set => jawaban = value; }
        public List<AdressBook> AdressBooks { get => adressBooks; private set => adressBooks = value; }

        public Pengguna(string nik, string nama_depan, string nama_keluarga, string alamat, string email, string no_telepon, string password, string pin, DateTime tgl_buat, DateTime tgl_perubahan, string pertanyaan_proteksi, string jawaban)
        {
            this.Nik = nik;
            this.Nama_depan = nama_depan;
            this.Nama_keluarga = nama_keluarga;
            this.Alamat = alamat;
            this.Email = email;
            this.No_telepon = no_telepon;
            this.Password = password;
            this.Pin = pin;
            this.Tgl_buat = tgl_buat;
            this.Tgl_perubahan = tgl_perubahan;
            this.Pertanyaan_proteksi = pertanyaan_proteksi;
            this.Jawaban = jawaban;
            this.AdressBooks = new List<AdressBook>();
        }

        public Pengguna()
        {
            this.nik = "";
            this.nama_depan = "";
            this.nama_keluarga = "";
            this.alamat = "";
            this.email = "";
            this.no_telepon = "";
            this.password = "";
            this.pin = "";
            this.tgl_buat = DateTime.Now;
            this.tgl_perubahan = DateTime.Now;
            this.pertanyaan_proteksi = "";
            this.jawaban = "";
            this.AdressBooks = new List<AdressBook>();
        }

        public static Pengguna CekLogin(string uid, string pwd)
        {
          
            //STEP 1. SUSUN SQL UNTUK CEK LOGIN
            string sql = "select * from pengguna where email='" + uid + "' and password=SHA2('" + pwd + "',512);";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. JIKA USERNAME DAN PWD TERDAFTAR, MASUKKAN KE OBJ PEGAWAI
            Pengguna userLogin = new Pengguna();

            if (hasil.Read() == true)
            {   //urutan GetValue(0) adalah sesuai dengan SQL yang sudah disusun
                //jika menggunakan select * maka urutan sesuai dengan urutan dalam tabel yang dituju
                userLogin.Nik = hasil.GetValue(0).ToString(); //ambil isi datareader per kolom
                userLogin.Nama_depan = hasil.GetValue(1).ToString();
                userLogin.Nama_keluarga = hasil.GetValue(2).ToString();
                userLogin.Alamat = hasil.GetValue(3).ToString();
                userLogin.Email = hasil.GetValue(4).ToString();
                userLogin.No_telepon = hasil.GetValue(5).ToString();
                userLogin.Tgl_buat = DateTime.Parse(hasil.GetValue(8).ToString());
                userLogin.Tgl_perubahan = DateTime.Parse(hasil.GetValue(9).ToString());
                userLogin.Pertanyaan_proteksi = hasil.GetValue(10).ToString();
                userLogin.Jawaban = hasil.GetValue(11).ToString();

            }
            else //jika username dan pwd tdk terdaftar, kembalikan null
                userLogin = null;
            return userLogin;
        }

        public static void TambahData(Pengguna k)
        {
            string sql= "INSERT INTO pengguna (nik, nama_depan, nama_keluarga, alamat, email, no_telepon, password, pin, tgl_buat, tgl_perubahan, " +
                "pertanyaan_proteksi, jawaban) VALUES('" +k.nik + "', '"+ k.nama_depan + "', '"+ k.nama_keluarga + "', '" +k.alamat + "', '" +
                k.email + "', '" +k.no_telepon + "', SHA2('" + k.password + "',512), " + " SHA2('" + k.pin + "',512), '" + k.tgl_buat.ToString("yyyy-MM-dd") + "', '" +
                k.tgl_perubahan.ToString("yyyy-MM-dd") + "', '" +k.pertanyaan_proteksi + "'," + " SHA2('" + k.jawaban + "',512)" + ");";
            Koneksi.JalankanPerintahNonQuery(sql);
        }


        public static void UbahData(Pengguna k)
        {
            string sql = "UPDATE pengguna SET nama_depan= '" + k.nama_depan +"', nama_keluarga= '" + k.Nama_keluarga+"', alamat= '"+ k.alamat+"', " +
                "email= '"+k.email +"', no_telepon= '"+k.no_telepon+"', tgl_perubahan= '"+ DateTime.Now.ToString("yyyy-MM-dd")+"' WHERE nik= '"+k.nik+"';";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahPassword(Pengguna k)
        {   //hanya untuk mengubah kolom password
            string sql = "UPDATE pengguna SET password=SHA2('" + k.Password + "',512) WHERE nik='" + k.nik+ "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static bool CekPassword(string email, string pwd)
        {
            string sql = "select * from pengguna where email='" + email + "' and password=SHA2('" + pwd + "',512);";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Pengguna cekPasswordLama = new Pengguna();

            Boolean bantuan = false;

            if (hasil.Read() == true)
            {
                cekPasswordLama.password = hasil.GetValue(5).ToString();
                bantuan = true;
            }
            else
                bantuan = false;

            return bantuan;
        }

        public static bool CekPertanyaanProteksi(string nik, string email, string jawaban, string hewan)
        {
            string sql = "select * from pengguna where email='" + email + "' and jawaban=SHA2('" + jawaban + "',512) and nik='"+nik+ "' and pertanyaan_proteksi = '"+hewan+"';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Pengguna cekJawaban = new Pengguna();

            Boolean bantuan = false;

            if (hasil.Read() == true)
            {
                cekJawaban.pertanyaan_proteksi = hasil.GetValue(10).ToString();
                cekJawaban.jawaban = hasil.GetValue(11).ToString();
                bantuan = true;
            }
            else
                bantuan = false;

            return bantuan;
        }

        public static void HapusData(string nik)
        {
            string sql = "delete from pengguna WHERE nik='" + nik + "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static List<Pengguna> BacaData(string kolom = "", string nilai = "")
        {
            // STEP 1. susun perintah query (butuh inner join karena harus ambil nama jabatan)
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from pengguna;";
            else //jika ada filter
                sql = "select * from pengguna where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Pengguna> listData = new List<Pengguna>();
            while (hasil.Read() == true)
            {
                string vNik = hasil.GetValue(0).ToString();
                string vNama = hasil.GetValue(1).ToString();
                string vNamaKeluarga = hasil.GetValue(2).ToString();
                string vAlamat = hasil.GetValue(3).ToString();
                string vEmail = hasil.GetValue(4).ToString();
                string vNotelp = hasil.GetValue(5).ToString();
                DateTime vTgl_buat = DateTime.Parse(hasil.GetValue(8).ToString());
                DateTime vTgl_perubahan = DateTime.Parse(hasil.GetValue(9).ToString());
                string vPertanyaan = hasil.GetValue(10).ToString();

                Pengguna p = new Pengguna(vNik, vNama, vNamaKeluarga, vAlamat, vEmail, vNotelp, "", "", vTgl_buat, vTgl_perubahan, vPertanyaan, "");
                listData.Add(p); //tambahkan objek kategori ke list
            }
            return listData;
        }
        public override string ToString()
        {
            return Nik;
        }
    }
}
