
using ATMApp.Entities;
using ATMApp.Repositories;
using ATMApp.Services;
using ATMApp.Utilities;

namespace ATMApp
{
    public class KrmnBank
    {
        private static int tries;
        private const int maxTries = 3;
        private static decimal transaction_amount;
        private static decimal minKeptAmount = 20;
        private readonly IBankCardRepository _bankCardRepository;
        private readonly ILoggerService _loggerService;
        private static BankCard? bankCard;

        public KrmnBank(IBankCardRepository bankCardRepository, ILoggerService loggerService)
        {
            _bankCardRepository = bankCardRepository;
            _loggerService = loggerService;
        }

        public void Execute(string[] args)
        {
            Screen.WelcomeScreen();
            while (true)
            {

                switch (InputFunc.GetValidLongInput("Seçiminizi"))
                {

                    case 1:
                        CheckCardNumberPassword();
                        while (true)
                        {
                            Screen.MenuScreen(bankCard.FullName);
                            switch (InputFunc.GetValidLongInput("Seçiminizi"))
                            {
                                case (int)SecureMenu.CheckBalance:
                                    CheckBalance(bankCard);
                                    break;
                                case (int)SecureMenu.PlaceDeposit:
                                    PlaceDeposit(bankCard);
                                    break;
                                case (int)SecureMenu.Withdrawal:
                                    Withdrawal(bankCard);
                                    break;
                                case (int)SecureMenu.TransferMoney:
                                    TransferMoney(bankCard);
                                    break;
                                case (int)SecureMenu.Logout:
                                    InputFunc.WriteMessage("Başarılı bir şekilde çıkış yaptınız. Lütfen Kartınızı alın", true);
                                    Execute(args);
                                    break;
                                default:
                                    InputFunc.WriteMessage("Yanlış bir seçim yaptınız", false);
                                    break;
                            }
                        }
                    case 2:
                        Console.Write("\nBankamızı Tercih Ettiğiniz İçin Teşekkür Ederiz. Program Kapatılıyor.");
                        InputFunc.WriteAnimation(15, "〉");
                        Environment.Exit(1);
                        break;
                    default:
                        InputFunc.WriteMessage("Yanlış bir seçim yaptınız", false);
                        break;

                }
            }


        }

        private void TransferMoney(BankCard bankCard)
        {
            Console.Write("Lütfen alıcı kart bilgilerini giriniz");
            long accountOrCardNumber = InputFunc.GetValidLongInput("Alıcı Hesap Numarsını veya Kart Numarasını");
            string fullName = InputFunc.GetRawInput("Alıcını İsim Bilgisini");
            BankCard transferAccount = _bankCardRepository.FindCard((x => (x.AccountNumber == accountOrCardNumber && x.FullName == fullName) 
            || (x.CardNumber == accountOrCardNumber && x.FullName == fullName)));
            if (transferAccount != null)
            {

                Console.Write($"Transfer Hesabı => {transferAccount.FullName}. \n");
                Console.Write("Lütfen transfer etmek istediğiniz tutarı girin. \n\n");
                transaction_amount = InputFunc.GetValidDecimalInput("Tutarı");
                if (transaction_amount <= 0)
                    InputFunc.WriteMessage("Tutarın sıfırdan büyük olması gerekir. Lütfen tekrar deneyin.", false);
                else if (transaction_amount > bankCard.Balance)
                    InputFunc.WriteMessage($"Yetersiz. Hesabınızda {bankCard.Balance} bulunmaktatır", false);
                else
                {
                    Console.WriteLine("Lütfen bekleyin tranfer işlemi gerçekleşiyour");
                    InputFunc.WriteAnimation(15, "〉");
                    transferAccount.Balance += transaction_amount;
                    bankCard.Balance -= transaction_amount;
                    _bankCardRepository.Update(bankCard);
                    _bankCardRepository.Update(transferAccount);
                    _loggerService.Write($"{bankCard.CardNumber} numaralı karttan {transferAccount.CardNumber} numaralı karta {transaction_amount} tutarında para transferi");
                    InputFunc.WriteMessage($"Para çekme işleminiz başarılı bir şekilde gerçekleşti.", true);
                }
            }
            else
            {
                InputFunc.WriteMessage("Para transferi yapılacak hesap bulunamadı. Bilgileri kontrol ederek tekrar deneyin.", false);
                Console.Clear();
            }

        }

