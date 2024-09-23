// See https://aka.ms/new-console-template for more information
using IntegerSumOfBinaries;

Console.Write("Sayıları aralarında boşluk bırakarak giriniz : ");
List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

List<int> sums = Result.BinaryNumbersSum(arr);

foreach (var item in sums)
{
    Console.Write(item + " ");
}


Console.ReadLine();
