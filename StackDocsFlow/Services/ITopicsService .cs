using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System.Collections.Generic;

namespace StackDocsFlow.Services
{
    public interface ITopicsService
    {
        List<Topic> GetOnePageOfTopicsByDocTagsId(string id, int page);

        List<Topic> GetTopics();

        Topic getTopicById(long id);


        List<Topic> GetOnePageList(int page);

        int GetPageCount();

        List<Topic> findTopicByLanguage(Languages languages, string keyword);
    }
}
