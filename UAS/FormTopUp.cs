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
            string no_rekening = CredentialStore.NoRekening;
            try
            {

                int nominal = int.Parse(textBox_Nominal.Text);
                Transaksi t = new Transaksi(rekening_sumber: "TOP_UP", id_jenis_transaksi: 0, rekening_tujuan: no_rekening, nominal: nominal, keterangan:"" );

                Transaksi.TambahData(t);

                Tabungan k = Tabungan.Bacadata("no_rekening", no_rekening)[0];
                k.Saldo += nominal;

                Tabungan.UpdateData(k);

                MessageBox.Show("TOP UP Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("TOP UP Gagal, pesan = " + ex.Message, "ERROR");
            }
        }
    }
}
