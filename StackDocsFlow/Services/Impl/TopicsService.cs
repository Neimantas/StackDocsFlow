using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;

namespace StackDocsFlow.Services.Impl
{
    internal class TopicsService : ITopicsService
    {
        private IDatabaseService databaseService = new DatabaseService();

        public List<Topic> findTopicByLanguage(Languages languages, string keyword)
        {
            throw new NotImplementedException();
        }

        public List<Examples> GetExamplesById(string id, int page)
        {
            page--;
            int off = page > 0 ? (20 * page) : 0;
            List<Examples> list = databaseService.GetExamplesData("SELECT * FROM examples where docTopicId = " + id + " limit 20 offset " + off);
            return list;
        }

        public List<Topic> GetOnePageList(int page)
        {
            page--;
            int off = page > 0 ? (20 * page) : 0;
            List<Topic> list = databaseService.GetTopicsData("SELECT * FROM testJson limit 20 offset " + off);
            return list;
        }

        public List<Topic> GetOnePageList(string language, int page)
        {
            throw new NotImplementedException();
        }

        public int GetPageCount()
        {
            return databaseService.GetDataCount("testJson");
        }

        public Topic getTopicById(long id)
        {
            List<Topic> list = databaseService.GetTopicsData("select * from testJson where id=" + id);
            return list[0];
        }

        public List<Topic> GetTopics()
        {
            List<Topic> list = databaseService.GetTopicsData("select * from testJson");
            return list;
        }



    }
}
