
using System.Linq.Expressions;
using VotingApp.Data.Abstract;

namespace VotingApp.Data.Concrete
{
    public  class RepositoryBase<TEntity> : IRepository<TEntity>
    {
        protected  List<TEntity>? Datas { get; set; }
        public void Add(TEntity entity)
        {
            Datas?.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            Datas?.Remove(entity);
        }

        public List<TEntity> GetAll()
        {
            return Datas!;
        }

        public virtual List<TEntity> GetAllExpression(Expression<Func<TEntity, bool>> expression = null!)
        {
            var asQueryData = Datas!.AsQueryable();
            return expression == null ? asQueryData.ToList() : asQueryData.Where(expression).ToList();
        }

        public TEntity GetFind(Expression<Func<TEntity, bool>> filter)
        {
            var asQueryData = Datas!.AsQueryable<TEntity>();
            return asQueryData.Where(filter).SingleOrDefault();
        }

    
    }
}