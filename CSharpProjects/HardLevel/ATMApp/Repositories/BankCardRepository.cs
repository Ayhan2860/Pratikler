
using System.Linq.Expressions;
using ATMApp.Entities;

namespace ATMApp.Repositories
{
    public class BankCardRepository:IBankCardRepository
    {
        private List<BankCard> _bankCards;
        public BankCardRepository()
        {
            _bankCards = new List<BankCard>()
            {
                 new BankCard(){Id = 1, AccountNumber=1213, FullName = "Ahmet Yılmaz", Balance=1200, CardNumber=121314,  PinCode = 1234, IsLocked = false},
                 new BankCard(){Id = 2, AccountNumber=1214, FullName = "Hüseyin Tiryaki", Balance=11000, CardNumber=121315, PinCode = 1235, IsLocked = false},
                 new BankCard(){Id = 3, AccountNumber=1215, FullName = "Kadir Kılınç", Balance=7300, CardNumber=121316,  PinCode = 1236, IsLocked = false},
                 new BankCard(){Id = 4, AccountNumber=1216, FullName = "Aras Karaman", Balance=1600, CardNumber=121317, PinCode = 1237, IsLocked = false},
                 new BankCard(){Id = 5, AccountNumber=1217, FullName = "Miraç Mert", Balance=28000, CardNumber=121318, PinCode = 1238, IsLocked = false},
            };
        }

        public BankCard FindCard(Expression<Func<BankCard, bool>> filter)
        {
            var asQueryable = _bankCards.AsQueryable();
            return asQueryable.Where(filter).SingleOrDefault()!;
        }

        public List<BankCard> GetAll(Expression<Func<BankCard, bool>> filter = null!)
        {
            var asQueryable = _bankCards.AsQueryable();
            return filter == null ? asQueryable.ToList()
            : asQueryable.Where(filter).ToList();
        }

        public void Update(BankCard bankCard)
        {
            BankCard card = FindCard(x => x.Id == bankCard.Id);
            card.AccountNumber = bankCard.AccountNumber;
            card.FullName = bankCard.FullName;
            card.Balance = bankCard.Balance;
            card.CardNumber = bankCard.CardNumber;
            card.PinCode = bankCard.PinCode;
            card.IsLocked = bankCard.IsLocked;
            
        }
    }
}