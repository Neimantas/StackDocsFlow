using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services.Impl
{
  public class DocTagsVersionsServiceImpl : IDocTagsVersionsService
  {

    IDatabaseService databaseService = new DatabaseService();

    public DocTagsVersions DocTagsVersions(long id)
    {
      List<DocTagsVersions> list = databaseService.GetDocTagVersionsData("select * from docTagsVersions where id="+id);
      return list[0];
    }

    public List<DocTagsVersions> GetDocTagsVersions()
    {
      List<DocTagsVersions> list = databaseService.GetDocTagVersionsData("select * from docTagsVersions");
      return list;
    }

    public List<DocTagsVersions> GetOnePageList(string language, int page)
    {
      throw new NotImplementedException();
    }

    public List<DocTagsVersions> GetOnePageList(int page)
    {
      page--;
      int off = page > 0 ? (20 * page) : 0;
      List<DocTagsVersions> list = databaseService.GetDocTagVersionsData("SELECT * FROM docTagsVersions limit 20 offset " + off);
      return list;
    }

    public int GetPageCount()
    {
      return databaseService.GetDataCount("docTagsVersions");
    }
  }
}
