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
        UserEntity GetUser(string username, string password);
        List<UserEntity> GetAll();

        void Add(UserEntity data);
    }
}