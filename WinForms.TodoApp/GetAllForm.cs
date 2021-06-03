
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
        }

        #endregion

        #region methods
        private void GetAllForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Pending);
            dataGridView.Columns["Id"].Visible = false;

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Completed);
            dataGridView.Columns["Id"].Visible = false;

        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Canceled);
            dataGridView.Columns["Id"].Visible = false;

        }

        #endregion


    }
}