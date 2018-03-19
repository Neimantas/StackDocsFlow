using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    public interface IDatabaseService
    {
        List<DocTags> GetDocTagsData(string commandText);
        List<DocTagsVersions> GetDocTagVersionsData(string commandText);
        List<Examples> GetExamplesData(string commandText);
        List<Topic> GetTopicsData(string commandText);
        int GetDataCount(string tableName, string foreignId, string foreignIdName);
        List<Object> GetOnePageListOfObjects(string tableName, int pageNumber, string clickedItemId, string language);
    }
}
