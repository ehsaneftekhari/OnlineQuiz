namespace OnlineQuiz.Business.Models.Models
{
    public abstract class MessageModel
    {
        public string Message { get; set; }
        public void ClearMessage() => Message = null;
    }
}
