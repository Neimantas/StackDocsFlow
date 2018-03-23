using StackDocsFlow.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Models.DatabaseModels
{
    [Table("DocTags")]
    [Description("topic")]

    [ChildClassType(Type = typeof(Topic))]
    [ChildTableForeignIdName(Name = "DocTagId")]
    [ChildTableName(Name = "testJson")]
    public class DocTags
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
