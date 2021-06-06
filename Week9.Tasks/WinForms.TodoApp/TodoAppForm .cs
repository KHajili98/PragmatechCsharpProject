using System;
using System.Windows.Forms;
using WinForms.TodoApp.Business.Concrete;
using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.Constants;
using WinForms.TodoApp.DataAccess.Concrete;

namespace WinForms.TodoApp
{
    public partial class TodoAppForm : Form
    {
        #region fields
        private Form _form;
        private readonly ITodoService _todoService;
        #endregion
        #region ctor

        public TodoAppForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }

        #endregion

        #region methods
        private void TodoAppForm_Load(object sender, EventArgs e)
        {
            // timer

            GetDateTime();
            // leftSideBar enable and disable
            GrpBoxOperationsEnableDisable(false);
            // login
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Left = loginForm.Parent.Width - ((loginForm.Parent.Width - loginForm.Width) / 2);
            loginForm.Top = loginForm.Parent.Height - ((loginForm.Parent.Height - loginForm.Height) / 2);
            loginForm.Show();

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewTodoForm"] != null)
            {
                _form = Application.OpenForms["NewTodoForm"];
                _form.Focus();
            }
            else
            {
                _form = new NewTodoForm();
                _form.MdiParent = Application.OpenForms["TodoAppForm"];
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Show();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["getAllForm"] != null)
            {
                _form = Application.OpenForms["getAllForm"];
                _form.Focus();
            }
            else
            {
                if (_todoService.Count() > 0)
                {
                    GetAllForm form = new GetAllForm();
                    form.MdiParent = Application.OpenForms["TodoAppForm"];
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                }
                else
                {
                    MessageBox.Show(GlobalConstants.EmptyList, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region helper methods

        private void GetDateTime()
        {
            timerDateTime.Interval = 15000;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("g");
        }

        private void GrpBoxOperationsEnableDisable(bool control)
        {
            foreach (var item in grpBoxOperations.Controls)
            {
                if (item is Button operationButton)
                {
                    operationButton.Enabled = control;
                }
            }
        }
        #endregion
        #endregion


    }
}