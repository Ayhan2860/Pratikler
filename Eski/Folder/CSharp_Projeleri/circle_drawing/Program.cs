using System;

namespace circle_drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double thickness = 0.5;
             ColorControl.ColorResult();
            char symbol = '*';
            radius = CircleResult.CircleLoop(thickness, symbol);
            Console.ReadKey();
        }

       


    }
}
