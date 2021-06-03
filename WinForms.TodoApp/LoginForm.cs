using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.TodoApp.Business.Concrete;
using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.Constants;
using WinForms.TodoApp.DataAccess.Concrete;

namespace WinForms.TodoApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.DarkGray;
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsername.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                IUserService userService = new UserService(new InMemoryUserDal());

                var user = userService.GetUser(txtBoxUsername.Text, txtBoxPassword.Text);

                if (user != null)
                {
                    // left sidebar buttons enable=true
                    Form todoListForm = Application.OpenForms["TodoAppForm"];
                    Panel leftSideBarPanel = (Panel)todoListForm.Controls["panel1"];
                    GroupBox grpBox = (GroupBox)leftSideBarPanel.Controls["grpBoxOperations"];

                    foreach (Control control in grpBox.Controls)
                    {
                        if (control is Button)
                        {
                            control.Enabled = true;
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalConstants.InvalidAttempt, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}