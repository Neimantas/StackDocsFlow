using StackDocsFlow.Models.DatabaseModels;
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
    public DateTime GetDateFromDouble(double number)
    {
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
     return dtDateTime = dtDateTime.AddSeconds(number).ToLocalTime();
     // throw new NotImplementedException();
    }

    public List<DocTags> GetSQLData(string comandText)
        {
      List<DocTags> list = new List<DocTags>();
      var sql_con = new SQLiteConnection("Data Source=ExternalSources/maindb.db;Version=3;New=False;Compress=True;");
            sql_con.Open();
            var sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = comandText;
            sql_cmd.ExecuteNonQuery();

      SQLiteDataReader reader = sql_cmd.ExecuteReader();

      while (reader.Read())
      {

        DocTags docTag = new DocTags();
        docTag.Id = reader.GetInt32(0);
        docTag.Title = reader.GetString(1);
        docTag.CreationDate = GetDateFromDouble(reader.GetDouble(2)/1000);
        list.Add(docTag);
      }
      sql_con.Close();
      return list;
        }
    }
}
