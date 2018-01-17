using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Models.DatabaseModels
{
    public class Examples
    {
        public long Id { get; set; }
        public long docTopicId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CeationDate { get; set; }
        public DateTime LastEditDate { get; set; }
    }
}
