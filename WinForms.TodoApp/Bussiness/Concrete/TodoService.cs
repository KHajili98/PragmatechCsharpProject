using System;
using System.Collections.Generic;
using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.Entities.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.Business.Concrete
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
            return _todoDal.GetAll();
        }

        public List<TodoEntity> GetAll(Status status)
        {
            return _todoDal.GetAll(status);
        }

        #endregion
    }
}