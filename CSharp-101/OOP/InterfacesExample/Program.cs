// See https://aka.ms/new-console-template for more information
using InterfacesExample;

IOtomobil otomobil = new Fiesta();
Console.WriteLine("*********** Fiesta ***********");
Console.WriteLine(otomobil.Markasi().ToString());
Console.WriteLine(otomobil.TekerSayisi());
Console.WriteLine(otomobil.Rengi().ToString());


Console.WriteLine("\n*********** Corolla ***********");
otomobil = new Corolla();
Console.WriteLine(otomobil.Markasi().ToString());
Console.WriteLine(otomobil.TekerSayisi());
Console.WriteLine(otomobil.Rengi().ToString());

