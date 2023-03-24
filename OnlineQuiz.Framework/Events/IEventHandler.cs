namespace OnlineQuiz.Framework.EventAbstractions
{
    public interface IEventHandler<IEvent>
    {
        void Handle(IEvent @event);
    }
}
