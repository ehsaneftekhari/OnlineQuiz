using OnlineQuiz.Framework.EventAbstractions;

namespace OnlineQuiz.Framework.Commands
{
    public interface IFluentCommand
    {
        IFluentCommand Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent;

        Task DispatchAsync();
    }
}
