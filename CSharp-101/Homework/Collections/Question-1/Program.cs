// See https://aka.ms/new-console-template for more information
List<int> primes = new List<int>();
List<int> notPrimes = new List<int>();

Console.Write("Lütfen 20 adet sayı giriniz (Sayılar arasında bir karakter boşluk bırakınız): ");
List<int> arr = Console.ReadLine().TrimEnd().Split(" ").ToList()
.Select(temp => Convert.ToInt32(temp)).ToList();
while (!ErrorHandle(arr))
{
    arr.Clear();
    arr = Console.ReadLine().TrimEnd().Split(" ").ToList()
   .Select(temp => Convert.ToInt32(temp)).ToList();
}

foreach(var item in arr)
{
    if(IsPrime(item))
       primes.Add(item);
    else
       notPrimes.Add(item);
}


Console.WriteLine("Asal Sayılar");
SortedWrite(primes);

Console.WriteLine("\nAsal Olmayan Sayılar");
SortedWrite(notPrimes);



static void SortedWrite(List<int> list)
{
    list.Sort();
     foreach(var item in list)
     {
         Console.WriteLine(item);
     }
}


static bool IsPrime(int num)
{
    int control = 0;
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0)
            control++;
    }

    return !(control != 0);
}






static bool ErrorHandle(List<int> list)
{

    if (list.Count < 20 || list.Count > 20)
    {
        Console.WriteLine("Lütfen 20 adet sayı giriniz");
        return false;
    }
    if (list.Any(i => i < 0))
    {
        Console.WriteLine("Lütfen pozitif sayılar giriniz");
        return false;
    }
    return true;

}










