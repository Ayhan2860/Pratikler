using System;

namespace alanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state =true;

          while (state)
            {
                int vote = Menu.MainMenu();     
                switch (vote)
                {
                    case 1:
                        ScreenWrite.CircleAreaOrPerimeterCalculation();
                        break;
                    case 2:
                        ScreenWrite.TriangleAreaOrPerimeterCalculation();
                        break;
                    case 3:
                        ScreenWrite.SquareAreaOrPerimeterCalculation();
                        break;
                    case 4:
                        ScreenWrite.RectangleAreaOrPerimeterCalculation();
                        break;
                    case 5:
                        state =false;
                        break;
                    default:
                      Console.WriteLine("Hatalı İşlem Yaptınız");
                     break;
                }

                Console.ReadLine();
        
            }
        }

       



      
      
    }
}
