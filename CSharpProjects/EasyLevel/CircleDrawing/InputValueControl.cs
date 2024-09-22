using System;

namespace CircleDrawing
{
    public class InputValueControl
    {
          public static double InputInValue()
        {
            double radius;
            Console.Write("Dairenin Yarı Çapını Giriniz ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Yarı Çap Pozitif Tam Sayı Olmalıdır.");
            }

            return radius;
        }
    }
}