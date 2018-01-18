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

        public List<DocTags> GetDocTags()
        {
          List<DocTags> list = databaseService.GetDocTagsData("select * from docTags"); 
      return list;           
        }



        public DocTags GetDocTagsById(long id)
        {
      List<DocTags> list = databaseService.GetDocTagsData("select * from docTags where id ="+id);
      return list[0];
        }

        public List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags)
        {
            throw new NotImplementedException();
        }
    }
}
