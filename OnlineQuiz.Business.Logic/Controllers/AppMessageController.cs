using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class AppMessageController : IAppMessageController
    {
        IAppMessageRepository appMessageRepository;

        public AppMessageController(IAppMessageRepository appMessageRepository)
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
