using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.TodoApp.Entities.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.Bussiness.Abstract
{
    public interface ITodoService
    {
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAll(Status status);
    }
}