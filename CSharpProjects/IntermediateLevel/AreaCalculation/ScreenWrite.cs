using System;

namespace AreaCalculation
{
    public class ScreenWrite
    {
        public  static void CircleAreaOrPerimeterCalculation()
        {
            int n = Menu.SubMenu("Dairenin");
            Console.Write("Hesaplancak Olan Değeri Giriniz : ");
            double r = Convert.ToDouble(Console.ReadLine());

            switch (n)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Dairenin Verilen Değerlere Göre Çevre Hesaplaması : \n");
                    Console.WriteLine($"2 * {Circle.pi} * {r} = {Circle.PerimeterCalculation(r)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Dairenin Verilen Değerlere Göre Alan Hesaplaması : \n");
                    Console.WriteLine($"{Circle.pi} * {r} * {r} = {Circle.AreaCalculation(r)}");
                    break;
                default:
                    break;
            }
        }


        public static void RectangleAreaOrPerimeterCalculation()
        {
            int n = Menu.SubMenu("Dikdörtgenin");
            Console.Write("Hesaplancak Olan Uzun Kenar Değerini Giriniz : ");
            double longEdge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hesaplancak Olan Kısa Kenar Değerini Giriniz : ");
            double shortEdge = Convert.ToDouble(Console.ReadLine());
            switch (n)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Dairenin Verilen Değerlere Göre Çevre Hesaplaması : \n");
                    Console.WriteLine($"2 * ({longEdge} + {shortEdge}) = {Rectangular.PerimeterCalculation(longEdge,shortEdge)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Dairenin Verilen Değerlere Göre Alan Hesaplaması : \n");
                    Console.WriteLine($"{longEdge} * {shortEdge} = {Rectangular.AreaCalculation(longEdge,shortEdge)}");
                    break;
                default:
                    break;
            }
        }

        public static void TriangleAreaOrPerimeterCalculation()
        {
           
            int n = Menu.SubMenu("Üçgenin");
            Console.Write("Üçgenin Taban Değeri : ");
            double b = Convert.ToDouble(Console.ReadLine());
             Console.Write("Üçgenin Yükselik Değeri : ");
            double h = Convert.ToDouble(Console.ReadLine());
           
            switch (n)
            {

                case 1:
                    Console.Clear();
                    PisagorTeorimi();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Üçgenin Verilen Değerlere Göre Alan Hesaplaması : \n");
                    Console.WriteLine($"({b} * {h}) / 2 = {TriangleCalculation.AreaCalculation(b,h)}");
                 
                    break;
                default:
                    break;
            }

        }

        private static void PisagorTeorimi()
        {
              double a = 0, b=0,c=0;
             Console.WriteLine("Lütfen Bilinmeyen Değerler İçin Sıfır Giriniz \n\n");
             Console.Write("Hesaplancak A Değerini Giriniz : ");
             a = Convert.ToDouble(Console.ReadLine());
             Console.Write("Hesaplancak B Değerini Giriniz : ");
             b = Convert.ToDouble(Console.ReadLine());
             Console.Write("Hesaplancak C Değerini Giriniz : ");
             c = Convert.ToDouble(Console.ReadLine());
         
            Console.WriteLine("Üçgenin Verilen Değerlere Göre Çevre Hesaplaması : \n");

            if (a == 0 && c != 0 && b != 0)
            {
                Console.Write("a² + b² = c²  => Pisagor teoreminine A değeri bilinmiyorsa sonuç : ");
                Console.WriteLine($"{TriangleCalculation.PerimeterCalculation(a, b, c)}");
            }
            else if (a != 0 && c != 0 && b == 0)
            {
                Console.Write("a² + b² = c²  => Pisagor teoreminine B değeri bilinmiyorsa sonuç : ");
                Console.WriteLine($"{TriangleCalculation.PerimeterCalculation(a, b, c)}");
            }

            else if (a != 0 && b != 0 && c == 0)
            {
                Console.Write("a² + b² = c²  => Pisagor teoreminine göre C değeri bilinmiyorsa sonuç : ");
                Console.WriteLine($"{TriangleCalculation.PerimeterCalculation(a, b, c)}");
            }
            else
            {
                Console.Write("P = a + b + c  => Tüm değerler biliniyorsa sonuç : ");
                Console.WriteLine($"{TriangleCalculation.PerimeterCalculation(a, b, c)}");
            }
        }

        public static void SquareAreaOrPerimeterCalculation()
        {
             int n = Menu.SubMenu("Karenin");
            Console.Write("Hesaplancak Olan  Kenar Uzunluk Değerini Giriniz : ");
            double longValue = Convert.ToDouble(Console.ReadLine());
           
            switch (n)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Karenin Verilen Değerlere Göre Çevre Hesaplaması : \n");
                    Console.WriteLine($"4*  {longValue}) = {Square.AreaCalculation(longValue)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Karenin Verilen Değerlere Göre Alan Hesaplaması : \n");
                    Console.WriteLine($"{longValue} * {longValue} = {Square.AreaCalculation(longValue)}");
                    break;
                default:
                    break;
            }
        }

    }
}