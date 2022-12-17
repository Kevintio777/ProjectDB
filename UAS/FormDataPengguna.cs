using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diba;
using Microsoft.VisualBasic;

namespace UAS
{
    public partial class FormDataPengguna : Form
    {
        public FormDataPengguna()
        {
            InitializeComponent();
        }

        public Pengguna objYangDiubah;

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult h = MessageBox.Show("Yakin Hapus Data? Data yang dihapus tidak akan kembali.", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (h == DialogResult.Yes)
            {

                //untuk menampilkan seperti message box tetapi bisa di input
                string konfirmasiHapus = Interaction.InputBox("Diperlukan Password untuk melakukan penghapusan akun", "Hapus Akun");

                bool pwd = Pengguna.CekPassword(objYangDiubah.Email, konfirmasiHapus);

                if (konfirmasiHapus == "")
                {
                    FormDataPengguna_Load(this, e);
                }
                else
                {
                    if (pwd is false) // jika password tidak sesuai
                    {
                        MessageBox.Show("Password tidak sesuai");
                    }
                    else
                    {
                        try //hapus data
                        {
                            FormUtama frm = new FormUtama();
                            Pengguna.HapusData(objYangDiubah.Nik);
                            MessageBox.Show("Penghapusan data berhasil");
                            frm = (FormUtama)this.Owner;
                            frm.userLogin = null;

                            this.Close();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Error: " + x.Message);
                        }
                    }
                }
                

                
            }
        }

        private void FormDataPengguna_Load(object sender, EventArgs e)
        {
            labelNamaDepan.Text = objYangDiubah.Nama_depan;
            labelNamaKeluarga.Text = objYangDiubah.Nama_keluarga;
            labelAlamat.Text = objYangDiubah.Alamat;
            labelEmail.Text = objYangDiubah.Email;
            labelNoTelp.Text = objYangDiubah.No_telepon;

            textBoxNama.Text = objYangDiubah.Nama_depan;
            textBoxNamaKeluarga.Text = objYangDiubah.Nama_keluarga;
            textBoxAlamat.Text = objYangDiubah.Alamat;
            textBoxEmail.Text = objYangDiubah.Email;
            textBoxNoTelp.Text = objYangDiubah.No_telepon;

            TextBoxUnvisible();

            buttonSimpan.Visible=false;
        }

        private void LabelVisible()
        {
            labelNamaDepan.Visible = true;
            labelNamaKeluarga.Visible = true;
            labelAlamat.Visible = true;
            labelEmail.Visible = true;
            labelNoTelp.Visible = true;
        }

        private void LabelUnvisible()
        {
            labelNamaDepan.Visible = false;
            labelNamaKeluarga.Visible = false;
            labelAlamat.Visible = false;
            labelEmail.Visible = false;
            labelNoTelp.Visible = false;
        }

        private void TextBoxVisible()
        {
            textBoxNama.Visible = true;
            textBoxNamaKeluarga.Visible = true;
            textBoxAlamat.Visible = true;
            textBoxEmail.Visible = true;
            textBoxNoTelp.Visible = true;
        }

        private void TextBoxUnvisible()
        {
            textBoxNama.Visible = false;
            textBoxNamaKeluarga.Visible = false;
            textBoxAlamat.Visible = false;
            textBoxEmail.Visible = false;
            textBoxNoTelp.Visible = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            LabelUnvisible();

            TextBoxVisible();

            buttonSimpan.Visible= true;
            buttonEdit.Visible=false;
            buttonHapus.Visible= false; 
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string vNama = textBoxNama.Text;
            string vNamaKeluarga = textBoxNamaKeluarga.Text;
            string vAlamat = textBoxAlamat.Text;
            string vEmail = textBoxEmail.Text;
            string vNotelp = textBoxNoTelp.Text;
            DateTime vTgl_perubahan = DateTime.Now;

            Pengguna p = new Pengguna(objYangDiubah.Nik, vNama, vNamaKeluarga, vAlamat, vEmail, vNotelp, "", "", objYangDiubah.Tgl_buat, vTgl_perubahan, "", "");
            try
            {
                Pengguna.UbahData(p);

                LabelVisible();
                TextBoxUnvisible();
                buttonEdit.Visible = true;
                buttonHapus.Visible = true;
                buttonSimpan.Visible = false;

                labelNamaDepan.Text = vNama;
                labelNamaKeluarga.Text = vNamaKeluarga;
                labelAlamat.Text = vAlamat;
                labelEmail.Text = vEmail;
                labelNoTelp.Text = vNotelp;

                MessageBox.Show("Penggantian data berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Pesan kesalahan: " + ex.Message);
            }
        }

        private void textBoxNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    
}
