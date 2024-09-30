using System.ComponentModel;

namespace ATMApp.Utilities
{
    public enum SecureMenu
    {
        [Description("Bakiye Sorgula")]
        CheckBalance = 1,
        [Description("Para Yatır")]
        PlaceDeposit,
        [Description("Para Çek")]
        Withdrawal,
        [Description("Para Transfer")]
        TransferMoney,

       [Description("İşlem Görüntüle")]
        Transaction,

        [Description("Çıkış Yap")]
        Logout

    }

}