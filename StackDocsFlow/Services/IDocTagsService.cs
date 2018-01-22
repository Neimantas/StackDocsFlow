using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
  public interface IDocTagsService
  {
    List<DocTags> GetDocTags();

    DocTags GetDocTagsById(long id);

    List<DocTags> GetOnePageList(string language, int page);

    List<DocTags> GetOnePageList(int page);

    int GetPageCount();

    List<Topic> GetTopics(string id, int page);
    List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags);
  }
}
