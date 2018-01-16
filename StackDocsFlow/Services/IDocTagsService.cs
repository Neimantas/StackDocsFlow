using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    interface IDocTagsService
    {
        List<DocTags> getDocTags(string json);
        DocTags getDocTagsById(string json, long id);
        List<DocTags> getDocTagsByLanguage(Languages languages, List<DocTags> docTags);
    }
}
