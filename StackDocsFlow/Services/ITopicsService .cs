using StackDocsFlow.Models.DatabaseModels;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
    public interface ITopicsService
    {
        List<Topic> GetOnePageByDocTagsId(string id, int page);

        List<Topic> GetTopics();

        Topic getTopicById(long id);


        List<Topic> GetOnePageList(int page);

        int GetPageCount();
    }
}
