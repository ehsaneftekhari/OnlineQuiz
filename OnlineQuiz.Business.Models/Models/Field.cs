using OnlineQuiz.Business.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models.Models
{
    public class Field<Type> : StatusModel, IFine
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


        Func<Type, string> CheckWarning { get; set; }

        Func<Type, string> CheckError { get; set; }

        public Field()
        {
            Value = default;
        }

        public Field(Type value)
        {
            Value = value;
        }

        public Field(Func<Type, string> checkWarning, Func<Type, string> checkError)
        {
            CheckWarning = checkWarning;
            CheckError = checkError;
        }

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
