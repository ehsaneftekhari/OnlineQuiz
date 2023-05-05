using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Presentation.WinForms.Helpers
{
    public interface IFormHelper
    {
        void FillForm(Field<DateTime?> field, DateTimePicker dateTimePicker, Label? messageLabel = null);
        void FillForm(Field<TimeSpan?> field, DateTimePicker dateTimePicker, Label? messageLabel = null);
        void FillForm(Field<int> field, ComboBox comboBox, Label? messageLabel = null);
        void FillForm(Field<int?> field, NumericUpDown comboBox, Label? messageLabel = null);
        void FillForm(Field<string> field, TextBox textBox, Label? messageLabel = null);
        void FillForm(Field<bool> field, CheckBox checkBox, Label? messageLabel = null);
        void SetMessage(StatusMessageModel field, Label? messageLabel);
        DateTime CombineDateTime(DateTime Date, DateTime Time);
    }
}