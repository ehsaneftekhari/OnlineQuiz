using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Models.Tests;
using OnlineQuiz.Business.Models.Users;
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
            StartForm.OnBaseUserRegister += GuestRegister;
            StartForm.OnBaseUserRegister += (_) => StartForm.Close();
            StartForm.OnLogIn += LogIn;
            StartForm.OnLogIn += (_) => StartForm.Close();
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
            AddTestForm addTestForm = new AddTestForm(User.BaseUserId, serviceProvider);
            addTestForm.OnTestAdded += (Test newTest, bool OpenTestExplorer) => MessageBox.Show(newTest.TestId + newTest.Title.Value);
            AddNewChildForm(addTestForm);
        }
    }
}
