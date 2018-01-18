using StackDocsFlow.Models.DatabaseModels;
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
        List<DocTags> listLoadedInListView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            DocTags docTags1 = new DocTags();
            docTags1.Id = 1;
            docTags1.Title = "Java";
            docTags1.CreationDate = new DateTime(2018, 1, 16, 16, 1, 48);

            DocTags docTags2 = new DocTags();
            docTags2.Id = 2;
            docTags2.Title = "PHP";
            docTags2.CreationDate = new DateTime(2019, 12, 16, 16, 1, 48);

            DocTags docTags3 = new DocTags();
            docTags3.Id = 3;
            docTags3.Title = "Javascript";
            docTags3.CreationDate = new DateTime(2020, 12, 16, 16, 1, 48);

            DocTags docTags4 = new DocTags();
            docTags4.Id = 4;
            docTags4.Title = "Swift";
            docTags4.CreationDate = new DateTime(2021, 12, 16, 16, 1, 48);

            DocTags docTags5 = new DocTags();
            docTags5.Id = 5;
            docTags5.Title = "PHP";
            docTags5.CreationDate = new DateTime(2022, 12, 16, 16, 1, 48);

            DocTags docTags6 = new DocTags();
            docTags6.Id = 6;
            docTags6.Title = "Swift";
            docTags6.CreationDate = new DateTime(2023, 12, 16, 16, 1, 48);

            DocTags docTags7 = new DocTags();
            docTags7.Id = 7;
            docTags7.Title = "Javascript";
            docTags7.CreationDate = new DateTime(2024, 12, 16, 16, 1, 48);

            DocTags docTags8 = new DocTags();
            docTags8.Id = 8;
            docTags8.Title = "PHP";
            docTags8.CreationDate = new DateTime(2025, 12, 16, 16, 1, 48);

            DocTags docTags9 = new DocTags();
            docTags9.Id = 9;
            docTags9.Title = "Java";
            docTags9.CreationDate = new DateTime(2026, 12, 16, 16, 1, 48);

            DocTags docTags10 = new DocTags();
            docTags10.Id = 10;
            docTags10.Title = "Swift";
            docTags10.CreationDate = new DateTime(2027, 12, 16, 16, 1, 48);

            DocTags docTags11 = new DocTags();
            docTags11.Id = 11;
            docTags11.Title = "PHP";
            docTags11.CreationDate = new DateTime(2028, 12, 16, 16, 1, 48);

            List<DocTags> list = new List<DocTags>();
            list.Add(docTags1);
            list.Add(docTags2);
            list.Add(docTags3);
            list.Add(docTags4);
            list.Add(docTags5);
            list.Add(docTags6);
            list.Add(docTags7);
            list.Add(docTags8);
            list.Add(docTags9);
            list.Add(docTags10);
            list.Add(docTags11);

            listView1.Items.Clear();
            listLoadedInListView = list;

            foreach (DocTags listItem in list)
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
    }
}
