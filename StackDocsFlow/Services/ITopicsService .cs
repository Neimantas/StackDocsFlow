using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    interface ITopicsService
    {
        List<Topic> getTopics(String json);
        Topic getTopicById(List<Topic> topics, long id);
        List<Topic> findTopicByLanguage(List<Topic> topics, Languages languages, string keyword);
        List<Topic> getTopicsByPage(List<Topic> listTopic, int start);
    }
}
