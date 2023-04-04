using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;

namespace OnlineQuiz.Presentation.WinForms.Helpers
{
    public class FormHelper : IFormHelper
    {
        public void FillForm(Field<DateTime?> field, DateTimePicker dateTimePicker, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), dateTimePicker, nameof(dateTimePicker));

            if (field.Value != null)
                dateTimePicker.Value = (DateTime)field.Value;

            SetMessage(field, messageLabel);
        }

        public void FillForm(Field<int> field, ComboBox comboBox, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), comboBox, nameof(comboBox));

            comboBox.SelectedIndex = field.Value;

            SetMessage(field, messageLabel);
        }

        public void FillForm(Field<string> field, TextBox textBox, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), textBox, nameof(textBox));

            textBox.Text = field.Value;

            SetMessage(field, messageLabel);
        }

        public void FillForm(Field<bool> field, CheckBox checkBox, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), checkBox, nameof(checkBox));

            checkBox.Checked = field.Value;

            SetMessage(field, messageLabel);
        }

        public void SetMessage(StatusMessageModel field, Label? messageLabel)
        {
            if (messageLabel != null)
            {
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
}
