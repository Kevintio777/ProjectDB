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
    public partial class FormDaftarInbox : Form
    {
        public FormDaftarInbox()
        {
            InitializeComponent();
        }

        public Pengguna pgn = new Pengguna();

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDaftarInbox_Load(object sender, EventArgs e)
        {
            List<Inbox> listInbox = Inbox.BacaData("i.id_pengguna", pgn.Nik);

            if (listInbox.Count > 0)
            {               
                dataGridViewHasil.DataSource = listInbox;             
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Yakin hapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
            {
                string IdUser = dataGridViewHasil.CurrentRow.Cells["IdUser"].Value.ToString();
                try
                {
                    Inbox.HapusData(IdUser);
                    MessageBox.Show("Penghapusan data berhasil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            FormDaftarInbox_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
