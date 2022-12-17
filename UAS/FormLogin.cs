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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            labelForgotPassword.ForeColor = Color.Blue;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void labelForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            labelForgotPassword.ForeColor = Color.Black;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string username = textBoxUID.Text;
            string pwd = textBoxPWD.Text;
            Pengguna userLogin = Pengguna.CekLogin(username, pwd);
            Employee pegawaiLogin = Employee.CekLoginPegawai(username, pwd);

            if (userLogin is null && pegawaiLogin is null)
                MessageBox.Show("Login gagal");
            else
            {
                FormUtama frm;
                frm = (FormUtama)this.Owner;
                if(userLogin != null)
                {
                    frm.userLogin = userLogin;
                }
                else if (pegawaiLogin != null)
                {
                    frm.pegawaiLogin = pegawaiLogin;
                }
                MessageBox.Show("Login berhasil");
                this.Close();
            }
        }

        private void labelForgotPassword_DoubleClick(object sender, EventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
