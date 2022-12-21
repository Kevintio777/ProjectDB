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
    public partial class FormDaftarTabungan : Form
    {
        public FormDaftarTabungan()
        {
            InitializeComponent();
        }

        private void FormDaftarTabungan_Load(object sender, EventArgs e)
        {
            List<Tabungan> listData = Tabungan.Bacadata("", "");
            if (listData.Count > 0)
            {
                dataGridViewHasil.DataSource = listData;
                if (dataGridViewHasil.Columns.Count < 4)
                {
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "ACTION";
                    bcol2.Text = "delete";
                    bcol2.Name = "btnGridDelete";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol2);
                }
            }
        }
        public Pengguna pgn = new Pengguna();

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.ColumnIndex == dataGridViewHasil.Columns["btnGridDelete"].Index && e.RowIndex >= 0)
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
            FormDaftarTabungan_Load(this, e);
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahTabungan form = new FormTambahTabungan();
            form.Owner = this;
            form.ShowDialog();
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
