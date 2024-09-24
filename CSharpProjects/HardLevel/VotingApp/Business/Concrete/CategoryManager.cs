
using VotingApp.Business.Abstract;
using VotingApp.Data.Abstract;
using VotingApp.Data.Concrete;
using VotingApp.Models;

namespace VotingApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly int id;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            id = _categoryDal.GetAll().Count() +1;
        }

        public void Add(Category category)
        {
            category.Id = id;
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetFind(x => x.Id == id);
        }

        public List<Category> GetCategories()
        {
           return _categoryDal.GetAll();
        }
    }
}