
using VotingApp.Models;

namespace VotingApp.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(int id);
        List<User> GetUsers();
        User GetUserById(int id);
        User GetUserByName(string userName);
        bool CheckExistsUser(string userName);
    }
}