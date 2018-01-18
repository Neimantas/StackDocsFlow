using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.TestService.Impl
{
    public class Test1 : ITest1
    {
        public List<DocTags> getPageList(string Language, int pageCount)
        {
            List<DocTags> list = new List<DocTags>();

            return list;
        }
    }
}
