using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class MainPanelFrom : Form
    {
        State state;
        IServiceProvider serviceProvider;

        public MainPanelFrom(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            //mainMenuStrip.Items.Clear();
            this.serviceProvider = serviceProvider;


            SetState(State.NotRegistered);
        }

        private void addQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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
    }
}
