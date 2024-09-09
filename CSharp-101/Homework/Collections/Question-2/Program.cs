// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen 20 adet sayı giriniz (Sayılar arasında bir karakter boşluk bırakınız): ");
int[] numbers = Console.ReadLine()
.TrimEnd().Split(" ")
.ToList().Select(x => Convert.ToInt32(x)).ToArray();

while (!ErrorHandle(numbers))
{
    numbers = Console.ReadLine()
    .TrimEnd().Split(" ")
    .ToList().Select(x => Convert.ToInt32(x)).ToArray();
}

Array.Sort(numbers);

int n = numbers.Length - 1;

int largestThreeNumAvarage = (numbers[n] + numbers[n-1] + numbers[n-2]) / 3;
int smallestThreeAvarage = (numbers[0] + numbers[1] + numbers[2]) / 3;


Console.WriteLine("En büyük üç sayının ortalaması: {0}", largestThreeNumAvarage);
Console.WriteLine("En küçük üç sayının ortalaması: {0}", smallestThreeAvarage);
Console.WriteLine($"Ortalaması alınmış iki sayının toplam: {largestThreeNumAvarage + smallestThreeAvarage}");





static bool ErrorHandle(int[] list)
{

    if (list.Length < 20 || list.Length > 20)
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


