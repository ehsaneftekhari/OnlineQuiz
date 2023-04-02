namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IAppMessageRepository
    {
        string GetMessage(string messageTitle);
    }
}
