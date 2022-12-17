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
    public partial class FormTambahPosisi : Form
    {
        public FormTambahPosisi()
        {
            InitializeComponent();
        }

        private void FormTambahPosisi_Load(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPosisi frm = (FormDaftarPosisi)this.Owner;
            frm.FormDaftarPosisi_Load(buttonKeluar, e);
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Posisi p = new Posisi(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxKeterangan.Text);
                Posisi.TambahData(p);
                MessageBox.Show("Data Posisi Telah Disimpan.", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Posisi Gagal Disimpan. Pesan Kesalahan :", ex.Message);
            }
        }
    }
}
