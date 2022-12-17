using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace diba
{
    public class Employee
    {
        private int id;
        private string nama_depan;
        private string nama_keluarga;
        private string nik;
        private string email;
        private string password;
        private DateTime tgl_buat;
        private DateTime tgl_perubahan;
        private Posisi jabatan;

        public Employee(int id, string nama_depan, string nama_keluarga, string nik, string email, string password, DateTime tgl_buat, DateTime tgl_perubahan, Posisi jabatan)
        {
            this.id = id;
            this.nama_depan = nama_depan;
            this.nama_keluarga = nama_keluarga;
            this.nik = nik;
            this.email = email;
            this.password = password;
            this.tgl_buat = tgl_buat;
            this.tgl_perubahan = tgl_perubahan;
            this.jabatan = jabatan;
        }

        public Employee()
        {
            this.id = 0;
            this.nama_depan = "";
            this.nama_keluarga = "";
            this.nik = "";
            this.email = "";
            this.password = "";
            this.tgl_buat = DateTime.Now;
            this.tgl_perubahan = DateTime.Now;
            this.jabatan = new Posisi();
        }

        public int Id { get => id; set => id = value; }
        public string Nama_depan { get => nama_depan; set => nama_depan = value; }
        public string Nama_keluarga { get => nama_keluarga; set => nama_keluarga = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Tgl_buat { get => tgl_buat; set => tgl_buat = value; }
        public DateTime Tgl_perubahan { get => tgl_perubahan; set => tgl_perubahan = value; }
        public Posisi Jabatan { get => jabatan; set => jabatan = value; }

        public static Employee CekLoginPegawai(string uid, string pwd)
        {
            string sql = "select * from employee e inner join position p on e.position=p.id  where email='" + uid + "' and password=SHA2('" + pwd + "',512);";

            //SQL asli:
            //select* from pegawai p inner join jabatan j on p.idjabatan = j.idjabatan  where username = 'ani' and password = SHA2('ani', 512);

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. JIKA USERNAME DAN PWD TERDAFTAR, MASUKKAN KE OBJ PEGAWAI
            Employee userLogin = new Employee();

            if (hasil.Read() == true)
            {   //urutan GetValue(0) adalah sesuai dengan SQL yang sudah disusun
                //jika menggunakan select * maka urutan sesuai dengan urutan dalam tabel yang dituju
                userLogin.Id = int.Parse(hasil.GetValue(0).ToString()); //ambil isi datareader per kolom
                userLogin.Nama_depan = hasil.GetValue(1).ToString();
                userLogin.Nama_keluarga = hasil.GetValue(2).ToString();
                userLogin.Nik = hasil.GetValue(4).ToString();
                userLogin.Email = hasil.GetValue(5).ToString();
                userLogin.Tgl_buat = DateTime.Parse(hasil.GetValue(7).ToString());
                userLogin.Tgl_perubahan = DateTime.Parse(hasil.GetValue(8).ToString());

                Posisi p = new Posisi();
                p.Id = int.Parse(hasil.GetValue(9).ToString());
                p.Nama = hasil.GetValue(10).ToString();
                p.Keterangan= hasil.GetValue(11).ToString();
                userLogin.Jabatan = p;

            }
            else //jika username dan pwd tdk terdaftar, kembalikan null
                userLogin = null;
            return userLogin;
        }

        public static void TambahData(Employee e)
        {
            string sql = "INSERT INTO employee (id, nama_depan, nama_keluarga, position, nik, email, password, tgl_buat, tgl_perubahan) VALUES('"+e.id + "', '" +
                e.nama_depan + "', '" + e.nama_keluarga + "', '" + e.jabatan.Id + "', '" + e.nik + "', '" + e.email + "', SHA2('" + e.password + "',512), '" + e.tgl_perubahan.ToString("yyyy-MM-dd") + "', '" +
                e.tgl_perubahan.ToString("yyyy-MM-dd") + "');";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UbahData(Employee e)
        {
            string sql = "UPDATE employee SET nama_depan='" + e.nama_depan + "', nama_keluarga='" + e.nama_keluarga + "', position='" + e.jabatan.Id + "', email='" +
                e.email + "', tgl_perubahan='" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE id='" + e.id + "';";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void HapusData(string kode)
        {
            string sql = "delete from employee WHERE id='" + kode + "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }


        public static List<Employee> BacaData(string kolom = "", string nilai = "")
        {
            // STEP 1. susun perintah query (butuh inner join karena harus ambil nama jabatan)
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from employee e inner join position p on e.position=p.id;";
            else //jika ada filter
                sql = "select * from employee e inner join position p on e.position=p.id where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Employee> listData = new List<Employee>();
            while (hasil.Read() == true)
            {
                int vId = int.Parse(hasil.GetValue(0).ToString()); //ambil isi datareader per kolom
                string vNama_depan = hasil.GetValue(1).ToString();
                string vNama_kel = hasil.GetValue(2).ToString();
                string vNik = hasil.GetValue(4).ToString();
                string vEmail = hasil.GetValue(5).ToString();
                DateTime vTgl_buat = DateTime.Parse(hasil.GetValue(7).ToString());
                DateTime vTgl_perubahan = DateTime.Parse(hasil.GetValue(8).ToString());

                int pId = int.Parse(hasil.GetValue(9).ToString());
                string pNama= hasil.GetValue(10).ToString();
                string pKet = hasil.GetValue(11).ToString();

                Posisi vPosisi = new Posisi(pId, pNama, pKet);

                //kosongi password, karena tdk boleh membaca password orang lain
                Employee k = new Employee(vId, vNama_depan, vNama_kel, vNik,vEmail,"",vTgl_buat,vTgl_perubahan,vPosisi);
                listData.Add(k); //tambahkan objek kategori ke list
            }
            return listData;
        }

    }
}
