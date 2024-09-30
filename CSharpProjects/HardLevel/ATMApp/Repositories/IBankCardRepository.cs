

using System.Linq.Expressions;
using ATMApp.Entities;

namespace ATMApp.Repositories
{
    public interface IBankCardRepository
    {
        BankCard FindCard(Expression<Func<BankCard, bool>> filter);
        List<BankCard> GetAll(Expression<Func<BankCard, bool>> filter = null!);
        void Update(BankCard bankCard);
    }
}