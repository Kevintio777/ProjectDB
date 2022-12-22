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
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_RekeningTujuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_Nominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_Transfer_Click(object sender, EventArgs e)
        {
            string no_rekening_sumber = CredentialStore.NoRekening;
            string no_rekening_tujuan = textBox_RekeningTujuan.Text;
            int nominal = int.Parse(textBox_Nominal.Text);
            Tabungan tabungan_sumber = Tabungan.Bacadata("no_rekening", no_rekening_sumber)[0];
            Tabungan tabungan_tujuan = Tabungan.Bacadata("no_rekening", no_rekening_tujuan)[0];
            try
            {
               
                Transaksi t = new Transaksi(rekening_sumber: no_rekening_sumber, id_jenis_transaksi: 0, rekening_tujuan: no_rekening_tujuan, nominal: nominal, keterangan: textBox_keterangan.Text);

                Transaksi.TambahData(t);

                tabungan_sumber.Saldo -= nominal;
                tabungan_tujuan.Saldo += nominal;

                Tabungan.UpdateData(tabungan_sumber);
                Tabungan.UpdateData(tabungan_tujuan);

                MessageBox.Show("TOP UP Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("TOP UP Gagal, pesan = " + ex.Message, "ERROR");
            }
        }

        private void Keterangan_Click(object sender, EventArgs e)
        {

        }

        private void textBox_keterangan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
