using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Models.Enums;

namespace StackDocsFlow.Services.Impl
{
    public class DocTagsServiceImpl : IDocTagsService

    {
        IDatabaseService databaseService = new DatabaseService();

        public List<DocTags> GetOnePageList(int pageNumber)
        {
            pageNumber--;
            int off = pageNumber > 0 ? (20 * pageNumber) : 0;
            List<DocTags> list = databaseService.GetDocTagsData("SELECT * FROM docTags limit 20 offset " + off);
            return list;
        }

        //"SELECT * FROM docTags where title like '%" + language + "%' limit 20 offset " + off






        public List<DocTags> GetDocTags()
        {
            List<DocTags> list = databaseService.GetDocTagsData("select * from docTags");
            return list;
        }

        public DocTags GetDocTagsById(long id)
        {
            List<DocTags> list = databaseService.GetDocTagsData("select * from docTags where id =" + id);
            return list[0];
        }

        public List<DocTags> GetDocTagsByLanguage(Languages languages, List<DocTags> docTags)
        {
            throw new NotImplementedException();
        }

        

        public int GetPageCount()
        {
            return databaseService.GetDataCount("docTags");
        }

    }
}
