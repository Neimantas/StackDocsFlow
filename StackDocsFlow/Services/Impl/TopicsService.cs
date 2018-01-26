using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;

namespace StackDocsFlow.Services.Impl
{
    internal class TopicsService : ITopicsService
    {
        private IDatabaseService databaseService = new DatabaseService();

        public List<Topic> GetOnePageByDocTagsId(string id, int pageNumber)
        {
            pageNumber--;
            int off = pageNumber > 0 ? (20 * pageNumber) : 0;
            List<Topic> list = databaseService.GetTopicsData("SELECT * FROM testJson where docTagId = " + id + " limit 20 offset " + off);
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
