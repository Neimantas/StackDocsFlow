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

    SQLiteConnection sql_con = new SQLiteConnection("Data Source=ExternalSources/maindb.db;Version=3;New=False;Compress=True;");


    public List<DocTags> GetDocTagsData(string commandText)
        {
            List<DocTags> list = new List<DocTags>();
            sql_con.Open();
            var sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = commandText;
            sql_cmd.ExecuteNonQuery();

      SQLiteDataReader reader = sql_cmd.ExecuteReader();

      while (reader.Read())
      {

        DocTags docTag = new DocTags();
        docTag.Id = reader.GetInt64(0);
        docTag.Title = reader.GetString(1);
        docTag.CreationDate = GetDateFromDouble(reader.GetDouble(2));
        list.Add(docTag);
      }
      sql_con.Close();
      return list;
        }

    public List<DocTagsVersions> GetDocTagVersionsData(string commandText)
    {
      List<DocTagsVersions> list = new List<DocTagsVersions>();
      sql_con.Open();
      var sql_cmd = sql_con.CreateCommand();
      sql_cmd.CommandText = commandText;
      sql_cmd.ExecuteNonQuery();
      SQLiteDataReader reader = sql_cmd.ExecuteReader();

      while (reader.Read())
      {
        DocTagsVersions docVersion = new DocTagsVersions();
        docVersion.Id = reader.GetInt64(0);
        docVersion.DocTagId = reader.GetInt64(1);
        docVersion.Title = reader.GetString(2);
        docVersion.CreationDate = GetDateFromDouble(reader.GetDouble(3));
        docVersion.LastEditDate = GetDateFromDouble(reader.GetDouble(4));
        list.Add(docVersion);
      }

        sql_con.Close();
      return list;
    }

    public List<Examples> GetExamplesData(string commandText)
    {
      List<Examples> list = new List<Examples>();
      sql_con.Open();
      var sql_cmd = sql_con.CreateCommand();
      sql_cmd.CommandText = commandText;
      sql_cmd.ExecuteNonQuery();
      SQLiteDataReader reader = sql_cmd.ExecuteReader();

      while (reader.Read())
      {
        Examples example = new Examples();
        example.Id = reader.GetInt64(0);
        example.docTopicId = reader.GetInt64(1);
        example.Title = reader.GetString(2);
        example.Description = reader.GetString(3);
        example.CeationDate = GetDateFromDouble(reader.GetDouble(4));
        example.LastEditDate = GetDateFromDouble(reader.GetDouble(5));
        list.Add(example);
      }
        sql_con.Close();
      return list;
    }

    public List<Topic> GetTopicsData(string commandText)
    {
      List<Topic> list = new List<Topic>();
      sql_con.Open();
      var sql_cmd = sql_con.CreateCommand();
      sql_cmd.CommandText = commandText;
      sql_cmd.ExecuteNonQuery();
      SQLiteDataReader reader = sql_cmd.ExecuteReader();

      while (reader.Read())
      {
        Topic topic = new Topic();
        topic.Id = reader.GetInt32(0);
        topic.DocTagId = reader.GetInt64(1);
        topic.Title = reader.GetString(2);
        topic.Answer = reader.GetString(3);
        topic.CreationDate = GetDateFromDouble(reader.GetDouble(4));
        topic.LastEditDate = GetDateFromDouble(reader.GetDouble(5));
      }

        sql_con.Close();
      return list;
    }

    public DateTime GetDateFromDouble(double number)
    {
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      if(number < 1)
      {
        return dtDateTime;
      }
      return  dtDateTime.AddSeconds(number / 1000).ToLocalTime();
      // throw new NotImplementedException();
    }
  }
}
