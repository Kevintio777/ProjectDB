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
    public partial class FormTambahTabungan : Form
    {
        public FormTambahTabungan()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string norek = textBoxNorek.Text;
            Employee employee = (Employee)comboBoxVerif.SelectedItem;
            Pengguna pengguna = (Pengguna)comboBoxPengguna.SelectedItem;
            KodeBank kodeBank = (KodeBank)comboBoxBank.SelectedItem;
            string keter = textBoxketer.Text;
            Tabungan tabungan = new Tabungan(norek, pengguna, keter, employee, kodeBank);
            Tabungan.TambahData(tabungan);
        }

        private void FormTambahTabungan_Load(object sender, EventArgs e)
        {
            List<Employee> employees = Employee.BacaData();
            List<Pengguna> penggunas = Pengguna.BacaData();
            List<KodeBank> kodeBanks = KodeBank.Bacadata("","");
            foreach (Employee employee in employees)
            {
                comboBoxVerif.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxVerif.DataSource = employee;
                comboBoxVerif.DisplayMember = "Id";
            }
            foreach (Pengguna pengguna in penggunas)
            {
                comboBoxPengguna.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxPengguna.DataSource = pengguna;
                comboBoxPengguna.DisplayMember = "nik";
            }
            foreach (KodeBank kodeBank in kodeBanks)
            {
                comboBoxBank.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxBank.DataSource = kodeBank;
                comboBoxBank.DisplayMember = "Id";
            }
        }
    }
}
