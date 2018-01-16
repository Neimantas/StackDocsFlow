using StackDocsFlow.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackDocsFlow.Services
{
    interface IAnswerService
    {
        string getAnswerFromTopic(Topic topic);
    }
}
