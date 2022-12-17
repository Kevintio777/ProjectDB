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

namespace UAS
{
    public partial class FormTambahEmployee : Form
    {
        public FormTambahEmployee()
        {
            InitializeComponent();
        }

        private void FormTambahEmployee_Load(object sender, EventArgs e)
        {
            List<Posisi> listData = Posisi.BacaData();
            comboBoxJabatan.DataSource= listData;
            comboBoxJabatan.DisplayMember = "Nama";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {//pengecekan data yang harus diisi
            if(textBoxID.TextLength != 0 && textBoxNama.TextLength != 0 && textBoxNik.TextLength == 16 && textBoxEmail.TextLength != 0 && textBoxPassword.TextLength !=0
                && comboBoxJabatan.SelectedIndex != -1)
            {
                if (textBoxPassword.Text == textBoxUlangPassword.Text)
                {
                    int vId = int.Parse(textBoxID.Text);
                    string vNamaDepan = textBoxNama.Text;
                    string vNamaKeluarga = textBoxNamaKeluarga.Text;
                    string vNik = textBoxNik.Text;
                    string vEmail = textBoxEmail.Text;
                    string vPassword = textBoxPassword.Text;
                    Posisi vJabatan = (Posisi)comboBoxJabatan.SelectedItem;

                    Employee emp = new Employee(vId, vNamaDepan, vNamaKeluarga, vNik, vEmail, vPassword, DateTime.Now, DateTime.Now, vJabatan);
                    try
                    {
                        Employee.TambahData(emp);
                        MessageBox.Show("Penambahan data berhasil");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error. Pesan kesalahan: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Konfirmasi password tidak sama");
                    textBoxUlangPassword.Text = "";
                    textBoxPassword.Text = "";
                    textBoxPassword.Focus();
                }
            }
            else if (textBoxID.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi ID");
                textBoxID.Focus();
            }
            else if (textBoxNik.TextLength != 16)
            {
                MessageBox.Show("NIK diperlukan 16 digit");
                textBoxNik.Text = "";
                textBoxNik.Focus();
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
            else if (textBoxPassword.TextLength == 0)
            {
                MessageBox.Show("Anda belum mengisi password");
                textBoxPassword.Focus();
            }
            else if (comboBoxJabatan.SelectedIndex == -1)
            {
                MessageBox.Show("Anda belum memilih jabatan");
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }

        private void textBoxNik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }
    }
}
