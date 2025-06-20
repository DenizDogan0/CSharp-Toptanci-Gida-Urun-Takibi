using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptanciYonetimPaneli
{
    internal class VeriTabaniBaglantisi
    {
        private static string baglantiDizesi = "Server=localhost;Database=projedbb;Uid=root;Pwd=;";

        public static MySqlConnection BaglantiyiAl()
        {
            return new MySqlConnection(baglantiDizesi);
        }
    }
}
