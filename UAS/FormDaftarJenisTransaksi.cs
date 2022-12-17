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
    public partial class FormDaftarJenisTransaksi : Form
    {
        public FormDaftarJenisTransaksi()
        {
            InitializeComponent();
        }

        public void FormDaftarJenisTransaksi_Load(object sender, EventArgs e)
        {
            List<Jenis_Transaksi> listData = Jenis_Transaksi.Bacadata("", "");
            if (listData.Count > 0)
            {
                dataGridViewHasil.DataSource = listData;
                if (dataGridViewHasil.Columns.Count < 4)
                {

                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "ACTION";
                    bcol.Text = "ubah";
                    bcol.Name = "btnGridUbah";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "ACTION";
                    bcol2.Text = "delete";
                    bcol2.Name = "btnGridDelete";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol2);
                }
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kolom = "";
            string nilai = textBoxCari.Text;

            if (comboBoxCari.SelectedIndex == 0)
                kolom = "Id_jenis_transaksi";
            else if (comboBoxCari.SelectedIndex == 1)
                kolom = "Kode";
            else if (comboBoxCari.SelectedIndex == 2)
                kolom = "Nama";

            List<Jenis_Transaksi> listData = Jenis_Transaksi.Bacadata(kolom, nilai);
            dataGridViewHasil.DataSource = listData;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisTransaksi f = new FormTambahJenisTransaksi();
            f.Owner = this;
            f.ShowDialog();

            FormDaftarJenisTransaksi_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewHasil.Columns["btnGridUbah"].Index && e.RowIndex >= 0)
            {
                FormUbahJenisTransaksi frm = new FormUbahJenisTransaksi();
                frm.Owner = this;
                frm.objYangDiubah = new Jenis_Transaksi();
                frm.objYangDiubah.Id = int.Parse(dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString());
                frm.objYangDiubah.Kode = dataGridViewHasil.CurrentRow.Cells["Kode"].Value.ToString();
                frm.objYangDiubah.Nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();
                frm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["btnGridDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult h = MessageBox.Show("Yakin hapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo); //KONFIRMASI PENGHAPUSAN KE USER
                if (h == DialogResult.Yes)
                {
                    string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
                    try
                    {
                        Jenis_Transaksi.DeleteData(kode);
                        MessageBox.Show("Penghapusan data berhasil");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            FormDaftarJenisTransaksi_Load(this, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
