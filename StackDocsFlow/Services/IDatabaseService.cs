using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    public interface IDatabaseService
    {
    List<DocTags> GetSQLData(string comandText);
    DateTime GetDateFromDouble(double number);
  }
}
