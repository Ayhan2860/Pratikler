// See https://aka.ms/new-console-template for more information
//                       Canlılar
//                          |
//      Bitkiler                          Hayvanlar
//    |          |                      |           |
//  Tohumlu  Tohumsuz              Sürüngenler   Kuşlar

using InheritanceDeclaration;

TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();

tohumluBitkiler.TohumlaCogalma();

Console.WriteLine("\n*********************\n");

Kuslar marti = new Kuslar();

marti.Ucmak();
