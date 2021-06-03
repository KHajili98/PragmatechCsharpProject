
using System;
using System.Drawing;
using System.Windows.Forms;
using WinForms.TodoApp.Business.Concrete;
using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.Constants;
using WinForms.TodoApp.DataAcces.Concrete;
using WinForms.TodoApp.DataAccess.Concrete;
using WinForms.TodoApp.Entities.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp
{
    public partial class NewTodoForm : Form
    {
        #region fields
        private readonly ITodoService _todoService;
        #endregion

        #region ctor
        public NewTodoForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }
        #endregion

        #region methods



        private void NewTodoForm_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(Status));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _todoService.Add(new TodoEntity
            {
                Id = Guid.NewGuid(),
                Title = txtBoxTitle.Text,
                ShortDescription = txtBoxShortDesc.Text,
                Description = txtBoxDesc.Text,
                ImportanceLevel = Convert.ToInt32(txtImportanceLevel.Text),
                Status = (Status)comboBoxStatus.SelectedItem
            });

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.AddSuccess, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult dialogResult = MessageBox.Show(
                    GlobalConstants.AddOperationAgain,
                    GlobalConstants.CaptionQuestion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    ClearTextBox();
                }
                else
                {
                    Form getAllForm = Application.OpenForms["GetAllForm"];

                    if (getAllForm == null)
                    {
                        getAllForm = new GetAllForm();
                        getAllForm.MdiParent = Application.OpenForms["TodoAppForm"];
                        getAllForm.StartPosition = FormStartPosition.CenterScreen;
                        getAllForm.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox listGroupBox = (GroupBox)getAllForm.Controls["grpBoxList"];
                        DataGridView dataGridView = (DataGridView)listGroupBox.Controls["dataGridView"];
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = _todoService.GetAll();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show(GlobalConstants.AddError, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        #region helper

        private void ClearTextBox()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
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
        #endregion


        #endregion

    }
}