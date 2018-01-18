using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
  interface IDocTagsVersionsService
  {
    List<DocTagsVersions> GetDocTagsVersions();
    DocTagsVersions DocTagsVersions(long id);
  }
}
