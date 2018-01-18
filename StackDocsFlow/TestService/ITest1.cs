using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.TestService
{
    public interface ITest1
    {
        List<DocTags> getPageList(string Language, int pageCount);
    }
}
