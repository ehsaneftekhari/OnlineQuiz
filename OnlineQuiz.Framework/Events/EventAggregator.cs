namespace OnlineQuiz.Framework.EventAbstractions
{
    public class EventAggregator : IEventBus
    {
        private IList<object> eventHandlers;

        public EventAggregator()
        {
            eventHandlers = new List<object>();
        }

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var handles = eventHandlers.OfType<Action<TEvent>>().ToList();

            if (handles.Any())
                handles.ForEach(x => x.Invoke(@event));
        }

        public void Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent
        {
            eventHandlers.Add(@event);
        }
    }
}
