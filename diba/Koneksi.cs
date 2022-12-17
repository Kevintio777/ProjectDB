using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace diba
{
    public class Koneksi
    {
        private MySqlConnection KoneksiDB;

        public Koneksi(string pServer, string pDatabase, string pUID, string pPWD)
        {
            string vConnectionString = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUID + ";pwd=" + pPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = vConnectionString;

            Connect();
        }
        public Koneksi()
        {
            Configuration myconf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSetting = myconf.SectionGroups["userSettings"];

            var settingsSection = userSetting.Sections["UAS.db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("dbserver").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("dbname").Value.ValueXml.InnerText;
            string DbUID = settingsSection.Settings.Get("dbUID").Value.ValueXml.InnerText;
            string DbPWD = settingsSection.Settings.Get("dbPWD").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUID + ";pwd=" + DbPWD + ";";
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }

        public MySqlConnection KoneksiDB1 { get => KoneksiDB; private set => KoneksiDB = value; }

        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        public static void JalankanPerintahNonQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.KoneksiDB);
            cmd.ExecuteReader();
        }
    }
}
