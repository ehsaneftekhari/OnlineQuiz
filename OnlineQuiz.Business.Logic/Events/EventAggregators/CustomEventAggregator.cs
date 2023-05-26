using OnlineQuiz.Business.Abstractions.Events;
using Prism.Events;
using System;

namespace OnlineQuiz.Business.Logic.Events.EventAggregators
{
    public class CustomEventAggregator : EventAggregator, ICustomEventAggregator
    {
        private readonly Dictionary<Type, EventBase> events = new Dictionary<Type, EventBase>();

        public void Publish<TEvent, TPayload>() where TEvent : PubSubEvent, new()
            => GetEvent<TEvent>().Publish();

        public void Publish<TEvent, TPayload>(TPayload @event) where TEvent : PubSubEvent<TPayload>, new()
            =>GetEvent<TEvent>().Publish(@event);

        public void Subscribe<TEvent>(Action action) where TEvent : PubSubEvent, new()
            => GetEvent<TEvent>().Subscribe(action);

        public void Subscribe<TEvent, TPayload>(Action<TPayload> action) where TEvent : PubSubEvent<TPayload>, new()
            => GetEvent<TEvent>().Subscribe(action);

        public void UnSubscribe<TEvent>(Action action) where TEvent : PubSubEvent, new()
            => GetEvent<TEvent>().Unsubscribe(action);

        public void UnSubscribe<TEvent, TPayload>(Action<TPayload> action) where TEvent : PubSubEvent<TPayload>, new()
        => GetEvent<TEvent>().Unsubscribe(action);
    }
}
