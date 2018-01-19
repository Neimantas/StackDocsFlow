using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
  public interface ITopicsService
  {
    List<Topic> getTopics();

    Topic getTopicById(long id);

    List<Topic> GetOnePageList(string language, int page);

    List<Topic> GetOnePageList(int page);

    int GetPageCount();

    List<Topic> findTopicByLanguage(Languages languages, string keyword);
  }
}
