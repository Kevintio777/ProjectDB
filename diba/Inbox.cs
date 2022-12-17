using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace diba
{
    public class Inbox
    {
        private Pengguna idUser;
        private int idPesan;
        private string pesan;
        private DateTime tglKirim;
        private string status;
        private DateTime tglPerubahan;

        //private string idUser;
        //private int idPesan;
        //private string pesan;
        //private DateTime tglKirim;
        //private string status;
        //private DateTime tglPerubahan;

        //public Inbox(string idUser, int idPesan, string pesan, DateTime tglKirim, string status, DateTime tglPerubahan)
        //{
        //    this.IdUser = idUser;
        //    this.IdPesan = idPesan;
        //    this.Pesan = pesan;
        //    this.TglKirim = tglKirim;
        //    this.Status = status;
        //    this.TglPerubahan = tglPerubahan;
        //}

        //public Inbox()
        //{
        //    this.IdUser = "";
        //    this.IdPesan = 0;
        //    this.Pesan = "";
        //    this.TglKirim = DateTime.Now;
        //    this.Status = "";
        //    this.TglPerubahan = DateTime.Now;
        //}

        //public string IdUser { get => idUser; set => idUser = value; }
        //public int IdPesan { get => idPesan; set => idPesan = value; }
        //public string Pesan { get => pesan; set => pesan = value; }
        //public DateTime TglKirim { get => tglKirim; set => tglKirim = value; }
        //public string Status { get => status; set => status = value; }
        //public DateTime TglPerubahan { get => tglPerubahan; set => tglPerubahan = value; }



        public Pengguna IdUser { get => idUser; set => idUser = value; }
        public int IdPesan { get => idPesan; set => idPesan = value; }
        public string Pesan { get => pesan; set => pesan = value; }
        public DateTime TglKirim { get => tglKirim; set => tglKirim = value; }
        public string Status { get => status; set => status = value; }
        public DateTime TglPerubahan { get => tglPerubahan; set => tglPerubahan = value; }

        public Inbox(Pengguna pIdUser, int pIdPesan, string pPesan, DateTime pTglKirim, string pStatus, DateTime pTglPerubahan)
        {
            this.IdUser = pIdUser;
            this.IdPesan = pIdPesan;
            this.Pesan = pPesan;
            this.TglKirim = pTglKirim;
            this.Status = pStatus;
            this.TglPerubahan = pTglPerubahan;
        }

        public Inbox()
        {
            this.IdUser = new Pengguna();
            this.IdPesan = 0;
            this.Pesan = "";
            this.TglKirim = DateTime.Now;
            this.Status = "";
            this.TglPerubahan = DateTime.Now;
        }

        public static List<Inbox> BacaData(string kolom = "", string nilai = "")
        {
            // STEP 1. susun perintah query (butuh inner join karena harus ambil nama jabatan)
            string sql;
                        
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select p.nik as 'NIK', i.id_pesan as 'ID Pesan', i.pesan as 'Pesan', i.tanggal_kirim as 'Tanggal Kirim' , " + 
                    "i.status as 'Status', i.tgl_perubahan as 'Tanggal Perubahan'from pengguna p inner join inbox i on p.nik = i.id_pengguna;";
            else //jika ada filter
                sql = "select p.nik as 'NIK', i.id_pesan as 'ID Pesan', i.pesan as 'Pesan', i.tanggal_kirim as 'Tanggal Kirim' , " + 
                    " i.status as 'Status', i.tgl_perubahan as 'Tanggal Perubahan'from pengguna p inner join inbox i on p.nik = i.id_pengguna where " + kolom + " like '%" + nilai + "%';";

           
            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Inbox> listData = new List<Inbox>();
            while (hasil.Read() == true)
            {
                Pengguna pgn = new Pengguna();
                pgn.Nik = hasil.GetValue(0).ToString();

                Inbox ibx = new Inbox();
                ibx.IdUser = pgn;
                ibx.IdPesan = int.Parse(hasil.GetValue(1).ToString());
                ibx.Pesan = hasil.GetValue(2).ToString();
                ibx.TglKirim = DateTime.Parse(hasil.GetValue(3).ToString());
                ibx.Status = hasil.GetValue(4).ToString();
                ibx.TglPerubahan = DateTime.Parse(hasil.GetValue(5).ToString());
                listData.Add(ibx);

                //string vNik = hasil.GetValue(0).ToString();
                //int vIdPesan = int.Parse(hasil.GetValue(1).ToString());
                //string vPesan = hasil.GetValue(2).ToString();
                //DateTime vTglKirim = DateTime.Parse(hasil.GetValue(3).ToString());
                //string vStatus = hasil.GetValue(4).ToString();
                //DateTime vTglPerubahan = DateTime.Parse(hasil.GetValue(5).ToString());
                //Inbox i = new Inbox(vNik, vIdPesan, vPesan, vTglKirim, vStatus, vTglPerubahan);
                //listData.Add(i); 
            }
            return listData;
        }
        public static void HapusData(string kode)
        {
            string sql = "delete from inbox WHERE id_pengguna='" + kode + "';";
            Koneksi.JalankanPerintahNonQuery(sql);            
        }        
    }
}
