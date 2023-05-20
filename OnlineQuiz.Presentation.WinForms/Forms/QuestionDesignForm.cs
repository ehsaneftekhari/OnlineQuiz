using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Business.Models.Models.Tests;
using static System.Collections.Specialized.BitVector32;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class QuestionDesignForm : Form
    {
        #region singelton
        static QuestionDesignForm instance;
        #endregion

        readonly ITestService testService;
        readonly ISectionService sectionService;
        readonly IQuestionService questionService;
        readonly int baseUserId;

        #region Test Select ComboBox
        List<TestViewModel> AllTestsViewModels;
        List<TestViewModel> ComboBoxTests;
        #endregion

        #region Section Select ComboBox
        List<SectionViewModel> AllSectionsViewModels;
        List<SectionViewModel> ComboBoxSections;
        #endregion

        QuestionDesignForm(IServiceProvider serviceProvider, int baseUserId)
        {
            this.baseUserId = baseUserId;
            this.testService = serviceProvider.GetRequiredService<ITestService>();
            this.sectionService = serviceProvider.GetRequiredService<ISectionService>();
            this.questionService = serviceProvider.GetRequiredService<IQuestionService>();
            InitializeComponent();

            TestSelectComboBoxInitialize();
            SectionSelectComboBoxInitialize();
        }

        QuestionDesignForm(IServiceProvider serviceProvider, int baseUserId, TestViewModel selectedTest, SectionViewModel selectedSection) : this(serviceProvider, baseUserId)
        {
            SelectedTest = selectedTest;
            SelectedSection = selectedSection;
        }


        #region singelton
        public static QuestionDesignForm Crete(IServiceProvider serviceProvider, int baseUserId)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new QuestionDesignForm(serviceProvider, baseUserId);
            }
            return instance;
        }

        public static QuestionDesignForm Crete(IServiceProvider serviceProvider, int baseUserId, TestViewModel selectedTest, SectionViewModel selectedSection)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new QuestionDesignForm(serviceProvider, baseUserId, selectedTest, selectedSection);
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

        List<TestViewModel> GetTestsSeedData(string TestTitle = "") => testService.GetTestsList(baseUserId, TestTitle);

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
    }
}
