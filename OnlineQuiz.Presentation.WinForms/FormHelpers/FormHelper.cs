using OnlineQuiz.Business.Models;

namespace OnlineQuiz.Presentation.WinForms.FormHelpers
{
    public class FormHelper : IFormHelper
    {

        public void SetTextFormValue(Field<string> field, TextBox textBox, Label messageLabel)
        {
            textBox.Text = field.Value;

            if (!field.IsFine())
                messageLabel.Text = field.Message;

            if (field.Status == ModelStatusEnum.Error)
                messageLabel.ForeColor = Color.Red;

            if (field.Status == ModelStatusEnum.Warning)
                messageLabel.ForeColor = Color.Orange;
        }
    }
}
