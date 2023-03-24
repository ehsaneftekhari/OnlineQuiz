using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IAppMessageRepository
    {
        string GetMessage(string messageTitle);
    }
}
