


namespace BarcodeApp.Utilities
{
    public static class Input
    {
        public static long GetDrawLong(string message)
        {
            bool valid = false;
            string rawInput;
            long result = 0;
            while (!valid)
            {
                rawInput = GetRawString(message);
                valid = long.TryParse(rawInput, out result);
                if (!valid)
                    WriteMessage("Geçersiz Giriş Yaptınız. Lütfen Yeniden Deneyin.", false);
            }
            return result;
        }

        public static void WriteMessage(string message, bool success)
        {
            Console.ForegroundColor = success ? ConsoleColor.Yellow : ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Devam etmek için bir tuşa basın");
            Console.ReadKey();
         
        }

        public static string GetRawString(string message)
        {
          
            Console.Write($"{message} Girin: ");
            return Console.ReadLine()!;
        }

        public static void Animation(int timer = 15)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write("⍄");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    
    }
}