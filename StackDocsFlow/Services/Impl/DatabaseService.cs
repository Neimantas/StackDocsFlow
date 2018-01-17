using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services.Impl
{
    public class DatabaseService : IDatabaseService
    {
        private void MakeConnection()
        {
            var sql_con = new SQLiteConnection("Data Source=ExternalSources/maindb.db;Version=3;New=False;Compress=True;");
            sql_con.Open();
            var sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from doctags";
            sql_cmd.CommandText = CommandText;
            sql_cmd.ExecuteNonQuery();

            var reader = sql_cmd.ExecuteReader();

            while (reader.Read())
            {

            }
            sql_con.Close();

        }
    }
}
