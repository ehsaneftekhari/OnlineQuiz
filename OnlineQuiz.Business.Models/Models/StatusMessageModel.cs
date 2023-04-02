﻿using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models
{
    public abstract class StatusMessageModel : MessageModel, IFine
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
    }
}
