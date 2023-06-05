using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.Events.QuestionEvents;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Events.EventAggregators;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.UserControls.QuestionUserControls;
using Prism.Events;
using System;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class QuestionDesignForm : Form
    {
        #region singelton
        static QuestionDesignForm instance;
        #endregion

        readonly IServiceProvider serviceProvider;
        readonly ITestService testService;
        readonly ISectionService sectionService;
        readonly IQuestionService questionService;
        readonly ICurrentUserInfoContainer currentUserInfoContainer;
        readonly ICustomEventAggregator eventAggregator;

        readonly int userId;

        #region Test Select ComboBox
        List<TestViewModel> AllTestsViewModels;
        List<TestViewModel> ComboBoxTests;
        #endregion

        #region Section Select ComboBox
        List<SectionViewModel> AllSectionsViewModels;
        List<SectionViewModel> ComboBoxSections;
        #endregion

        QuestionDesignForm(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.currentUserInfoContainer = serviceProvider.GetRequiredService<ICurrentUserInfoContainer>();
            this.testService = serviceProvider.GetRequiredService<ITestService>();
            this.sectionService = serviceProvider.GetRequiredService<ISectionService>();
            this.questionService = serviceProvider.GetRequiredService<IQuestionService>();
            this.eventAggregator = serviceProvider.GetRequiredService<ICustomEventAggregator>();

            userId = currentUserInfoContainer.User.BaseUserId;

            InitializeComponent();

            TestSelectComboBoxInitialize();
            SectionSelectComboBoxInitialize();

            eventAggregator.Subscribe<QuestionAddEvent, QuestionEventsPayload>(UpdateQuestionGV);
        }

        public QuestionDesignForm(IServiceProvider serviceProvider, TestViewModel selectedTest, SectionViewModel selectedSection) : this(serviceProvider)
        {
            if (SelectedTest != null)
                SelectedTest = selectedTest;

            if (SelectedSection != null)
                SelectedSection = selectedSection;
        }

        public QuestionDesignForm(IServiceProvider serviceProvider, int? selectedTestId = null, int? selectedSectionId = null) : this(serviceProvider)
        {
            if (selectedTestId != null && selectedTestId.HasValue)
                SelectedTest = testService.GetTest(selectedTestId.Value).ToViewModel();

            if (selectedSectionId != null && selectedTestId.HasValue)
                SelectedSection = sectionService.GetSection(selectedSectionId.Value).ToViewModel();
        }

        #region singelton

        public static QuestionDesignForm Crete(IServiceProvider serviceProvider)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new QuestionDesignForm(serviceProvider);
            }
            return instance;
        }

        public static QuestionDesignForm Crete(IServiceProvider serviceProvider, TestViewModel selectedTest, SectionViewModel selectedSection = null)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new QuestionDesignForm(serviceProvider, selectedTest, selectedSection);
            }
            return instance;
        }

        public static QuestionDesignForm Crete(IServiceProvider serviceProvider, int? selectedTestId, int? selectedSectionId = null)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new QuestionDesignForm(serviceProvider, selectedTestId, selectedSectionId);
            }
            return instance;
        }

        #endregion


        #region Test Select ComboBox Properties
        TestViewModel SelectedTest
        {
            get
            {
                TestViewModel result = null;
                if (HasTestComboBoxItems()
                    && HadTestComboBoxSelectedItem())
                    result = ComboBoxTests.ElementAt(TestSelectCB.SelectedIndex);

                return result;
            }
            set
            {
                ComboBoxTests.Clear();
                ComboBoxTests.Add(value);
                TestSelectCB.Items.Clear();
                TestSelectCB.Items.Add(GenerateStringOfTest(value));
                TestSelectCB.SelectedIndex = 0;
            }
        }
        #endregion

        #region Section Select ComboBox Properties
        SectionViewModel SelectedSection
        {
            get
            {
                SectionViewModel result = null;
                if (HasSectionComboBoxItems()
                    && HadSectionComboBoxSelectedItem())
                    result = ComboBoxSections.ElementAt(SectionSelectCB.SelectedIndex);

                return result;
            }
            set
            {
                ComboBoxSections.Clear();
                ComboBoxSections.Add(value);
                ClearSectionComboBox();
                SectionSelectCB.Items.Add(GenerateStringOutOfSection(value));
                SectionSelectCB.SelectedIndex = 0;
            }
        }
        #endregion


        #region Test Select ComboBox

        void TestSelectComboBoxInitialize()
        {
            this.AllTestsViewModels = new List<TestViewModel>();
            this.ComboBoxTests = new List<TestViewModel>();
            UpdateAllTestsViewModels();
            UpdateTestComboBoxItems();
        }

        void UpdateAllTestsViewModels()
        {
            AllTestsViewModels.Clear();
            AllTestsViewModels.AddRange(this.GetTestsSeedData());
        }

        List<TestViewModel> GetTestsSeedData(string TestTitle = "") => testService.GetTestsList(userId, TestTitle);

        bool HasTestComboBoxItems() => ComboBoxTests.Count > 0;

        bool HadTestComboBoxSelectedItem() => TestSelectCB.SelectedIndex >= 0 && TestSelectCB.SelectedIndex < ComboBoxTests.Count;

        string GenerateStringOfTest(TestViewModel test) => $"{test.TestId} _ {test.Title}";

        string[] TestsToStringArray(List<TestViewModel> testViewModels) => testViewModels.Select(test => GenerateStringOfTest(test)).ToArray();

        void UpdateTestComboBoxItems()
        {
            ComboBoxTests = AllTestsViewModels.FindAll(test => test.Title.Contains(TestSelectCB.Text));
            var ItemsStr = TestsToStringArray(ComboBoxTests);
            TestSelectCB.Items.Clear();
            TestSelectCB.Items.AddRange(ItemsStr);
        }

        void TestSelectCB_OnTextUpdate(object sender, EventArgs e)
        {
            UpdateTestComboBoxItems();
            UpdateSectionComboBoxItems();
        }

        private void TestSelectCB_SelectedIndexChanged(object sender, EventArgs e) => SectionSelectComboBoxInitialize();

        #endregion


        #region Section Select ComboBox

        void SectionSelectComboBoxInitialize()
        {
            this.AllSectionsViewModels = new List<SectionViewModel>();
            this.ComboBoxSections = new List<SectionViewModel>();
            UpdateAllSectionsViewModels();
            UpdateSectionComboBoxItems();
        }

        bool HasSectionComboBoxItems() => ComboBoxSections.Count > 0;

        bool HadSectionComboBoxSelectedItem() => SectionSelectCB.SelectedIndex >= 0 && SectionSelectCB.SelectedIndex < ComboBoxSections.Count;

        void UpdateAllSectionsViewModels()
        {
            AllSectionsViewModels.Clear();
            var sectionsSeedData = GetSectionsSeedData();
            if (sectionsSeedData != null)
                AllSectionsViewModels.AddRange(sectionsSeedData);
        }

        List<SectionViewModel> GetSectionsSeedData(string TestTitle = "")
        {
            var selectedTest = SelectedTest;
            if (selectedTest != null)
                return sectionService.GetSectionViewModelList(selectedTest.TestId);
            return null;
        }

        string GenerateStringOutOfSection(SectionViewModel test) => $"{test.SectionId} _ {test.SectionTitle}";

        string[] SectionsToStringArray(List<SectionViewModel> sectionViewModels) => sectionViewModels.Select(section => GenerateStringOutOfSection(section)).ToArray();


        void UpdateSectionComboBoxItems()
        {
            ClearSectionComboBox();

            if (!HasTestComboBoxItems() || !HadTestComboBoxSelectedItem())
            {
                SectionSelectCB.Items.Add("Select an Item in 'Test'");
                return;
            }

            ComboBoxSections = AllSectionsViewModels.FindAll(section => section.SectionTitle.Contains(SectionSelectCB.Text));
            if (ComboBoxSections.Count() == 0)
            {
                SectionSelectCB.Items.Add("There is no Sections to select");
                return;
            }

            var ItemsStr = SectionsToStringArray(ComboBoxSections);
            SectionSelectCB.Items.AddRange(ItemsStr);
        }

        void ClearSectionComboBox()
        {
            SectionSelectCB.Items.Clear();
            SectionSelectCB.Text = string.Empty;
        }

        void SectionSelectCB_OnTextUpdate(object sender, EventArgs e) => UpdateSectionComboBoxItems();

        private void SectionSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQuestionGV();
        }


        #endregion


        #region Question Grid View

        void UpdateQuestionGV(IQuestionEventsPayload payload)
        {
            if (payload != null && payload.Question.sectionId == SelectedSection.SectionId)
                UpdateQuestionGV();

        }

        void UpdateQuestionGV()
        {
            QuestionGV.DataSource = GetQuestionSeedData();
            SetSettingsQuestionGV();
        }

        void SetSettingsQuestionGV()
        {
            QuestionGV.Columns["QuestionId"].Visible = false;
            QuestionGV.Columns["SectionId"].Visible = false;
            QuestionGV.Columns["ImageAddress"].Visible = false;
            QuestionGV.Columns["Score"].Width = QuestionGV.Columns["Score"].Width == 250 ? 50 : QuestionGV.Columns["Score"].Width;
            QuestionGV.Columns["Duration"].Width = QuestionGV.Columns["Duration"].Width == 250 ? 200 : QuestionGV.Columns["Duration"].Width;
            QuestionGV.Columns["Order"].Width = QuestionGV.Columns["Order"].Width == 250 ? 50 : QuestionGV.Columns["Order"].Width;
            QuestionGV.Columns["Text"].Width = 250;
            QuestionGV.Columns["Text"].DisplayIndex = 0;
        }

        List<QuestionViewModel> GetQuestionSeedData() => questionService.GetQuestionList(SelectedSection.SectionId).ToList();

        #endregion

        #region QuestionUserControl

        private void AddAddQuestionUserControlToPanel1IfIsEmpty()
        {
            if (IsPanel1Empty() && SelectedSection != null)
            {
                var addQuestionUserControl = CreateAddQuestionUserControl(serviceProvider, SelectedSection);
                AddControlToPanel1(addQuestionUserControl);
            }
        }

        private bool IsPanel1Empty() => splitContainer1.Panel1.Controls.Count == 0;

        private void AddControlToPanel1(Control control)
        {
            if (IsPanel1Empty())
            {
                splitContainer1.Panel1.Controls.Add(control);
            }
        }

        private void RemovePanel1InnerControl()
            => splitContainer1.Panel1.Controls.Clear();


        private AddQuestionUserControl CreateAddQuestionUserControl(IServiceProvider serviceProvider, SectionViewModel SelectedSection)
        {
            if (serviceProvider != null && SelectedSection != null)
            {
                var addQuestionUserControl = new AddQuestionUserControl(serviceProvider, SelectedSection);
                addQuestionUserControl.Dock = DockStyle.Fill;
                addQuestionUserControl.Location = new Point(0, 0);
                addQuestionUserControl.Name = "addQuestionUserControl";
                //addQuestionUserControl.Size = new Size(1554, 1509);
                addQuestionUserControl.TabIndex = 0;
                return addQuestionUserControl;
            }
            return null;
        }

        #endregion

        #region Ui Actions
        private void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            RemovePanel1InnerControl();
            AddAddQuestionUserControlToPanel1IfIsEmpty();
        }

        #endregion
    }
}
