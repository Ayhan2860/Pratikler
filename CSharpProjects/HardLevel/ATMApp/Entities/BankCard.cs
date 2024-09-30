
namespace ATMApp.Entities
{
    public class BankCard
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public long AccountNumber { get; set; }
    public long CardNumber { get; set; }
    public int PinCode { get; set; }
    public decimal Balance { get; set; }

    public bool IsLocked { get; set; }
}
}