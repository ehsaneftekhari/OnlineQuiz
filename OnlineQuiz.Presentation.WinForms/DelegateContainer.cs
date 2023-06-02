namespace OnlineQuiz.Presentation.WinForms
{
    public class DelegateContainer : IDelegateContainer
    {
        public Action<int> TestExplorerFormOpener { get; set; }
        public Action<Form> NewChildFormAdder { get; set; }
    }
    public interface IDelegateContainer
    {
        Action<int> TestExplorerFormOpener { get; set; }
        public Action<Form> NewChildFormAdder { get; set; }
    }
}
