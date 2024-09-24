
using System.Linq.Expressions;
using VotingApp.Data.Abstract;
using VotingApp.Models;

namespace VotingApp.Data.Concrete
{
    public class VoteDal : RepositoryBase<Vote>, IVoteDal
    {
        private readonly IUserDal _users;
        private readonly ICategoryDal _categories;
        public VoteDal(IUserDal users, ICategoryDal categories)
        {
            _users = users;
            _categories = categories;
            Datas = new List<Vote>()
            {
                 new Vote()
                 {
                    Id = 2,
                    CategoryId = 1,
                    Category = _categories.GetFind(x => x.Id == 1),
                    UserId = 2,
                    User = _users.GetFind(x => x.Id == 2)
                },
                 new Vote()
                 {
                    Id = 3,
                    CategoryId = 5,
                    Category = _categories.GetFind(x => x.Id == 5),
                    UserId = 4,
                    User = _users.GetFind(x => x.Id == 4)
                },
            };
        
        
        }
    }
}