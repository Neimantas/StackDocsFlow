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
        List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags);
    }
}
