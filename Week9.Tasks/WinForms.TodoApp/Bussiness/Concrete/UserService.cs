using WinForms.TodoApp.Bussiness.Abstract;
using WinForms.TodoApp.DataAcces.Abstract;
using WinForms.TodoApp.DataAccess.Concrete;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.Business.Concrete
{
    public class UserService : IUserService
    {
        #region fields
        private readonly IUserDal _userDal; // abstract
        #endregion

        #region ctor

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        #endregion
        #region Implementation of IUserService

        public UserEntity GetUser(string username, string password)
        {
            return _userDal.GetUser(username, password);
        }

        #endregion
    }
}