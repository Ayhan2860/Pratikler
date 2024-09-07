using System;

namespace alanHesaplama
{


    public class Rectangular
    {
        public static double AreaCalculation(double longEdge, double shordEdge)
        {
            return longEdge * shordEdge;
        }

         public static double PerimeterCalculation(double longEdge, double shordEdge)
        {
            return 2 * (longEdge + shordEdge);

        }
    }
}