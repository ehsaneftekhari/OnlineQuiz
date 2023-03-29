using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models.Models
{
    public abstract class StatusModel : MessageModel
    {
        private ModelStatusEnum _Status;

        public ModelStatusEnum Status
        {
            get => _Status;
            set
            {
                _Status = value;
                if (value == ModelStatusEnum.Fine)
                    ClearMessage();
            }
        }

        public bool IsFine() => Status == ModelStatusEnum.Fine;

        public void SetFine() => Status = ModelStatusEnum.Fine;
    }
}
