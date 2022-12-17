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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string vJawaban = textBoxJawaban.Text;
            string vEmail= textBoxEmail.Text;
            string vNik = textBoxNIK.Text;
            string vPertanyaan = "";

            if (comboBoxPertanyaanProteksi.SelectedIndex == 0)
            {
                vPertanyaan = "IBU";
            }
            else
                vPertanyaan = "HEWAN";

            bool jawaban = Pengguna.CekPertanyaanProteksi(vNik, vEmail, vJawaban, vPertanyaan);

            if (jawaban is false)
            {
                MessageBox.Show("Data diri anda salah");
                textBoxNIK.Text = "";
                textBoxEmail.Text = "";
                textBoxJawaban.Text = "";
                textBoxNIK.Focus();
            }
            else
            {
                if (textBoxPWDBaru.Text == textBoxPWDUlangBaru.Text)
                {
                    string vPwdBaru = textBoxPWDBaru.Text;

                    Pengguna p = new Pengguna(vNik, "", "", "", "", "", vPwdBaru, "", DateTime.Now, DateTime.Now, "", "");
                    try
                    {
                        Pengguna.UbahPassword(p);
                        MessageBox.Show("Penggantian Password berhasil");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error. Pesan kesalahan: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Konfirmasi password tidak sama");
                    textBoxPWDBaru.Text = "";
                    textBoxPWDUlangBaru.Text = "";
                    textBoxPWDBaru.Focus();
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //agar hanya bisa memasukkan angka dan backspace
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }
    }
}
