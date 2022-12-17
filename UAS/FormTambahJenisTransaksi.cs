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
    public partial class FormTambahJenisTransaksi : Form
    {
        public FormTambahJenisTransaksi()
        {
            InitializeComponent();
        }

        private void FormTambahJenisTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Jenis_Transaksi k = new Jenis_Transaksi(int.Parse(textBoxID.Text), textBoxKode.Text, textBoxNama.Text);
                Jenis_Transaksi.TambahData(k);
                MessageBox.Show("Data Tersimpan", "Berhasil");
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
