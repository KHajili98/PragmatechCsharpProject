using System.Collections.Generic;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.Entities.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.DataAcces.Concrete
{
    public class InMemoryTodoDal : ITodoDal
    {
        #region fields

        private static readonly List<TodoEntity> _todoEntities;
        #endregion


        #region ctor

        static InMemoryTodoDal()
        {
            _todoEntities = new List<TodoEntity>();
        }

        #endregion
        #region Implementation of ITodoDal

        public int Count()
        {
            return _todoEntities.Count;
        }

        public int Add(TodoEntity data)
        {
            _todoEntities.Add(data);

            return 1;
        }

        List<TodoEntity> ITodoDal.GetAll()
        {
            throw new System.NotImplementedException();
        }

        List<TodoEntity> ITodoDal.GetAll(Status status)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}