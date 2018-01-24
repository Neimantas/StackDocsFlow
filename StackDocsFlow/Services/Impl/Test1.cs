using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackDocsFlow.TestService.Impl
{
    public class Test1 : ITest1
    {
        private readonly IDocTagsService _docTagsService;
        private readonly ITopicsService _topicsService;
        private readonly IExampleService _exampleService;

        public Test1(IDocTagsService docTagsService, ITopicsService topicsService, IExampleService exampleService)
        {
            _docTagsService = docTagsService;
            _topicsService = topicsService;
            _exampleService = exampleService;
        }

        public void AddColumsToListViewAccordingToDataModel(string databaseName, ListView listView1)
        {
            
            switch(databaseName)
            {
                case "DocTags":
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);
                    listView1.Columns.Add("Title", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("CreationDate", 200, HorizontalAlignment.Left);
                    break;

                case "Examples":
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);
                    listView1.Columns.Add("docTopicId", 70, HorizontalAlignment.Left);
                    listView1.Columns.Add("Title", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Description", 150, HorizontalAlignment.Left);
                    listView1.Columns.Add("CeationDate", 150, HorizontalAlignment.Left);
                    listView1.Columns.Add("LastEditDate", 150, HorizontalAlignment.Left);
                    break;

                case "Topic":
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);
                    listView1.Columns.Add("DocTagId", 70, HorizontalAlignment.Left);
                    listView1.Columns.Add("Title", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Answer", 150, HorizontalAlignment.Left);
                    listView1.Columns.Add("CreationDate", 150, HorizontalAlignment.Left);
                    listView1.Columns.Add("LastEditDate", 150, HorizontalAlignment.Left);
                    break;
            } 
        }

        public List<ListViewItem> returnItemsListAccordingToSpecificType(string displayedItemsType, string id, int pageNumber)
        {
            List<ListViewItem> itemsList = new List<ListViewItem>();
        
            switch(displayedItemsType)
            {
                case "DocTags":
                    List<DocTags> docTagsList = _docTagsService.GetOnePageList(pageNumber);

                    foreach (DocTags listItem in docTagsList)
                    {
                        string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                        ListViewItem listViewItem = new ListViewItem(item);
                        listViewItem.Tag = listItem;
                        itemsList.Add(listViewItem);
                    }
                    break;

                case "Topic":
                    List<Topic> topicList = _topicsService.GetOnePageOfTopicsByDocTagsId(id, pageNumber);

                    foreach (Topic listItem in topicList)
                    {
                        string[] item = { Convert.ToString(listItem.Id), Convert.ToString(listItem.DocTagId),
                        listItem.Title, listItem.Answer, Convert.ToString(listItem.CreationDate), Convert.ToString(listItem.LastEditDate) };
                        ListViewItem listViewItem = new ListViewItem(item);
                        listViewItem.Tag = listItem;
                        itemsList.Add(listViewItem);
                    }
                    break;

                case "Examples":
                    List<Examples> examplesList = _exampleService.GetExamplesByIdByTopicId(id, pageNumber);

                    foreach (Examples listItem in examplesList)
                    {
                        string[] item = { Convert.ToString(listItem.Id), Convert.ToString(listItem.docTopicId),
                        listItem.Title, listItem.Description, Convert.ToString(listItem.CeationDate), Convert.ToString(listItem.LastEditDate) };
                        ListViewItem listViewItem = new ListViewItem(item);
                        listViewItem.Tag = listItem;
                        itemsList.Add(listViewItem);
                    }
                    break;
            }
            return itemsList;
        }
    }
}
