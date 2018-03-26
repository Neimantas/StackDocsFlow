using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Models.DatabaseModels
{
    [Table("examples")]
    public class Examples
    {
        public long Id { get; set; }
        public long docTopicId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CeationDate { get; set; }
        public string LastEditDate { get; set; }
    }
}
