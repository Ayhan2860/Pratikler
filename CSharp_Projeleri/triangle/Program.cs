using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int vote = 0; 
            vote = Menu.MenuListVote();
            Console.Write("Yazdırmak İstediğiniz Karakter Sayısı : ");
            int n = Convert.ToInt32(Console.ReadLine());
            vote = Result.TriangleVarieties(vote, n);

            Console.ReadKey();

        }

       

    }
}
