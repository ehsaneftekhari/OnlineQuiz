using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Presentation.WinForms.Forms;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class MainMDIParent : Form
    {
        private int childFormNumber = 0;

        State state;
        IServiceProvider serviceProvider;
        //public MainMDIParent()
        //{
        //    InitializeComponent();
        //}

        public MainMDIParent(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            this.serviceProvider = serviceProvider;

            SetState(State.NotRegistered);

            OpenLogin();
        }

        User User { get; set; }

        BaseUser Guest { get; set; }

        private void SetState(State nexState)
        {
            state = nexState;
            menuStrip.Items.Clear();
            menuStrip.Items.Add(windowsMenu);
            switch (state)
            {
                case State.NotRegistered:
                    menuStrip.Items.Add(Login_Register_ToolStripMenuItem);
                    break;

                case State.GuestRegistered:
                    break;

                case State.LoggedIn:
                    menuStrip.Items.Add(testToolStripMenuItem);
                    menuStrip.Items.Add(logoutToolStripMenuItem);
                    break;

                case State.Exit:
                    Close();
                    break;
            }
        }

        private enum State
        {
            NotRegistered,
            GuestRegistered,
            LoggedIn,
            Exit
        }

        private void LogIn(User newUser)
        {
            User = newUser;
            SetState(State.LoggedIn);
        }

        private void GuestRegister(BaseUser guest)
        {
            Guest = guest;
            SetState(State.GuestRegistered);
        }

        private void LogOut()
        {
            User = null;
            Guest = null;
            SetState(State.NotRegistered);
        }

        /////


        private void AddNewChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.Text = "Window " + childFormNumber++;

            AddNewChildForm(childForm);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void OpenLogin()
        {
            LoginRegister StartForm = serviceProvider.GetRequiredService<LoginRegister>();
            StartForm.OnBaseUserRegister -= GuestRegister;
            StartForm.OnBaseUserRegister += GuestRegister;
            StartForm.OnLogIn -= LogIn;
            StartForm.OnLogIn += LogIn;
            AddNewChildForm(StartForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddTestForm();
        }

        private void OpenAddTestForm()
        {
            AddTestForm addTestForm = AddTestForm.Create(User.BaseUserId, serviceProvider);
            addTestForm.TestExplorerOpener -= OpenTestExplorerForm;
            addTestForm.TestExplorerOpener += OpenTestExplorerForm;
            AddNewChildForm(addTestForm);
        }

        private void testListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTestBrowseForm(nameof(MainMDIParent));
        }

        private void OpenTestBrowseForm(string ownerName)
        {
            OpenTestBrowseForm(false, ownerName);
        }

        private void OpenTestBrowseForm(bool closeAfterSelect, string ownerName)
        {
            TestBrowseForm TestList = TestBrowseForm.Create(serviceProvider, User.BaseUserId, ownerName);
            TestList.OnTestSelect -= OpenTestExplorerForm;
            TestList.OnTestSelect += OpenTestExplorerForm;

            TestList.CloseAfterSelect = closeAfterSelect;

            AddNewChildForm(TestList);
        }

        private void OpenTestExplorerForm(int testId = 0)
        {
            TestExplorerForm testExplorerForm = TestExplorerForm.Crete(serviceProvider);
            testExplorerForm.ChildFormAdder -= AddNewChildForm;
            testExplorerForm.ChildFormAdder += AddNewChildForm;
            testExplorerForm.TestBrowseFormOpener -= OpenTestBrowseForm;
            testExplorerForm.TestBrowseFormOpener += OpenTestBrowseForm;
            testExplorerForm.OpenTest(testId);


            AddNewChildForm(testExplorerForm);
        }

        private void testExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTestExplorerForm();
        }
    }
}
