



using VotingApp.Models;

namespace VotingApp.Business.Abstract
{
    public interface IAuthService
    {
        void Register(User user);
        bool Login(string userName, string password);
    }
}