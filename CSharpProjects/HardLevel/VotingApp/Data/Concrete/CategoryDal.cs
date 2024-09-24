
using VotingApp.Data.Abstract;
using VotingApp.Models;

namespace VotingApp.Data.Concrete
{
    public class CategoryDal : RepositoryBase<Category>, ICategoryDal
    {
        public CategoryDal()
        {
            Datas = new List<Category>()
            {
                 new Category(){ Id = 1, Name = "Science and Technology"},
                 new Category(){ Id = 2, Name = "Sports"},
                 new Category(){ Id = 3, Name = "Movies"},
                 new Category(){ Id = 4, Name = "History and Geography"},
                 new Category(){ Id = 5, Name = "Animals"},
            };
        }
    }
}