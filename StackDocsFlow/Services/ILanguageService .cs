using StackDocsFlow.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDocsFlow.Services
{
    interface ILanguageService
    {
        Languages setEnums(String langName);
    }
}
