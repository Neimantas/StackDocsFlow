using StackDocsFlow.Services;
using StackDocsFlow.Services.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackDocsFlow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
      DataConnection connection = new DataConnection();
      connection.selectQuery("select * from docTags");

      //var m_dbConnection =
      //new SQLiteConnection(@"Data Source=C\Users\marius\source\repos\SeeProject\StackDocsFlow\ExternalSources\maindb.db;Version=3;");
      //m_dbConnection.Open();
      //string sql = "select * from highscores order by score desc";
      //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
      //SQLiteDataReader reader = command.ExecuteReader();
      //while (reader.Read())
      //  Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
