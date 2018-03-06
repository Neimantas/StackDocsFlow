using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackDocsFlow.TestService
{
    public interface ITest1
    {
        void AddColumsToListViewAccordingToDataModel(string database, ListView listView);
        List<ListViewItem> returnItemsListAccordingToSpecificType(string displayedItemsType, string id, int pageNumber, string language);
        List<ListViewItem> returnItemsListAccordingToSpecificType2(Object objectArgument, int pageNumber, string language);
        string returnListViewItemType(ListView listView1);
        int GetPageCount(ListView listView1);
        string GetListViewItemId(string typeOfItem, ListView listView1);
        string GetItemForeignIdName(ListView listView1, string tableType);
    }

    
}
