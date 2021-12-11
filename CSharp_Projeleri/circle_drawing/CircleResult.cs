using System;
namespace circle_drawing
{
    public class CircleResult
    {
          public static double CircleLoop(double thickness, char symbol)
        {
            double radius;
            do
            {
                radius = InputValueControl.InputInValue();
            }
            while (radius <= 0);
            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            return radius;
        }
    }
}