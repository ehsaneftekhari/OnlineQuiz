namespace OnlineQuiz.Framework.Commands
{
    public interface ICommandBus
    {
        void Dispatch<TCommand>(TCommand command) where TCommand : ICommand;
        IFluentCommand Execute<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
