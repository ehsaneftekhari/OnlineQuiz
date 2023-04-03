using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Presentation.WinForms.Helpers
{
    public interface IFormHelper
    {
        void FillForm(Field<string> field, TextBox textBox, Label? messageLabel = null);
        void FillForm(Field<bool> field, CheckBox checkBox, Label? messageLabel = null);
        void SetMessage(StatusMessageModel field, Label? messageLabel);
    }
}