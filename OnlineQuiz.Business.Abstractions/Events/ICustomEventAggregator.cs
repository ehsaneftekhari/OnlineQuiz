using Prism.Events;

namespace OnlineQuiz.Business.Abstractions.Events
{
    public interface ICustomEventAggregator : IEventAggregator
    {
        void Publish<TEvent, TPayload>() where TEvent : PubSubEvent, new();

        void Publish<TEvent, TPayload>(TPayload @event) where TEvent : PubSubEvent<TPayload>, new();

        void Subscribe<TEvent>(Action action) where TEvent : PubSubEvent, new();

        void Subscribe<TEvent, TPayload>(Action<TPayload> action) where TEvent : PubSubEvent<TPayload>, new();

        void UnSubscribe<TEvent>(Action action) where TEvent : PubSubEvent, new();

        void UnSubscribe<TEvent, TPayload>(Action<TPayload> action) where TEvent : PubSubEvent<TPayload>, new();
    }
}
