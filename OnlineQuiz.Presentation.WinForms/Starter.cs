using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Presentation.WinForms
{
    internal class Starter
    {
        IServiceProvider serviceProvider;

        BaseUser? baseUser;

        public Starter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public (StarterResult result, Form? form) Run()
        {
            StarterResult result = StarterResult.Exit;

            State nextState = State.SelectMoodForm;

            bool repeatFlag = true;

            while (repeatFlag)
            {
                switch (nextState)
                {
                    case State.Exit:
                        result = StarterResult.Exit;
                        repeatFlag = false;
                        break;


                    case State.SelectMoodForm:
                        SelectMoodResults selectMoodResults = SelectMoodForm.Start();

                        if (selectMoodResults == SelectMoodResults.Exit)
                            nextState = State.Exit;

                        if (selectMoodResults == SelectMoodResults.QuizSelected)
                            nextState = State.RegisterBaseInfo;

                        if (selectMoodResults == SelectMoodResults.LogInSelected)
                            nextState = State.LogInForm;

                        break;


                    case State.RegisterBaseInfo:
                        var BaseUserRegisterInfoFormResult = BaseUserRegisterInfoForm.Start(serviceProvider, baseUser);

                        if (BaseUserRegisterInfoFormResult.result == BaseUserRegisterInfoResults.Exit)
                            nextState = State.Exit;

                        if (BaseUserRegisterInfoFormResult.result == BaseUserRegisterInfoResults.Back)
                            nextState = State.SelectMoodForm;

                        baseUser = BaseUserRegisterInfoFormResult.baseUser;

                        if (BaseUserRegisterInfoFormResult.result == BaseUserRegisterInfoResults.Registered)
                            nextState = State.QuizBrows;
                        break;


                    case State.QuizBrows:
                        var quizBrowserFormResult = QuizBrowserForm.Start();

                        if (quizBrowserFormResult.result == QuizBrowserFormResults.Exit)
                            nextState = State.Exit;

                        if (quizBrowserFormResult.result == QuizBrowserFormResults.Back)
                            nextState = State.RegisterBaseInfo;

                        break;


                    case State.QuizSelected:
                        result = StarterResult.Guest;
                        repeatFlag = false;
                        break;


                    case State.LogInForm:
                        LogInResults logInResults = LogInForm.Start();

                        if (logInResults == LogInResults.Exit)
                            nextState = State.Exit;

                        if (logInResults == LogInResults.Back)
                            nextState = State.SelectMoodForm;

                        if (logInResults == LogInResults.OK)
                            nextState = State.LoggedIn;

                        break;


                    case State.LoggedIn:
                        result = StarterResult.user;
                        repeatFlag = false;
                        break;
                }
            }

            return (result, null);
        }

        private enum State
        {
            Exit,
            SelectMoodForm,
            RegisterBaseInfo,
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
