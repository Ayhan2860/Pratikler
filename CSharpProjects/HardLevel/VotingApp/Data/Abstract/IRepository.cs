
using System.Linq.Expressions;

namespace VotingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAllExpression(Expression<Func<T, bool>> expression = null!);
        T GetFind(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
    }
}