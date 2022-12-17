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
    public partial class FormDaftarPengguna : Form
    {
        public FormDaftarPengguna()
        {
            InitializeComponent();
        }

        private void FormDaftarPengguna_Load(object sender, EventArgs e)
        {
            List<Pengguna> listData = Pengguna.BacaData();
            dataGridViewHasil.DataSource = listData;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kolom = "";
            string nilai = textBoxCari.Text;

            if (comboBoxCari.SelectedIndex == 0)
                kolom = "nik"; //sesuai nama kolom di dbase
            else if (comboBoxCari.SelectedIndex == 1)
                kolom = "nama_depan"; //sesuai nama kolom di dbase
            else if (comboBoxCari.SelectedIndex == 2)
                kolom = "alamat"; //sesuai nama kolom di dbase

            List<Pengguna> listData = Pengguna.BacaData(kolom, nilai);
            dataGridViewHasil.DataSource = listData;
        }
    }
}
