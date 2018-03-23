using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class ChildTableNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
