using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        public void FillForm(Field<TimeSpan?> field, DateTimePicker dateTimePicker, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), dateTimePicker, nameof(dateTimePicker));

            if (field.Value != null)
            {
                TimeSpan timeSpan = (TimeSpan)field.Value;

                DateTime dateTime = new DateTime();

                dateTimePicker.Value = new(1, 1, 1, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }

            SetMessage(field, messageLabel);
        }

        public void FillForm(Field<int> field, ComboBox comboBox, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), comboBox, nameof(comboBox));


            comboBox.SelectedIndex = field.Value;

            SetMessage(field, messageLabel);
        }

        public void FillForm(Field<int?> field, NumericUpDown numericUpDown, Label? messageLabel = null)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field), numericUpDown, nameof(numericUpDown));

            if (field.Value != null)
                numericUpDown.Value = (int)field.Value;

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

        public DateTime CombineDateTime(DateTime Date, DateTime Time)
        {
            DateTime dateTime = new(Date.Year, Date.Month, Date.Day, Time.Hour, Time.Minute, Time.Second);
            return dateTime;
        }
    }
}
