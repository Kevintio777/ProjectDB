using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diba
{
    public class AdressBook
    {
        private Tabungan norek;
        private string keter;

        public AdressBook(Tabungan norek, string keter)
        {
            this.norek = norek;
            this.keter = keter;
        }

        public Tabungan Norek { get => norek; set => norek = value; }
        public string Keter { get => keter; set => keter = value; }
    }
}
