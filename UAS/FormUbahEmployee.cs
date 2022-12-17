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
    public partial class FormUbahEmployee : Form
    {
        public FormUbahEmployee()
        {
            InitializeComponent();
        }
        public Employee objYangDiubah;

        private void FormUbahEmployee_Load(object sender, EventArgs e)
        {
            List<Posisi> listData = Posisi.BacaData();
            comboBoxJabatan.DataSource= listData;
            comboBoxJabatan.DisplayMember= "Nama";  

            textBoxKode.Text = objYangDiubah.Id.ToString();
            textBoxNamaDepan.Text = objYangDiubah.Nama_depan;
            textBoxNamaKeluarga.Text = objYangDiubah.Nama_keluarga;
            textBoxEmail.Text= objYangDiubah.Email;
            comboBoxJabatan.SelectedItem = objYangDiubah.Jabatan.Nama;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            int vId = int.Parse(textBoxKode.Text);
            string vNamaDepan = textBoxNamaDepan.Text;
            string vNamaKeluarga = textBoxNamaKeluarga.Text;
            string vEmail = textBoxEmail.Text;

            Posisi jabatan = (Posisi)comboBoxJabatan.SelectedItem;

            Employee emp = new Employee(vId,vNamaDepan,vNamaKeluarga,"",vEmail,"",DateTime.Now, DateTime.Now, jabatan);

            try
            {
                Employee.UbahData(emp);
                MessageBox.Show("Penambahan data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Pesan kesalahan: " + ex.Message);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
