using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services.Impl
{
  class DocTagsVersionsServiceImpl : IDocTagsVersionsService
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
  }
}
