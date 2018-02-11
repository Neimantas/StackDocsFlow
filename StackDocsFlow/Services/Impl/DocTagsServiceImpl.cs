using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;
namespace StackDocsFlow.Services.Impl
{
    public class DocTagsServiceImpl : IDocTagsService

    {
        IDatabaseService databaseService = new DatabaseService();

        public List<DocTags> GetOnePageList(int pageNumber, string language)
        {
            pageNumber--;
            int off = pageNumber > 0 ? (20 * pageNumber) : 0;
            List<DocTags> list = databaseService.GetDocTagsData("SELECT * FROM docTags where title like '%" + language + "%' limit 20 offset " + off);
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
    }
}
