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

        IDatabaseService databaseService = new DatabaseService();

        public List<Topic> findTopicByLanguage(List<Topic> topics, Languages languages, string keyword)
        {
            throw new NotImplementedException();
        }

        public Topic getTopicById(long id)
        {
      List<Topic> list = databaseService.GetTopicsData("select * from testJson where id="+id);
      return list[0];
    }

        public List<Topic> getTopics()
        {

      List<Topic> list = databaseService.GetTopicsData("select * from testJson");
      return list;
        }

        public List<Topic> getTopicsByPage(List<Topic> listTopic, int start)
        {
            throw new NotImplementedException();
        }
    }
}
