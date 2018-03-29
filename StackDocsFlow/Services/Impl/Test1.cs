using StackDocsFlow.CustomAttributes;
using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
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
        private readonly IDatabaseService _databaseService;

        public Test1(IDocTagsService docTagsService, ITopicsService topicsService, IExampleService exampleService, IDatabaseService databaseService)
        {
            _docTagsService = docTagsService;
            _topicsService = topicsService;
            _exampleService = exampleService;
            _databaseService = databaseService;
        }

        public void AddColumsToListViewAccordingToDataModel(string modelName, ListView listView1)
        {
            
            switch(modelName)
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

        public List<ListViewItem> returnItemsListAccordingToSpecificType(string displayedItemsType, string id, int pageNumber, string language)
        {
            List<ListViewItem> itemsList = new List<ListViewItem>();
        
            switch(displayedItemsType)
            {
                case "DocTags":
                    List<DocTags> docTagsList = _docTagsService.GetOnePageList(pageNumber, language);

                    foreach (DocTags listItem in docTagsList)
                    {
                        string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                        ListViewItem listViewItem = new ListViewItem(item);
                        listViewItem.Tag = listItem;
                        itemsList.Add(listViewItem);
                    }
                    break;
                    
                case "Topic":
                    List<Topic> topicList = _topicsService.GetOnePageByDocTagsId(id, pageNumber);

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
                    List<Examples> examplesList = _exampleService.GetOnePageByTopicId(id, pageNumber);

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

        public List<ListViewItem> returnItemsListAccordingToSpecificType2(ListView listView1, int pageNumber, string language)
        {
            string clickedItemId = listView1.SelectedItems[0].Text;
            string tableName = GetTableNameAccordingModelClass(listView1);
            string childTableName = GetTableNameOfClickedElementChildClass(listView1);
            string childClassForeignKey = GetChildTableForeignIdName(listView1);
            Type childClassType = GetChildClassType(listView1);
            List<Object> listViewItemObjectList = _databaseService.GetOnePageListOfObjects(childTableName, childClassForeignKey, pageNumber, clickedItemId, childClassType, language);
            List<ListViewItem> list = GetListOfListViewItemsAccordingToGivenType(listViewItemObjectList, listView1);
            return list;
        }

        private List<ListViewItem> GetListOfListViewItemsAccordingToGivenType(List<Object> objectList, ListView listView1)
        {

            foreach (Object o in objectList)
            {
                Topic topic = (Topic)o;          
                    
                
            }

        foreach (Object myObject in objectList)
            {
                string[] objectProperties = myObject.ToString().Split(',');


                List<String> classPropertyNames = new List<String>();
                PropertyInfo[] propertyValues = myObject.GetType().GetProperties();
                int i = 0;

                foreach (PropertyInfo propertyValue in propertyValues)
                {
                    string fullProperty = propertyValues[i].ToString();
                    string[] propertyName = fullProperty.Split(' ');
                    classPropertyNames.Add(propertyName[1]);
                    i++;
                }
            }



            List<ListViewItem> list = new List<ListViewItem>();

            return list;
        }

        private string GetChildTableForeignIdName(ListView listView1)
        {
            ChildTableForeignIdNameAttribute parentTableIdNameAttribute = (ChildTableForeignIdNameAttribute)Attribute.GetCustomAttribute(listView1.SelectedItems[0].Tag.GetType(), typeof(ChildTableForeignIdNameAttribute));
            string idName = parentTableIdNameAttribute.Name;
            return idName;
        }

        private string GetTableNameOfClickedElementChildClass(ListView listView1)
        {
            DocTags docTags = new DocTags();
            ChildTableNameAttribute descriptionAttribute = (ChildTableNameAttribute)Attribute.GetCustomAttribute(listView1.SelectedItems[0].Tag.GetType(), typeof(ChildTableNameAttribute));
            string tableName = descriptionAttribute.Name;
            return tableName;
        }

        private static Type GetChildClassType(ListView listView1)
        {
            ChildClassTypeAttribute childClassAttribute = (ChildClassTypeAttribute)Attribute.GetCustomAttribute(listView1.SelectedItems[0].Tag.GetType(), typeof(ChildClassTypeAttribute));
            Type type = childClassAttribute.Type;
            return type;
        }

        public int GetPageCount(ListView listView1)
        {


            string itemsDataTypeInCurrentListView = returnListViewItemType(listView1);
            int pageCount = 0;

            switch (itemsDataTypeInCurrentListView)
            {
                case "DocTags":
                    pageCount = _databaseService.GetDataCount("DocTags", "notUsed", "notUsed");
                    break;
                case "Topic":
                    string topicForeignId = GetItemForeignId(listView1, "Topic");
                    string topicForeignIdName = GetItemForeignIdName(listView1, "Topic");
                    pageCount = _databaseService.GetDataCount("testJson", topicForeignId, topicForeignIdName);
                    break;
                case "Examples":
                    string examplesForeignId = GetItemForeignId(listView1, "Examples");
                    string examplesForeignIdName = GetItemForeignIdName(listView1, "Examples");
                    pageCount = _databaseService.GetDataCount("Examples", examplesForeignId, examplesForeignIdName);
                    break;
            }
            return pageCount;
        }

        public string GetListViewItemId(string typeOfItem, ListView listView1)
        {
            string id = "";
            switch (typeOfItem)
            {
                case "DocTags":
                    //ListViewItem item = listView1.Items[0];
                    //DocTags docTags = (DocTags)item.Tag;
                    break;
                case "Topic":
                    ListViewItem topicItem = listView1.Items[0];
                    Topic topic = (Topic)topicItem.Tag;
                    id = Convert.ToString(topic.DocTagId);
                    break;
                case "Examples":
                    break;
            }
            return id;
        }

        public string returnListViewItemType(ListView listView1)
        {
            ListViewItem item = listView1.Items[0];
            var objectTag = item.Tag;
            Type type = objectTag.GetType();
            return type.Name;
        }

        public string GetItemForeignId(ListView listView1, string tableType)
        {
            string id = "";
            switch (tableType)
            {
                case "Topic":
                    ListViewItem topicItem = listView1.Items[0];
                    Topic topic = (Topic)topicItem.Tag;
                    id = Convert.ToString(topic.DocTagId);
                    break;

                case "Examples":
                    ListViewItem examplesItem = listView1.Items[0];
                    Examples examples = (Examples)examplesItem.Tag;
                    id = Convert.ToString(examples.docTopicId);
                    break;
            }
        return id;
        }

        public string GetItemForeignIdName(ListView listView1, string tableType)
        {
            string idName = "";
            switch(tableType)
            {
                case "Topic":
                    ListViewItem topicItem = listView1.Items[0];
                    Topic topic = (Topic)topicItem.Tag;
                    idName = nameof(topic.DocTagId);
                    break;
                case "Examples":
                    ListViewItem examplesItem = listView1.Items[0];
                    Examples examples = (Examples)examplesItem.Tag;
                    idName = nameof(examples.docTopicId);
                    break;
            }
            return idName;
        }

        private string GetTableNameAccordingModelClass(ListView listView1) 
        {
            Type selectedItemType = listView1.SelectedItems[0].Tag.GetType();
            var customAttributes = selectedItemType.GetTypeInfo().GetCustomAttributes<TableAttribute>();
            string tableName = customAttributes.First().Name;
            return tableName;
        }
    }
}
