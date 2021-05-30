using System;
using System.Windows.Forms;
namespace WinForms.TodoApp
{
    public partial class TodoAppForm : Form
    {
        #region fields

        #endregion
        #region ctor

        public TodoAppForm()
        {
            InitializeComponent();
        }

        #endregion

        #region methods
        private void TodoAppForm_Load(object sender, EventArgs e)
        {
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

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {

        }



        #endregion

        
    }
}