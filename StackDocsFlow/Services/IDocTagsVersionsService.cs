using StackDocsFlow.Models.DatabaseModels;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
  public interface IDocTagsVersionsService
  {
    List<DocTagsVersions> GetDocTagsVersions();

    DocTagsVersions DocTagsVersions(long id);

    List<DocTagsVersions> GetOnePageList(string language, int page);

    List<DocTagsVersions> GetOnePageList(int page);

    int GetPageCount();
  }
}
