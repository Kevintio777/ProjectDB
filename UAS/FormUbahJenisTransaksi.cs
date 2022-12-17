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
    public partial class FormUbahJenisTransaksi : Form
    {
        public FormUbahJenisTransaksi()
        {
            InitializeComponent();
        }
        public Jenis_Transaksi objYangDiubah;
        private void FormUbahJenisTransaksi_Load(object sender, EventArgs e)
        {
            textBoxID.Text = objYangDiubah.Id.ToString();
            textBoxKode.Text = objYangDiubah.Kode;
            textBoxNama.Text = objYangDiubah.Nama;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Jenis_Transaksi k = new Jenis_Transaksi(int.Parse(textBoxID.Text), textBoxKode.Text, textBoxNama.Text);
                Jenis_Transaksi.UpdateData(k);
                MessageBox.Show("Data Kategori Tersimpan", "Berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal, pesan = " + ex.Message, "ERROR");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {

            FormDaftarJenisTransaksi frm = (FormDaftarJenisTransaksi)this.Owner;
            frm.FormDaftarJenisTransaksi_Load(buttonKeluar, e);
            this.Close();
        }
    }
}
