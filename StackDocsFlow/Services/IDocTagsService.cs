using StackDocsFlow.Models.DatabaseModels;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
    public interface IDocTagsService
    {
        List<DocTags> GetOnePageList(int pageNumber);
        List<DocTags> GetDocTags();
        DocTags GetDocTagsById(long id);
    }
}
