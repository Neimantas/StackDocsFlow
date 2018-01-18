using SimpleInjector;
using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Services;
using StackDocsFlow.Services.Impl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackDocsFlow
{
    static class Program
    {
    private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
      Bootstrap();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<Form1>());
        }
    private static void Bootstrap()
    {
      // Create the container as usual.
      container = new Container();

      // Register your types, for instance:
      container.Register<IDocTagsService, DocTagsServiceImpl>(Lifestyle.Transient);
      //container.Register<IUserContext, WinFormsUserContext>();
      container.Register<Form1>();

      // Optionally verify the container.
      //container.Verify();
    }

  }
}
