using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.DataAcces.Concrete
{
    public class InMemoryUserDal : IUserDal
    {

        #region fields

        private static readonly List<UserEntity> _userEntities;
        #endregion
        #region ctor


        static InMemoryUserDal()
        {
            _userEntities = new List<UserEntity>
            {
                new UserEntity {Id = Guid.NewGuid(), Username = "user1", Password = "1234"}
            };
        }
        #endregion
        #region Implementation of IUserDal

        public List<UserEntity> GetAll()
        {
            return _userEntities;
        }

        public void Add(UserEntity data)
        {
            _userEntities.Add(data);
        }

        #endregion
    }
}