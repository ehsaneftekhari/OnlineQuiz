using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models
{
    public class Field<Type> : StatusMessageModel, IFine
    {
        private Type? _value;

        public bool HasValue => _value != null;

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

        public Field() : base()
        {
            Value = default;
        }

        public Field(Type value) : this()
        {
            Value = value;
        }

        public Field(Func<Type, string> checkWarning, Func<Type, string> checkError) : this()
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
