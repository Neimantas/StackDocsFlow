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

    public List<Examples> GetExampleByTipicId(List<Examples> exampleList, long topicExampleId)
        {
            throw new NotImplementedException();
        }

        public List<Examples> GetExampleList()
        {
      List<Examples> list = databaseService.GetExamplesData("select * from examples");
      return list;
        }
    }
}
