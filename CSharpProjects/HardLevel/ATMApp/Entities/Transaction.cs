
namespace ATMApp.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public long BankAccountNoFrom { get; set; }
        public long BankAccountNoTo { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
    }
}