        private void Withdrawal(BankCard bankCard)
        {
            Console.Write("Lütfen çekmek istediğiniz tutarı girin. \n\n");
            transaction_amount = InputFunc.GetValidDecimalInput("Tutarı");
            if (transaction_amount <= 0)
                InputFunc.WriteMessage("Tutarın sıfırdan büyük olması gerekir. Lütfen tekrar deneyin.", false);
            else if (transaction_amount > bankCard.Balance)
                InputFunc.WriteMessage($"Yetersiz. Hesabınızda {bankCard.Balance} bulunmaktatır", false);
            else if ((bankCard.Balance - transaction_amount) < minKeptAmount)
                InputFunc.WriteMessage($"Para çekme işleminiz iptal edildi. Çebileceğiniz minimum tutar {minKeptAmount}", false);
            else
            {
                bankCard.Balance = bankCard.Balance - transaction_amount;
                _bankCardRepository.Update(bankCard);
                _loggerService.Write($"Hesapdan {transaction_amount} tutarında para çekme");
                InputFunc.WriteMessage($"Para çekme işleminiz başarılı bir şekilde gerçekleşti.", true);
            }
        }

        private void PlaceDeposit(BankCard bankCard)
        {
            Console.WriteLine("\nBanknotları Makineye Yerleştirin\n\n");
            transaction_amount = InputFunc.GetValidDecimalInput("Tutarı");

            Console.Write("\nLütfen bekleyin paralar kontrol ediliyor.");
            InputFunc.WriteAnimation(15, "〉");

            if (transaction_amount <= 0)
                InputFunc.WriteMessage("Tutarın sıfıdan büyük olması gerekir. Lütfen tekrar deneyin!", false);
            // else if(transaction_amount % 10 != 0)
            //     InputFunc.WriteMessage("", false);
            else
            {
                bankCard.Balance += transaction_amount;
                _bankCardRepository.Update(bankCard);
                _loggerService.Write($"Hesaba {transaction_amount} tutarında para ekleme");
                InputFunc.WriteMessage("İşleminiz başarıyla tamamlandı", true);
            }
        }

        private void CheckBalance(BankCard bankCard)
        {
            _loggerService.Write("Bakiye sorgulaması");
            InputFunc.WriteMessage($"Bakiye Tutarınız: {bankCard.Balance}", true);
        }

        private void CheckCardNumberPassword()
        {
            bool pass = false;
            while (!pass)
            {


                Console.WriteLine("\nNot: Banka kartı numaranızı doğru girdiğinizden emin olunuz!");
                long cardNumber = InputFunc.GetValidLongInput("ATM Kart Numaranızı");
                Console.Write("Lütfen Kart Şifrenizi Girin: ");
                int pinCode = Convert.ToInt32(InputFunc.GetHiddenConsoleInput());

                Console.Write("\nLütfen bekleyin bilgileriniz kontrol ediliyor!\n");
                InputFunc.WriteAnimation(15, "〉");

                bankCard = _bankCardRepository.FindCard(x => x.CardNumber == cardNumber);
                if (bankCard is not null)
                {
                    if (bankCard.PinCode.Equals(pinCode))
                    {
                        if (bankCard.IsLocked)
                        {    
                            LockAccount();
                        }
                        else
                            pass = true;
                    }
                    else
                    {
                        pass = false;
                        tries++;
                        if (tries >= maxTries)
                        {
                            bankCard.IsLocked = true;
                            LockAccount();
                        }
                    }
                }
                else
                    InputFunc.WriteMessage("Kart numaranızı veya Şifrinizi Geçersiz", false);
                    _loggerService.Write("Belirsiz kişi ve şifre ile giriş denemesi");
                Console.Clear();

            }
        }

        private void LockAccount()
        {
            Console.Clear();
            InputFunc.WriteMessage("Hesabınız bloke olmuştur", true);
            Console.WriteLine("Hesabınızın blokesini kaldırmak için lütfen en yakın şubemize başvuruda bulunun.");
            Console.WriteLine("Bankamıza kullandığınız için teşekkür eder sağlıklı günler dileriz ..");
            if(tries >0 )
                 _loggerService.Write("Blokelenmiş hesaba giriş denemesi");
             else
                 _loggerService.Write("Hesab an itibariyle 3 yanlış şifre denemesiyle blokelenmiştir ");
            
            Console.ReadKey();
            Environment.Exit(1);
        }



    }
}