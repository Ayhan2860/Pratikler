using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Bitkiler *****");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();           
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("\n***** Hayvanlar *****");
            Kuslar marti = new Kuslar();
            marti.Ucmak();



        }
    }
}
