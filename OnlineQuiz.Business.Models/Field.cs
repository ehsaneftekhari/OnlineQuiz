using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models
{
    public class Field<Type>
    {
        private Type? _value;

        public Type? Value
        {
            get => _value;
            set
            {
                _value = value;

                InvokeChecks(value);
            }
        }

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

        public string Message { get; set; }

        Func<Type, string> CheckWarning { get; set; }

        Func<Type, string> CheckError { get; set; }

        public Field()
        {
            Value = default(Type);
        }

        public Field(Func<Type, string> checkWarning, Func<Type, string> checkError)
        {
            CheckWarning = checkWarning;
            CheckError = checkError;
        }

        public bool IsFine() => Status == ModelStatusEnum.Fine;

        public void SetFine() => Status = ModelStatusEnum.Fine;

        public void ClearMessage() => Message = null;

        private void InvokeChecks(Type value)
        {
            InvokeCheckError(value);
            InvokeWarning(value);
        }

        private void InvokeCheckError(Type value)
        {
            if (value != null && CheckError != null)
            {
                string message = CheckError.Invoke(value);
                if (message != null)
                {
                    Status = ModelStatusEnum.Error;
                    Message = message;
                }
            }
        }

        private void InvokeWarning(Type value)
        {
            if (Status != ModelStatusEnum.Fine && value != null && CheckWarning != null)
            {
                string message = CheckWarning.Invoke(value);
                if (message != null)
                {
                    Status = ModelStatusEnum.Warning;
                    Message = message;
                }
            }
        }
    }
}
