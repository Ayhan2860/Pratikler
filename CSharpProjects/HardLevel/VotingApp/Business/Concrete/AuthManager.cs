

using VotingApp.Business.Abstract;
using VotingApp.Models;

namespace VotingApp.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public bool Login(string userName, string password)
        {
            var user = _userService.GetUserByName(userName);
            return (user != null && user.Password == password ) ? true : false;
        }

        public void Register(User user)
        {
            if(_userService.CheckExistsUser(user.UserName))
                Console.WriteLine("Bu kullanıcı daha önce kaydedilmiş.");
            else
            {
                 _userService.Add(user);
                 Console.WriteLine("Kullanıcı kaydı başarıyla yapıldı.");
            }
        }
    }
}