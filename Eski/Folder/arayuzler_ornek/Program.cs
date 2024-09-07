using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** INTERFACE ***************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRenkNe());

            Console.WriteLine("******************************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRenkNe());

            Console.WriteLine("*************** ABSTRACT ***************");
            NewFocus focus1 = new NewFocus();
            Console.WriteLine();
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRenkNe());

            Console.WriteLine("******************************");
            NewCivic civic1 = new NewCivic();
            Console.WriteLine();
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRenkNe());
        }
    }
}
