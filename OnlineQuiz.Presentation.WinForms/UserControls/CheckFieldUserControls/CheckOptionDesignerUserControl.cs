namespace OnlineQuiz.Presentation.WinForms.UserControls.CheckFieldUserControls
{
    public partial class CheckOptionDesignerUserControl : UserControl
    {

        private OpenFileDialog openFileDialog;

        public CheckOptionDesignerUserControl(OpenFileDialog openFileDialog, Action onChange)
        {
            this.openFileDialog = openFileDialog;
            InitializeComponent();

            this.OnChange = onChange;
        }

        public decimal Score => ScoreNUD.Value;

        public string ImageAddress
        {
            get => ImageAddressTB.Text;
            set => ImageAddressTB.Text = value;
        }

        public string Text => TextRTB.Text;

        public Action OnChange { get; set; }

        private void InvokeOnChange()
        {
            if (OnChange != null)
                OnChange.Invoke();
        }

        private void ScoreNUD_ValueChanged(object sender, EventArgs e) => InvokeOnChange();

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            ImageAddress = openFileDialog.FileName.Trim();
        }
    }
}
