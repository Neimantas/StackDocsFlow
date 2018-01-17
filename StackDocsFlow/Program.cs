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
      IDataConnection connection = new DataConnection();
     // DataTable dt = connection.selectQuery("select strftime('%m/%d/%Y',substr(creationDate,0,20)) from docTags");
      DataTable dt = connection.selectQuery("select id, title from docTags");
      //    DataTable dt = connection.selectQuery("select title from docTags");

      foreach (DataRow row in dt.Rows)
      {
        //string x = row["creationDate"].ToString();
        //     var f = 4;
        Console.Write(row);
      }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
