
using VotingApp.Business.Abstract;
using VotingApp.Data.Abstract;
using VotingApp.Data.Concrete;
using VotingApp.Models;

namespace VotingApp.Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;
        private readonly int id;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            id = _userDal.GetAll().Count() + 1;
        }

        public void Add(User user)
        {
            user.Id = id;
            _userDal.Add(user);
        }

        public bool CheckExistsUser(string nameOrEmail)
        {
            var user = GetUserByName(nameOrEmail);
            if(user is null)
                user =  _userDal.GetFind(x => x.Email == nameOrEmail);
            return user != null ? true : false;
        }

        public void Delete(int id)
        {
            var user = GetUserById(id);
            _userDal.Delete(user);
        }

        public User GetUserById(int id)
        {
            return _userDal.GetFind(x => x.Id == id);
        }

        public User GetUserByName(string userName)
        {
            return _userDal.GetFind(x => x.UserName == userName);
        }

        public List<User> GetUsers()
        {
            return _userDal.GetAll();
        }
    }
}