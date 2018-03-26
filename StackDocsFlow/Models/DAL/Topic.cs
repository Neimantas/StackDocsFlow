using StackDocsFlow.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Models.DatabaseModels
{
    [Table("testJson")]
    
    [ParentClassType(Type = typeof(DocTags))]
    [ParentTableName(Name = "DocTags")]
    public class Topic
    {
        public int Id { get; set; }
        public long DocTagId { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
        public string CreationDate { get; set; }
        public string LastEditDate { get; set; }
    }
}
