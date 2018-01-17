using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
  public interface IDataConnection
  {
    DataTable selectQuery(string query);
  }
}
