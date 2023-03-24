using OnlineQuiz.Framework.EventAbstractions;

namespace OnlineQuiz.Framework.Commands
{
    public interface ICommandHandler<ICommand>
    {
        void Handle(ICommand command);
        void Handle(ICommand command, IEventBus eventBus);
    }
}
