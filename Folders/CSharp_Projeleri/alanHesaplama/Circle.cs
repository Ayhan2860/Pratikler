using System;

namespace alanHesaplama
{
   public class Circle
   {
        public const double pi = 3.14;
        

        /// <summary>
        /// Çemberin Çevresini hesaplar
        /// </summary>
        /// <param name="r">Yari Çap</param>
        /// <returns> Çemberin Çevre Değeri </returns>
        public static double PerimeterCalculation(double r)
        {
            return 2 * pi * r;

        }

        /// <summary>
        /// Dairenin Alanını hesaplar
        /// </summary>
        /// <param name="r">Yari Çap</param>
        /// <returns> Alan Değeri </returns>
        public static double AreaCalculation(double r)
        {
           return pi * r * r;
        }
   }
}