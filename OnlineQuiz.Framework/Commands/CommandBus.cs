using OnlineQuiz.Framework.EventAbstractions;
using System.Collections.Generic;
using System.Data;

namespace OnlineQuiz.Framework.Commands
{
    public class CommandBus : ICommandBus, IFluentCommand
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IEventBus eventBus;
        private dynamic _command;
        public CommandBus(IServiceProvider serviceProvider, IEventBus eventBus)
        {
            this.serviceProvider = serviceProvider;
            this.eventBus = eventBus;
        }

        public void Dispatch<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = ExtractHandlersFor(command);

            handlers.ForEach(x => x.Handle(command));
        }

        public Task DispatchAsync()
        {
            var handlers = ExtractHandlersFor(_command);

            Task task = new Task(() =>
            {
                foreach (var handler in handlers)
                {
                    handler.Handle(_command, eventBus);
                }
            }
            );
            task.Start();

            return task;
        }

        public IFluentCommand Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            _command = command;
            return this;
        }

        public IFluentCommand Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent
        {
            eventBus.Subscribe(@event);
            return this;
        }

        private List<ICommandHandler<TCommand>> ExtractHandlersFor<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();
            return handlers;
        }
    }
}
