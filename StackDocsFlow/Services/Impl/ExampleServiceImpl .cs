using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;

namespace StackDocsFlow.Services.Impl
{
    class ExampleServiceImpl : IExampleService
    {

    IDatabaseService databaseService = new DatabaseService();

    public List<Examples> GetExampleByTopicId(long topicExampleId)
        {
            throw new NotImplementedException();
        }

        public List<Examples> GetExampleList()
        {
      List<Examples> list = databaseService.GetExamplesData("select * from examples");
      return list;
        }

    public List<Examples> GetOnePageList(string language, int page)
    {
      throw new NotImplementedException();
    }

    public List<Examples> GetOnePageList(int page)
    {
      page--;
      int off = page > 0 ? (20 * page) : 0;
      List<Examples> list = databaseService.GetExamplesData("SELECT * FROM examples limit 20 offset " + off);
      return list;
    }

    public int GetPageCount()
    {
      return databaseService.GetDataCount("examples");
    }
  }
}
