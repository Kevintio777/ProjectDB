using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diba
{
    class Deposito
    {
        private string id;
        private Tabungan tabungan;
        private string jatuhtempo;
        private double nominal;
        private double bunga;
        private string status;
        private DateTime tglbuat;
        private DateTime tglperubahan;
        private Employee opener;
        private Employee cair;

        public Deposito(string id, Tabungan tabungan, string jatuhtempo, double nominal, double bunga, string status, DateTime tglbuat, DateTime tglperubahan, Employee opener, Employee cair)
        {
            this.id = id;
            this.tabungan = tabungan;
            this.jatuhtempo = jatuhtempo;
            this.nominal = nominal;
            this.bunga = bunga;
            this.status = status;
            this.tglbuat = tglbuat;
            this.tglperubahan = tglperubahan;
            this.opener = opener;
            this.cair = cair;
        }

        public string Id { get => id; set => id = value; }
        public Tabungan Tabungan { get => tabungan; set => tabungan = value; }
        public string Jatuhtempo { get => jatuhtempo; set => jatuhtempo = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public double Bunga { get => bunga; set => bunga = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Tglbuat { get => tglbuat; set => tglbuat = value; }
        public DateTime Tglperubahan { get => tglperubahan; set => tglperubahan = value; }
        public Employee Opener { get => opener; set => opener = value; }
        public Employee Cair { get => cair; set => cair = value; }
    }
}
