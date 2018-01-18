using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    interface IExampleService
    {
        List<Examples> GetExampleList();
        List<Examples> GetExampleByTipicId(List<Examples> exampleList, long topicExampleId);
    }
}
