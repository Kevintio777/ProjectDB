using diba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UAS
{
    public partial class FormUbahPassword : Form
    {
        public FormUbahPassword()
        {
            InitializeComponent();
        }

        public Pengguna Pwdyangdiubah;

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string vPwdLama = textBoxPWDLama.Text;
            // cek terlebih dahulu password lama benar atau tidak
            bool pwdLama = Pengguna.CekPassword(Pwdyangdiubah.Email, vPwdLama);


            //jika password lama yang dimasukkan sama dengan password baru yang dimasukkan
            if (textBoxPWDLama.Text == textBoxPWDBaru.Text)
            {
                MessageBox.Show("Password baru yang anda masukkan sama dengan password lama");
                textBoxPWDBaru.Text = "";
                textBoxPWDUlangBaru.Text = "";
                textBoxPWDBaru.Focus();
            }
            else
            {
                // jika salah
                if (pwdLama is false)
                {
                    MessageBox.Show("Password Lama tidak sesuai");
                    textBoxPWDLama.Text = "";
                    textBoxPWDLama.Focus();
                }
                else // jika benar
                {
                    if (textBoxPWDBaru.Text == textBoxPWDUlangBaru.Text)
                    {
                        string vPwdBaru = textBoxPWDBaru.Text;

                        Pengguna p = new Pengguna(Pwdyangdiubah.Nik, "", "", "", "", "", vPwdBaru, "", DateTime.Now, DateTime.Now, "", "");
                        try
                        {
                            Pengguna.UbahPassword(p);
                            MessageBox.Show("Penggantian data berhasil");
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


        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
