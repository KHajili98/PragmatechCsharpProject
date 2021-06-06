
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
using WinForms.TodoApp.DataAcces.Concrete;
using WinForms.TodoApp.DataAccess.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp
{
    public partial class GetAllForm : Form
    {
        #region fields
        private readonly ITodoService _todoService;
        #endregion
        #region ctor

        public GetAllForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
            lblCountOfList.Text = _todoService.GetAll().Count.ToString();

        }

        #endregion

        #region methods

        private void GetAllForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
            lblCountOfList.Text = _todoService.GetAll().Count.ToString();


        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
            lblCountOfList.Text = _todoService.GetAll().Count.ToString();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (_todoService.GetAll(Status.Pending).Count!=0)
            {
                FillData(Status.Pending);    
            }
            else
            {
                AddTodo();
            }

        }
        
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (_todoService.GetAll(Status.Completed).Count != 0)
            {
                FillData(Status.Completed);

            }
            else
            {
                AddTodo();
            }
        }


        private void btnCanceled_Click(object sender, EventArgs e)
        {
            if (_todoService.GetAll(Status.Canceled).Count != 0)
            {
                FillData(Status.Canceled);
            }
            else
            {
                AddTodo();
            }


        }

        private void btnInCompleted_Click(object sender, EventArgs e)
        {
            if (_todoService.GetAll(Status.InCompleted).Count != 0)
            {
                FillData(Status.InCompleted);
            }
            else
            {
                AddTodo();
            }
        }

        private void btnSuspended_Click(object sender, EventArgs e)
        {

            if (_todoService.GetAll(Status.Suspended).Count != 0)
            {
                FillData(Status.Suspended);
            }
            else
            {
                AddTodo();
            }
        }


        private void FillData(Status status)
        {
            dataGridView.DataSource = _todoService.GetAll(status);
            dataGridView.Columns["Id"].Visible = false;
            lblCountOfList.Text = _todoService.GetAll(status).Count.ToString();
        }

        private void AddTodo()
        {
            MessageBox.Show(GlobalConstants.EmptyList, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

            DialogResult dialogResult = MessageBox.Show(
               GlobalConstants.AddOperation,
               GlobalConstants.CaptionQuestion,
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var addtodoForm = new NewTodoForm();
                addtodoForm.MdiParent = Application.OpenForms[GlobalConstants.TodoForm];
                addtodoForm.StartPosition = FormStartPosition.CenterScreen;
                addtodoForm.Show();
            }
        }


        #endregion


    }
}