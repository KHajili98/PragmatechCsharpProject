using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.Bussiness.Abstract
{
    public interface IUserService
    {
        UserEntity GetUser(string username, string password);
    }
}