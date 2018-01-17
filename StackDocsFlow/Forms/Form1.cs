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
            docTags1.Title = "Title1";
            docTags1.CreationDate = new DateTime(2018, 1, 16, 16, 1, 48);

            DocTags docTags2 = new DocTags();
            docTags2.Id = 2;
            docTags2.Title = "Title2";
            docTags2.CreationDate = new DateTime(2019, 12, 16, 16, 1, 48);

            List<DocTags> list = new List<DocTags>();
            list.Add(docTags1);
            list.Add(docTags2);

            foreach (DocTags listItem in list)
            {
                string[] item = { Convert.ToString(listItem.Id), listItem.Title, Convert.ToString(listItem.CreationDate) };
                ListViewItem listViewItem = new ListViewItem(item);
                listView1.Items.Add(listViewItem);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
