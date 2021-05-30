using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.DataAcces.Concrete;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.Bussiness.Concrete
{
    public class TodoService : ITodoService
    {
        #region fields

        private readonly ITodoDal _todoDal;
        #endregion

        #region ctor

        public TodoService(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        #endregion
        #region Implementation of ITodoService

        public int Count()
        {
            return _todoDal.Count();
        }

        public int Add(TodoEntity data)
        {
            return _todoDal.Add(data);
        }

        public List<TodoEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}