using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    interface IService
    {
        List<Object> getListObject();
        List<Object> getListById(int id);
        List<Object> getListByName(string name);
    }
}
