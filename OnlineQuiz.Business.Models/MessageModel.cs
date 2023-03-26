using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models
{
    public abstract class MessageModel
    {
        public string Message { get; set; }
        public void ClearMessage() => Message = null;
    }
}
