using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Services
{
    public class AppMessageService : IAppMessageService
    {
        IAppMessageRepository appMessageRepository;

        public AppMessageService(IAppMessageRepository appMessageRepository)
        {
            this.appMessageRepository = appMessageRepository;
        }

        public string GetMessage(string messageName)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(messageName, nameof(messageName));

            return appMessageRepository.GetMessage(messageName);
        }
    }
}
