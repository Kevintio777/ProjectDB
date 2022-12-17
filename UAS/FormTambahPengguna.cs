using diba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS
{
    public partial class FormTambahPengguna : Form
    {
        public FormTambahPengguna()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //data yang diisi harus benar
            if (textBoxNIK.TextLength == 16 && textBoxNama.TextLength != 0 && textBoxEmail.TextLength != 0 && textBoxNoTelp.TextLength != 0 &&
                textBoxPassword.TextLength != 0 && textBoxJawaban.TextLength != 0)
            {
                if (textBoxPassword.Text == textBoxUlangPassword.Text && textBoxJawaban.Text == textBoxUlangJawaban.Text
                    && comboBoxPertanyaanProteksi.SelectedIndex != -1)
                {
                    string vNik = textBoxNIK.Text;
                    string vNama = textBoxNama.Text;
                    string vNamaKeluarga = textBoxNamaKeluarga.Text;
                    string vAlamat = textBoxAlamat.Text;
                    string vEmail = textBoxEmail.Text;
                    string vNotelp = textBoxNoTelp.Text;
                    string vPassword = textBoxPassword.Text;
                    DateTime vTgl_buat = DateTime.Now;
                    DateTime vTgl_perubahan = DateTime.Now;
                    string vPertanyaan = "";
                    if (comboBoxPertanyaanProteksi.SelectedIndex == 0)
                    {
                        vPertanyaan = "IBU";
                    }
                    else
                    {
                        vPertanyaan = "HEWAN";
                    }
                    string vJawaban = textBoxJawaban.Text;
                    Pengguna p = new Pengguna(vNik, vNama, vNamaKeluarga, vAlamat, vEmail, vNotelp, vPassword, "", vTgl_buat, vTgl_perubahan, vPertanyaan, vJawaban);
                    try
                    {
                        Pengguna.TambahData(p);
                        MessageBox.Show("Anda Berhasil Melakukan Pendaftaran ");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error. Pesan kesalahan: " + ex.Message);
                    }
                }
                else if (textBoxPassword.Text != textBoxUlangPassword.Text)
                {
                    MessageBox.Show("Konfirmasi password tidak sama");
                    textBoxUlangPassword.Text = "";
                    textBoxPassword.Text = "";
                    textBoxPassword.Focus();
                }
                else if (textBoxJawaban.Text != textBoxUlangJawaban.Text)
                {
                    MessageBox.Show("Konfirmasi jawaban pertanyaan proteksi tidak sama");
                    textBoxUlangJawaban.Text = "";
                    textBoxJawaban.Text = "";
                    textBoxJawaban.Focus();
                }
                else if (comboBoxPertanyaanProteksi.SelectedIndex == -1)
                {
                    MessageBox.Show("Pertanyaan proteksi pilihan perlu dipilih");
                }
            }
            else if (textBoxNIK.TextLength != 16)
            {
                MessageBox.Show("NIK diperlukan 16 digit");
                textBoxNIK.Text = "";
                textBoxNIK.Focus();
            }
            else if (textBoxNama.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi nama");
                textBoxNama.Focus();
            }
            else if (textBoxEmail.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi email");
                textBoxEmail.Focus();
            }
            else if (textBoxNoTelp.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi nomor telepon");
                textBoxNoTelp.Focus();
            }
            else if (textBoxPassword.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi password");
                textBoxPassword.Focus();
            }
            else if (textBoxJawaban.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi jawaban pertanyaan proteksi");
                textBoxJawaban.Focus();
            }

            
            

        }
        private void FormTambahPengguna_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPin_KeyPress(object sender, KeyPressEventArgs e)
        {//agar hanya bisa memasukkan angka dan backspace
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled= true;
            }
        }

        private void textBoxNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }

        private void textBoxUlangPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }
    }
}
