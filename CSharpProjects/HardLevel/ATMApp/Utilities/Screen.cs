

namespace ATMApp.Utilities
{
    public class Screen
    {
        public static void WelcomeScreen()
        {
            string topBottomDraw = " ".PadRight(32, '-');
            Console.Clear();
            Console.WriteLine(topBottomDraw);
            for (int i = 0; i < 16; i++)
            {
                switch (i)
                {
                    case 3:
                        Console.WriteLine("{0,-4}{1}{2,4}", "*", "KRMN Banka Hoşgeldiniz 💵", "*");
                        break;
                    case 8:
                        Console.WriteLine("{0,-4}{1}{2,7}", "*", "1. ATM Kartınızı Takın", "*");
                        break;
                    case 10:
                        Console.WriteLine("{0,-4}{1}{2,17}", "*", "2. Çıkış Yap", "*");
                        break;
                    default:
                        Console.WriteLine($"{'*'}{'*', 32}");
                        break;
                }
            }
            Console.WriteLine(topBottomDraw);
        }
        public static void MenuScreen(string userName="")
        {
            string topBottomDraw = " ".PadRight(32, '-');
            Console.Clear();
            Console.WriteLine($"\n  Merhaba; {userName}");
            Console.WriteLine(topBottomDraw);
            for (int i = 0; i < 16; i++)
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine("{0,-4}{1}{2,8}", "*", "KRMN ATM Güvenli Menu", "*");
                        break;
                    case 6:
                        Console.WriteLine("{0,-4}{1}{2,12}", "*", "1. Bakiye Sorgula", "*");
                        break;
                    case 7:
                        Console.WriteLine("{0,-4}{1}{2,16}", "*", "2. Para Yatır", "*");
                        break;
                    case 8:
                        Console.WriteLine("{0,-4}{1}{2,18}", "*", "3. Para Çek", "*");
                        break;
                    case 9:
                        Console.WriteLine("{0,-4}{1}{2,13}", "*", "4. Para Transfer", "*");
                        break;
                    case 10:
                        Console.WriteLine("{0,-4}{1}{2,12}", "*", "5. İşlem  Geçmişi", "*");
                        break;
                    case 14:
                        Console.WriteLine("{0,-4}{1}{2,17}", "*", "6. Çıkış Yap", "*");
                        break;
                    default:
                        Console.WriteLine($"{'*'}{'*', 32}");
                        break;
                }
            }
            Console.WriteLine(topBottomDraw);
        }



    }
}