


using System.Text;

namespace ATMApp.Utilities
{
    public static class InputFunc
    {
        public static decimal GetValidDecimalInput(string value)
        {
            bool valid = false;
            string rawInput;
            decimal result = 0;

            while (!valid)
            {
                rawInput = GetRawInput(value);
                valid = decimal.TryParse(rawInput, out result);
                if (!valid)
                    WriteMessage("Geçersiz Giriş Yaptınız. Lütfen Yeniden Deneyin.", false);
            }
            return result;
        }

        public static long GetValidLongInput(string value)
        {
            bool valid = false;
            string rawInput;
            long result = 0;
            while (!valid)
            {
                rawInput = GetRawInput(value);
                valid = long.TryParse(rawInput, out result);
                if (!valid)
                    WriteMessage("Geçersiz Giriş Yaptınız. Lütfen Yeniden", false);
            }
            return result;
        }

        public static string GetHiddenConsoleInput()
        {
             StringBuilder builder = new StringBuilder();
             while (true)
             {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) 
                    break;
                if(key.Key == ConsoleKey.Backspace && builder.Length > 0)
                    builder.Remove(builder.Length -1, 1);
                else if(key.Key != ConsoleKey.Backspace) 
                    builder.Append(key.KeyChar);
             }
             return builder.ToString();
        }

        public static void WriteAnimation(int timer = 10, string draw = ".")
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(draw);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
        public static void WriteMessage(string message, bool success)
        {
            Console.ForegroundColor = success ? ConsoleColor.Yellow : ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Devam etmek için bir tuşa basın");
            Console.ReadKey();

        }

        public static string GetRawInput(string value)
        {
            Console.Write($"{value} Giriniz: ");
            return Console.ReadLine()!;
        }
    }
}