using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services.Impl
{
  class DataConnection : IDataConnection
  {
    private SQLiteConnection sqlite;

    public DataConnection()
    {
      string x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    //  string rootDir= System.IO.Directory.GetCurrentDirectory();
      string pathName = x + "\\ExternalSources\\slack.db";
      //  C: \Users\marius\source\repos\SeeProject\StackDocsFlow\ExternalSources\maindb.db
      sqlite = new SQLiteConnection("Data Source ="+pathName);
    }

    public DataTable selectQuery(string query)
    {
      SQLiteDataAdapter adapter;
      DataTable dataTable = new DataTable();
      try
      {
        SQLiteCommand cmd;
        sqlite.Open();
        cmd = sqlite.CreateCommand();
        cmd.CommandText = query;
        adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dataTable);
      }
      catch(SQLiteException ex)
      {
        Console.WriteLine("Error in DataConnection: selectQuerry" + ex);
      }
      sqlite.Close();
      Console.WriteLine("uzsidarom");
      return dataTable;

    
    }
  }
}
