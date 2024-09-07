using System;

namespace alanHesaplama
{
    public static class TriangleCalculation
    {
          public static double AreaCalculation(double b, double h)
        {
            return (b * h)/2;
        }

 

         /// <summary>
        /// Üçgenin Çevresini Pisagor teoremi ile hesaplar
        /// </summary>
        /// <param name="a">Kenar</param>
        /// <param name="b">Kenar</param>
        /// <param name="c">Hipotenüs </param>
        /// <returns> Üçgenin Çevre Değeri </returns>
         public static double PerimeterCalculation(double a, double b, double c)
        {
             double x = SquareOfNumber(a), y =SquareOfNumber(b), t= SquareOfNumber(c);
            

            if(x != 0 && y!= 0 && t ==0)
            {
                var r = x + y;
                return Math.Sqrt(r);
            }
            else if(x != 0 && t!= 0 && y ==0)
            {
                var r = SquareOfNumber2(x,t);
                return Math.Sqrt(r);
            }
             else if(y != 0 && t!= 0 && x ==0)
            {
                var r = SquareOfNumber2(y,t);
                return Math.Sqrt(r);
            }
            else
            {
                return a+ b+c;
            }

        }


        /// <summary>
        /// Bir Sayının Karesini Hesaplar
        /// </summary>
        /// <param name="n">Kenar</param>
        /// <returns> Sayının Kare Değeri </returns>
        private static double SquareOfNumber(double n)
        {
            return n *n;
        }
         

     
            
         private static double SquareOfNumber2(double n, double x)
        {
               if (n > x)
               {
                   return n -x;
               }
               else
               {
                 return  x -n;
               }
        }


    }
}