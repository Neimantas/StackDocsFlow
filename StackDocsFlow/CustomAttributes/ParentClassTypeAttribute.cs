using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class ParentClassTypeAttribute : Attribute
    {
        public Type Type { get; set; }
    }
}
