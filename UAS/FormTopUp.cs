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
        }
    }
}
