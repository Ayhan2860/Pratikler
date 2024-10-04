

namespace BarcodeApp.Utilities
{
    public static class Screen
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
                        Console.WriteLine("{0,-11}{1}{2,11}", "*", "Hoşgeldiniz", "*");
                        break;
                    case 8:
                        Console.WriteLine("{0,-4}{1}{2,15}", "*", "1. Barkod Üret", "*");
                        break;
                    case 9:
                        Console.WriteLine("{0,-4}{1}{2,16}", "*", "2. Barkod Oku", "*");
                        break;
                    case 10:
                        Console.WriteLine("{0,-4}{1}{2,17}", "*", "3. Çıkış Yap", "*");
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