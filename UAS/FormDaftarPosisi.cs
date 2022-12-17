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
    public partial class FormDaftarPosisi : Form
    {
        public FormDaftarPosisi()
        {
            InitializeComponent();
        }

        public List<Posisi> listPosisi = new List<Posisi>();

        public void FormDaftarPosisi_Load(object sender, EventArgs e)
        {
            listPosisi = Posisi.BacaData("", "");

            if (listPosisi.Count > 0)
            {
                dataGridViewHasil.DataSource = listPosisi;
                if (dataGridViewHasil.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "btnUbah";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "btnHapus";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "ID")
            {
                listPosisi = Posisi.BacaData("ID", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama")
            {
                listPosisi = Posisi.BacaData("Nama", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Keterangan")
            {
                listPosisi = Posisi.BacaData("Keterangan", textBoxCari.Text);
            }

            if (listPosisi.Count > 0)
            {
                dataGridViewHasil.DataSource = listPosisi;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPosisi frm = new FormTambahPosisi();
            frm.Owner = this;
            frm.ShowDialog();

            FormDaftarPosisi_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewHasil.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                FormUbahPosisi frm = new FormUbahPosisi();
                frm.Owner = this;
                frm.objYangDiubah = new Posisi();
                frm.objYangDiubah.Id = int.Parse(dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString());
                frm.objYangDiubah.Nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();
                frm.objYangDiubah.Keterangan = dataGridViewHasil.CurrentRow.Cells["Keterangan"].Value.ToString();
                frm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult h = MessageBox.Show("Yakin hapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (h == DialogResult.Yes)
                {
                    string id = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
                    try
                    {
                        Posisi.HapusData(id);
                        MessageBox.Show("Penghapusan data berhasil");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            FormDaftarPosisi_Load(this, e);
        }
    }
}
