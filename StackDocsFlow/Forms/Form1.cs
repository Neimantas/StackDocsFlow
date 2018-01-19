using StackDocsFlow.Models.DatabaseModels;
using StackDocsFlow.Services;
using StackDocsFlow.TestService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackDocsFlow
{
    public partial class Form1 : Form
    {
        int pageNumber;
        List<DocTags> listLoadedInListView;

        private readonly IDocTagsService _docTagsService;
        private readonly IDocTagsVersionsService _docTagsVersionsService;
        private readonly IExampleService _exampleService;
        private readonly ITopicsService _topicsService;
        private readonly ITest1 _test1;

        public Form1(IDocTagsService docTagsService, IDocTagsVersionsService docTagsVersionsService, IExampleService exampleService, ITopicsService topicsService, ITest1 test1)
        {
            pageNumber = 1;
            _docTagsService = docTagsService;
            _docTagsVersionsService = docTagsVersionsService;
            _exampleService = exampleService;
            _topicsService = topicsService;
            _test1 = test1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listLoadedInListView = _docTagsService.GetOnePageList(1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (DocTags listItem in listLoadedInListView)
            {
                string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                ListViewItem listViewItem = new ListViewItem(item);
                listView1.Items.Add(listViewItem);
            }

            languageComboBox.SelectedIndex = -1;
            searchTextBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<DocTags> filteredListByLanguage = FilteredListByLanguage(listLoadedInListView);

            foreach (DocTags listItem in filteredListByLanguage)
            {
                string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                ListViewItem listViewItem = new ListViewItem(item);
                listView1.Items.Add(listViewItem);
            }
        }

        public List<DocTags> FilteredListByLanguage(List<DocTags> unfilteredList)
        {
            List<DocTags> filteredListByLanguage = new List<DocTags>();
            string languageFilter = languageComboBox.Text;
            foreach (DocTags listItem in listLoadedInListView)
            {
                if (listItem.Title.Equals(languageFilter))
                {
                    filteredListByLanguage.Add(listItem);
                }
            }
            return filteredListByLanguage;
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            pageNumber++;
            string languageFilter = languageComboBox.Text;

            if (languageFilter.Equals(""))
            {
                listLoadedInListView = _docTagsService.GetOnePageList(pageNumber);
            }
            else
            {
                listLoadedInListView = _docTagsService.GetOnePageList(languageFilter, pageNumber);
            }

            listView1.Items.Clear();

            foreach (DocTags listItem in listLoadedInListView)
            {
                string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                ListViewItem listViewItem = new ListViewItem(item);
                listView1.Items.Add(listViewItem);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
        pageNumber--;
        string languageFilter = languageComboBox.Text;
                if (languageFilter.Equals(""))
                {
                    listLoadedInListView = _docTagsService.GetOnePageList(pageNumber);
                }
                else
                {
                    listLoadedInListView = _docTagsService.GetOnePageList(languageFilter, pageNumber);
                }

                listView1.Items.Clear();

                foreach (DocTags listItem in listLoadedInListView)
                {
                    string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                    ListViewItem listViewItem = new ListViewItem(item);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void databaseComboBox_TextChanged(object sender, EventArgs e)
        {
            string databaseName = databaseComboBox.Text;

            _test1.AddColumsToListViewAccordingToDatabase(databaseName, listView1);
        }
    }
}
