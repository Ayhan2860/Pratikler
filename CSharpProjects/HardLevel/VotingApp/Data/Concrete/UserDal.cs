
using VotingApp.Data.Abstract;
using VotingApp.Models;

namespace VotingApp.Data.Concrete
{
    public class UserDal:RepositoryBase<User>, IUserDal
    {
        public UserDal()
        {
            Datas = new List<User>()
            {
                new User(){Id = 1, Email= "ahmet28@gmail.com", UserName="ahmet28", Password="123"},
                new User(){Id = 2, Email= "mustafa64@gmail.com", UserName="mustafa64", Password="123"},
                new User(){Id = 3, Email= "kadem51@gmail.com", UserName="kadem51", Password="123"},
                new User(){Id = 4, Email= "elvan2828@gmail.com", UserName="elvan2828", Password="123"},
                new User(){Id = 5, Email= "emir61@gmail.com", UserName="emir61", Password="123"},
            };
        }
    }
}