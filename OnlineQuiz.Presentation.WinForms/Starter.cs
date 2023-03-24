//using OnlineQuiz.WinForms.Quizzes;

namespace OnlineQuiz.Presentation.WinForms
{
    internal class Starter
    {
        public Starter()
        {
        }

        private StarterResult result;

        public string str;

        public void Run()
        {
            StateName nextState = StateName.SelectMoodForm;
            bool repeatFlag = true;
            while (repeatFlag)
            {
                switch (nextState)
                {
                    case StateName.Exit:
                        result = StarterResult.Exit;
                        repeatFlag = false;
                        break;

                    case StateName.SelectMoodForm:
                        SelectMoodResults selectMoodResults = SelectMoodForm.Start();

                        if (selectMoodResults == SelectMoodResults.Exit)
                            nextState = StateName.Exit;

                        if (selectMoodResults == SelectMoodResults.QuizSelected)
                            nextState = StateName.QuizBrows;

                        if (selectMoodResults == SelectMoodResults.UserSelected)
                            nextState = StateName.LogInForm;

                        break;

                    case StateName.QuizBrows:
                        var quizBrowserFormResult = QuizBrowserForm.Start();

                        if (quizBrowserFormResult.result == QuizBrowserFormResults.Exit)
                            nextState = StateName.Exit;

                        if (quizBrowserFormResult.result == QuizBrowserFormResults.Back)
                            nextState = StateName.SelectMoodForm;

                        break;

                    case StateName.QuizSelected:
                        result = StarterResult.Guest;
                        repeatFlag = false;
                        break;

                    case StateName.LogInForm:
                        LogInResults logInResults = LogInForm.Start();

                        if (logInResults == LogInResults.Exit)
                            nextState = StateName.Exit;

                        if (logInResults == LogInResults.Back)
                            nextState = StateName.SelectMoodForm;

                        if (logInResults == LogInResults.OK)
                            nextState = StateName.LoggedIn;

                        break;

                    case StateName.LoggedIn:
                        result = StarterResult.user;
                        repeatFlag = false;
                        break;
                }
            }
        }

        private enum StateName
        {
            Exit,
            SelectMoodForm,
            QuizBrows,
            QuizSelected,
            LogInForm,
            LoggedIn,
        }
    }

    public enum StarterResult
    {
        user, Guest, Exit
    }
}
