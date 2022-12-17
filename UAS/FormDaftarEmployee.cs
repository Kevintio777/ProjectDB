using diba;
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

namespace UAS
{
    public partial class FormDaftarEmployee : Form
    {
        public FormDaftarEmployee()
        {
            InitializeComponent();
        }

        private void FormDaftarEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> listData = Employee.BacaData();
            dataGridViewHasil.DataSource= listData;

            if (dataGridViewHasil.ColumnCount == 9)
            {   // membuat button dalam datagridview
                DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
                b1.HeaderText = "Aksi"; //judul kolom
                b1.Text = "ubah"; //text pada button
                b1.Name = "btnUbah"; //nama button dalam programming
                b1.UseColumnTextForButtonValue = true; //tampilkan text pada button
                dataGridViewHasil.Columns.Add(b1); //tambahkan button ke gridview

                DataGridViewButtonColumn b2 = new DataGridViewButtonColumn();
                b2.HeaderText = "Aksi";
                b2.Text = "hapus";
                b2.Name = "btnHapus";
                b2.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(b2);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahEmployee frm = new FormTambahEmployee();
            frm.Owner= this;
            frm.ShowDialog();
            FormDaftarEmployee_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewHasil.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {   //buat formubahpegawai dulu (kopi dari tambahpegawai)
                FormUbahEmployee frm = new FormUbahEmployee();
                frm.Owner = this;
                string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
                List<Employee> listData = Employee.BacaData("e.id", kode); //menghasilkan 1data saja
                frm.objYangDiubah = listData[0]; //ambil data pertama dari list
                frm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult h = MessageBox.Show("Yakin hapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo); //KONFIRMASI PENGHAPUSAN KE USER
                if (h == DialogResult.Yes) //JIKA USER MEMILIH YES UNTUK HAPUS DATA
                {   //LAKUKAN PENGHAPUSAN DATA
                    string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
                    try
                    {
                        Employee.HapusData(kode);
                        MessageBox.Show("Penghapusan data berhasil");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            FormDaftarEmployee_Load(this, e);
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
                kolom = "e.id"; //sesuai nama kolom di dbase
            else if (comboBoxCari.SelectedIndex == 1)
                kolom = "e.nama_depan"; //sesuai nama kolom di dbase
            else if (comboBoxCari.SelectedIndex == 2)
                kolom = "p.nama"; //sesuai nama kolom di dbase

            List<Employee> listData = Employee.BacaData(kolom, nilai);
            dataGridViewHasil.DataSource = listData;
        }
    }
}
