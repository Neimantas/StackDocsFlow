using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Models.DatabaseModels
{
    [Table("testJson")]
    public class Topic
    {
        public int Id { get; set; }
        public long DocTagId { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
    }
}
