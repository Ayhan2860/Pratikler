// See https://aka.ms/new-console-template for more information
using AbstractExample;

Otomobil otomobil = new Focus();
Console.WriteLine("*********** Focus ***********");
Console.WriteLine(otomobil.Markasi().ToString());
Console.WriteLine(otomobil.TekerSayisi());
Console.WriteLine(otomobil.Rengi().ToString());


Console.WriteLine("\n*********** X10 ***********");
otomobil = new X10();
Console.WriteLine(otomobil.Markasi().ToString());
Console.WriteLine(otomobil.TekerSayisi());
Console.WriteLine(otomobil.Rengi().ToString());


