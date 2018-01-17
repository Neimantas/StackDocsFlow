using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;

namespace StackDocsFlow.Services.Impl
{
    class TopicsService : ITopicsService
    {
        public List<Topic> findTopicByLanguage(List<Topic> topics, Languages languages, string keyword)
        {
            throw new NotImplementedException();
        }

        public Topic getTopicById(List<Topic> topics, long id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> getTopics(string json)
        {
            throw new NotImplementedException();
        }

        public List<Topic> getTopicsByPage(List<Topic> listTopic, int start)
        {
            throw new NotImplementedException();
        }
    }
}
