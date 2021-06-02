using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.DataAcces.Abstract
{
    public interface IUserDal
    {
        List<UserEntity> GetAll();

        void Add(UserEntity data);
    }
}