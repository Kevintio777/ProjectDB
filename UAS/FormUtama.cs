using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diba;

namespace UAS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        public Pengguna userLogin;
        public Employee pegawaiLogin;

        public void FormUtama_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            if (userLogin is null && pegawaiLogin is null)
            {
                labelLogin.Text = "Selamat datang";
                buttonDaftar.Visible = true;
                buttonLogin.Visible = true;
                buttonKeluar.Visible = false;
                akunToolStripMenuItemAkun.Visible = false;
                pengggunaSementaraToolStripMenuItem.Visible = false;
            }
            else if (userLogin != null)
            {
                labelLogin.Text = "Anda login sebagai " + userLogin.Nama_depan;
                buttonDaftar.Visible = false;
                buttonLogin.Visible = false;
                buttonKeluar.Visible = true;
                akunToolStripMenuItemAkun.Visible = true;
                pengggunaSementaraToolStripMenuItem.Visible = false;
            }
            else if (pegawaiLogin != null)
            {
                labelLogin.Text = "-EMPLOYEE-  Anda Login sebagai " + pegawaiLogin.Nama_depan + " - " + pegawaiLogin.Jabatan.Nama;
                buttonDaftar.Visible = false;
                buttonLogin.Visible = false;
                buttonKeluar.Visible = true;
                akunToolStripMenuItemAkun.Visible = false;
                pengggunaSementaraToolStripMenuItem.Visible = true;
                AturMenu(pegawaiLogin.Jabatan.Id);
            }

            try
            {
                //Koneksi k = new Koneksi(db.Default.dbserver, db.Default.dbname, db.Default.dbUID, db.Default.dbPWD);
                Koneksi k = new Koneksi();
                //MessageBox.Show("Koneksi Berhasil");
                
                
            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }

        private void AturMenu (int idJabatan)
        {
            
            if (idJabatan == 7)//Manajer IT
            {
                pengggunaSementaraToolStripMenuItem.Visible =true;
            }
            else if(idJabatan == 6)//customer service
            {
                pengggunaSementaraToolStripMenuItem.Visible = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Owner = this;
            frm.ShowDialog();
            FormUtama_Load(this, e);

        }

        public void buttonKeluar_Click(object sender, EventArgs e)
        {
            labelLogin.Text = "Selamat datang";
            buttonDaftar.Visible = true;
            buttonLogin.Visible = true;
            userLogin = null;
            pegawaiLogin = null;
            FormUtama_Load(this, e);
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahPengguna"];

            if (form == null)
            {
                FormTambahPengguna frm = new FormTambahPengguna();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }

        private void tabunganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataPengguna frm = new FormDataPengguna();
            frm.Owner = this;
            string nik = userLogin.Nik.ToString();
            List<Pengguna> listData = Pengguna.BacaData("nik", nik);
            frm.objYangDiubah = listData[0];
            frm.ShowDialog();
            FormUtama_Load(this, e);
        }

        private void pengggunaSementaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUbahPassword frm = new FormUbahPassword();
            frm.Owner = this;
            string nik = userLogin.Nik.ToString();
            List<Pengguna> listData = Pengguna.BacaData("nik", nik);
            frm.Pwdyangdiubah = listData[0];
            frm.ShowDialog();
        }

        private void daftarPenggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPengguna"];

            if (form == null)
            {
                FormDaftarPengguna frm = new FormDaftarPengguna();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }

        private void posisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPosisi"];

            if (form == null)
            {
                FormDaftarPosisi frm = new FormDaftarPosisi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void jenisTransaskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJenisTransaksi"];

            if (form == null)
            {
                FormDaftarJenisTransaksi frm = new FormDaftarJenisTransaksi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void dafarEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarDaftarEmployee"];

            if (form == null)
            {
                FormDaftarEmployee frm = new FormDaftarEmployee();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarInbox"];

            if (form == null)
            {
                FormDaftarInbox frm = new FormDaftarInbox();
                frm.MdiParent = this;
                string nik = userLogin.Nik.ToString();
                List<Pengguna> listData = Pengguna.BacaData("nik", nik);
                frm.pgn = listData[0];
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void daftarTabunganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarTabungan"];

            if (form == null)
            {
                FormDaftarTabungan frm = new FormDaftarTabungan();
                frm.MdiParent = this;
                string nik = userLogin.Nik.ToString();
                List<Pengguna> listData = Pengguna.BacaData("nik", nik);
                frm.pgn = listData[0];
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
