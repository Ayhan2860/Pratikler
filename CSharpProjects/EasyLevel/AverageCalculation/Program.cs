// See https://aka.ms/new-console-template for more information
using AverageCalculation;


Console.Write("Lütfen Bir Değer Giriniz : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"\nFibonaççi Sayılarının Toplamının Ortalaması :  {FibonacciAverage.FiboAverage(number)}");




Console.ReadKey();
