namespace OnlineQuiz.Library
{
    public class ThrowHelper
    {
        public static void ThrowNullArgumentException(params object[] arguments)
        {
            for (int i = 0; i < arguments.Length; i += 2)
            {
                object arg = arguments[i];
                if (arg == null)
                    throw new ArgumentNullException(arguments[i + 1].ToString() + " can not be null");
            }
        }

        public static void ThrowNullOrEmptyStringException(params string[] arguments)
        {
            ThrowNullArgumentException(arguments);

            for (int i = 0; i < arguments.Length; i += 2)
            {
                string arg = arguments[i];
                if (arg.Length == 0)
                    throw new ArgumentOutOfRangeException(arguments[i + 1].ToString() + " can not be empty");
            }
        }

        public static void ThrowNullOrEmptyArrayException(object[] array, string argumentName)
        {
            ThrowNullArgumentException(array, argumentName);

            if (array.Length == 0)
                throw new ArgumentException(argumentName + " can not be empty");

        }
    }
}
