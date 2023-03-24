namespace OnlineQuiz.Framework.EventAbstractions
{
    public class EventBus : IEventBus
    {
        private IList<object> eventHandlers;

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var handles = eventHandlers.OfType<Action<TEvent>>().ToList();

            if (handles.Any())
                handles.ForEach(x => x.Invoke(@event));
        }

        public void Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent
        {
            throw new NotImplementedException();
        }
    }
}
