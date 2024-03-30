using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace _00014809.DAL
{
    public class DbManager
    {
        protected SQLiteConnection Connection
        {
            get
            {
                return new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            }
        }

    }
}
