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
        void AddColumsToListViewAccordingToDatabase(string database, ListView listView);
        List<ListViewItem> returnItemsListAccordingToSpecificType(string displayedItemsType, string id, int page);
    }
}
