using Microsoft.Extensions.DependencyInjection;
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
            //mainMenuStrip.Items.Clear();
            this.serviceProvider = serviceProvider;


            SetState(State.NotRegistered);

            OpenLogin();
        }

        User User { get; set; }

        BaseUser BaseUser { get; set; }

        private void SetState(State nexState)
        {
            state = nexState;

            switch (state)
            {
                case State.NotRegistered:
                    break;

                case State.GuestRegistered:
                    break;

                case State.LoggedIn:
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

        private void SetUser(User newUser) => User = newUser;

        private void SetBaseUser(BaseUser baseUser) => BaseUser = baseUser;

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
            StartForm.OnBaseUserRegister += SetBaseUser;
            StartForm.OnBaseUserRegister += (_) => StartForm.Close();
            StartForm.OnLogIn += SetUser;
            StartForm.OnLogIn += (_) => StartForm.Close();
            AddNewChildForm(StartForm);
        }
    }
}
