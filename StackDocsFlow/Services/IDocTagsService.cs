using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
    public interface IDocTagsService
    {
        List<DocTags> GetOnePageList(int pageNumber);

        List<DocTags> GetDocTags();

        DocTags GetDocTagsById(long id);

        int GetPageCount();

        //List<Topic> GetOnePageTopicsById(string id, int page);

        List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags);

        
    }
}
