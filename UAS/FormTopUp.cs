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
    public partial class FormTopUp : Form
    {
        public FormTopUp()
        {
            InitializeComponent();
        }

        private void textBox_Nominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_TopUp_Click(object sender, EventArgs e)
        {
            try
            {
                Transaksi t = new Transaksi(rekening_sumber: "TOP_UP", id_jenis_transaksi: 0, rekening_tujuan: "", nominal: 1000, keterangan: "");

                Transaksi.TambahData(t);

                MessageBox.Show("Data Tersimpan", "Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal, pesan = " + ex.Message, "ERROR");
            }
        }
    }
}
