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
    public partial class FormUbahPosisi : Form
    {

        public Posisi objYangDiubah;
        public FormUbahPosisi()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPosisi frm = (FormDaftarPosisi)this.Owner;
            frm.FormDaftarPosisi_Load(buttonKeluar, e);
            this.Close();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Posisi p = new Posisi(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxKeterangan.Text);
                Posisi.UbahData(p);
                MessageBox.Show("Data Posisi Telah Disimpan.", "Info");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Posisi Gagal Disimpan. Pesan Kesalahan :", ex.Message);
            }
        }

        private void FormUbahPosisi_Load(object sender, EventArgs e)
        {
            textBoxID.Text = objYangDiubah.Id.ToString();
            textBoxNama.Text = objYangDiubah.Nama;
            textBoxKeterangan.Text = objYangDiubah.Keterangan;
        }
    }
}
