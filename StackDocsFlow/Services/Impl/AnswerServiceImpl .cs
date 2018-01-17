using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackDocsFlow.Models.DatabaseModels;

namespace StackDocsFlow.Services.Impl
{
    public class AnswerServiceImpl : IAnswerService
    {
        public string getAnswerFromTopic(Topic topic)
        {
            return topic.Answer;
        }
    }
}
