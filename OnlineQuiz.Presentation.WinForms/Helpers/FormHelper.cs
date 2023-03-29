using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Presentation.WinForms.Helpers
{
    public class FormHelper : IFormHelper
    {

        public void SetFromFieldModel(Field<string> field, TextBox textBox, Label messageLabel)
        {
            textBox.Text = field.Value;

            messageLabel.Text = field.Message;

            if (!string.IsNullOrEmpty(field.Message))
            {
                if (field.Status == ModelStatusEnum.Error)
                    messageLabel.ForeColor = Color.Red;

                if (field.Status == ModelStatusEnum.Warning)
                    messageLabel.ForeColor = Color.Orange;

                if (field.Status == ModelStatusEnum.Fine)
                    messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Black;
            }
        }
    }
}
