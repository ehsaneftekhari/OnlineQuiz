using OnlineQuiz.Business.Logic.Services;
using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Presentation.WinForms.UserControls.QuestionUserControls
{
    public partial class AddQuestionUserControl : UserControl
    {
        readonly IServiceProvider serviceProvider;
        readonly QuestionService questionService;

        public AddQuestionUserControl(IServiceProvider serviceProvider, SectionViewModel section)
        {
            this.serviceProvider = serviceProvider;

            this.section = section;

            InitializeComponent();
        }

        SectionViewModel section { get; set; }

        #region Actions
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
