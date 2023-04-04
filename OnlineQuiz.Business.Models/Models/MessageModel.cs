namespace OnlineQuiz.Business.Models.Models
{
    public abstract class MessageModel
    {
        public MessageModel()
        {
            ClearMessage();
        }
        public string Message { get; set; }
        public void ClearMessage() => Message = "";
    }
}
