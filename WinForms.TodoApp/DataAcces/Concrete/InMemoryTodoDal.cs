using System;
using System.Collections.Generic;
using System.Linq;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.Entities.Concrete;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.DataAccess.Concrete
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
            int result;
            try
            {
                _todoEntities.Add(data);
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
                throw;
            }


            return result;
        }

        public List<TodoEntity> GetAll()
        {
            return _todoEntities;
        }

        public List<TodoEntity> GetAll(Status status)
        {
            return _todoEntities.Where(i => i.Status == status).ToList();
        }

        #endregion
    }
}