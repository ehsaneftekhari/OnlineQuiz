using OnlineQuiz.Business.Models;

namespace OnlineQuiz.Presentation.WinForms.Helpers
{
    public interface IFormHelper
    {
        void SetFromFieldModel(Field<string> field, TextBox textBox, Label messageLabel);
    }
}