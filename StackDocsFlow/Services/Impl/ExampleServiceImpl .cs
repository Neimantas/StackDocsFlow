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

        public List<Examples> GetOnePageByTopicId(string id, int pageNumber)
        {
            pageNumber--;
            int off = pageNumber > 0 ? (20 * pageNumber) : 0;
            List<Examples> list = databaseService.GetExamplesData("SELECT * FROM examples where docTopicId = " + id + " limit 20 offset " + off);
            return list;
        }


    }
}
