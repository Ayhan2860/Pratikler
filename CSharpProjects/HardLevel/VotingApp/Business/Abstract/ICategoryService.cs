
using VotingApp.Models;

namespace VotingApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void Add(Category category);
        void Delete(int id);
        Category GetById(int id);
    }
}