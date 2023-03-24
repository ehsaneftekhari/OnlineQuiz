using OnlineQuiz.Business.Models;

namespace OnlineQuiz.Presentation.WinForms.FormHelpers
{
    public interface IFormHelper
    {
        void SetTextFormValue(Field<string> field, TextBox textBox, Label messageLabel);
    }
}