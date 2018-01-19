using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    public interface ITopicsService
    {
        List<Topic> getTopics();
        Topic getTopicById(long id);
        List<Topic> findTopicByLanguage(List<Topic> topics, Languages languages, string keyword);
        List<Topic> getTopicsByPage(List<Topic> listTopic, int start);
    }
}
