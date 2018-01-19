using StackDocsFlow.Models.DatabaseModels;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
  public interface IExampleService
  {
    List<Examples> GetExampleList();

    List<Examples> GetExampleByTopicId(long topicExampleId);

    List<Examples> GetOnePageList(string language, int page);

    List<Examples> GetOnePageList(int page);

    int GetPageCount();
  }
}
