using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
  public  interface IDocTagsService
    {
        List<DocTags> GetDocTags();
        DocTags GetDocTagsById(long id);
        List<DocTags> GetOnePageList(string language, int page);
        List<DocTags> GetOnePageList(int page);
        int GetPageCount();
    List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags);
    }
}
