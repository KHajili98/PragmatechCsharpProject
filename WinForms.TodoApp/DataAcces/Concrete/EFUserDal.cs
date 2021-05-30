using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.DataAcces.Concrete
{
    public class EFUserDal : IUserDal
    {
        #region Implementation of IUserDal

        public List<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(UserEntity data)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}