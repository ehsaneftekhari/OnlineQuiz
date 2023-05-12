using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;
using System;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestBrowseForm : Form
    {
        ITestService testController;

        static List<TestBrowseForm> instanceList;

        private TestBrowseForm(IServiceProvider serviceProvider, int userId, string ownerName)
        {
            InitializeComponent();

            testController = serviceProvider.GetRequiredService<ITestService>();
            UserId = userId;

            LoadListData();
            OwnerName = ownerName;
        }

        public static TestBrowseForm Create(IServiceProvider serviceProvider, int userId, string ownerName)
        {
            if (instanceList == null)
                instanceList = new();

            TestBrowseForm instance = instanceList.FirstOrDefault(x => x.OwnerName == ownerName);

            if(instance == null || instance.IsDisposed)
            {
                instance = new(serviceProvider, userId, ownerName);
                instanceList.Add(instance);
            }

            return instance;
        }

        public string OwnerName { get; private set; }

        int UserId { get; set; }

        public Action<int> OnTestSelect { get; set; }

        public bool CloseAfterSelect { get; set; }

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = testListDGV.Rows[e.RowIndex];
                var testId = row.Cells["TestId"].Value;
                InvokeOnTestSelect((int)testId);
                CloseIfAllowed();
            }
        }

        private void InvokeOnTestSelect(int testId)
        {
            if (OnTestSelect != null)
                OnTestSelect.Invoke(testId);
        }

        private void CloseIfAllowed()
        {
            if(CloseAfterSelect)
                base.Close();
        }
    }
}
