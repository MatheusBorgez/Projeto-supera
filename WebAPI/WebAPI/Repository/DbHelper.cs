using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;

namespace WebAPI.Repository
{
    public static class DbHelper
    {
        private static SQLiteConnection Connection;

        public static SQLiteConnection DbConnection()
        {
            Connection = new SQLiteConnection("Data Source=C:\\WorkMatheus\\Projeto-supera\\BDprojeto.sqlite; Version=3;");
            Connection.Open();
            return Connection;
        }
    }
}
