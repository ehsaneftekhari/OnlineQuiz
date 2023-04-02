using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestBrowseForm : Form
    {

        private TestBrowseForm(ITestController testController, int userId)
        {
            InitializeComponent();

            this.testController = testController;
            UserId = userId;
        }

        public static TestBrowseForm Create(int userId, IServiceProvider serviceProvider)
        {
            if (instance == null || instance.IsDisposed)
            {
                ITestController testController = serviceProvider.GetRequiredService<ITestController>();
                instance = new(testController, userId);
            }
            return instance;
        }

        static TestBrowseForm instance;

        ITestController testController;
        int UserId;

        public Action<int> OnTestSelect;

        private void LoadListData()
        {
            testListDGV.DataSource = GetData();
            testListDGV.Columns["TestId"].Visible = false;
        }

        private List<TestViewModel> GetData()
        {
            return testController.GetTestsList(UserId, TestTitleTB.Text);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadListData();
        }

        private void testListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = testListDGV.Rows[e.RowIndex];
            var testId = row.Cells["TestId"].Value;
            InvokeOnTestSelect((int)testId);
        }

        private void InvokeOnTestSelect(int testId)
        {
            if (OnTestSelect != null)
                OnTestSelect.Invoke(testId);
        }
    }
}
