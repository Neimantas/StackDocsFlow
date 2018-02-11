using StackDocsFlow.Models.DatabaseModels;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
    public interface IDocTagsService
    {
        List<DocTags> GetOnePageList(int pageNumber, string language);
        List<DocTags> GetDocTags();
        DocTags GetDocTagsById(long id);
    }
}
