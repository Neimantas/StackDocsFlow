using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;

namespace StackDocsFlow.Services.Impl
{
    class DocTagsServiceImpl : IDocTagsService

    {
    IDatabaseService databaseService = new DatabaseService();

        public List<DocTags> getDocTags()
        {
          List<DocTags> list = databaseService.GetSQLData("select * from docTags"); 
      return list;           
        }



        public DocTags getDocTagsById(string json, long id)
        {
            throw new NotImplementedException();
        }

        public List<DocTags> getDocTagsByLanguage(Languages languages, List<DocTags> docTags)
        {
            throw new NotImplementedException();
        }
    }
}
