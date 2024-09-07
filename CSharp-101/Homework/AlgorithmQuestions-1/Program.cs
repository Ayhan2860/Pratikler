// 1. İster

Request1();


// 2. İster


//Request2();

// 3. İster

//Request3();

// 4. İster

//Request4();

static void Request1()
{
    Console.WriteLine("***Ödev_1 / 1. İsterler***");
    Console.Write("Lütfen bir sayı giriniz : ");
    int n = Convert.ToInt32(Console.ReadLine());
    List<int> arr = ReturnNumberList(n);

    for (int i = 0; i < n; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Console.WriteLine($"{arr[i]}");
        }

    }
}

static void Request2()
{
    Console.WriteLine("***Ödev_1 / 2. İsterler***");
    Console.Write("Lütfen birinci sayıyı giriniz : ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Lütfen ikinci sayıyı giriniz : ");
    int m = Convert.ToInt32(Console.ReadLine());
    List<int> arr = ReturnNumberList(n);

    for (int i = 0; i < n; i++)
    {
        if (arr[i] == m || arr[i] % m == 0)
        {
            Console.WriteLine($"{arr[i]} sayısı {m} sayısına eşit veya tam bölünen sayıdır.");
        }
    }
}

static void Request3()
{
    Console.WriteLine("***Ödev_1 / 3. İsterler***");
    Console.Write("Lütfen bir sayı giriniz : ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] words = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Lütfen {i + 1}. kelimeyi giriniz : ");
        string? word = Console.ReadLine();
        while (string.IsNullOrEmpty(word) )
        {
            Console.Write($"Kelimeyi girmediniz, Lütfen kelimeyi giriniz : ");
            word = Console.ReadLine();
        }
        words[i] = word;
    }
    for (int i = words.Length - 1; i >= 0; i--)
    {
        Console.WriteLine($"{i + 1}. kelime : " + words[i]);
    }
}

static void Request4()
{
    Console.WriteLine("***Ödev_1 / 4. İsterler***");
    Console.Write("Lütfen bir cümle yazınız : \n");
    string? sentence = Console.ReadLine();
    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "*", "?" };
    foreach (var c in charsToRemove)
    {
        sentence = sentence?.Replace(c, "");
    }
    Console.WriteLine(sentence);
    var result = sentence?.Split(" ");
    Console.WriteLine("Cümle içinde toplam kelime sayısı : " + result.Length);
    var res = string.Join("", result);
    Console.WriteLine("Cümle içinde bulunan toplam harf sayısı : " + res.Length);
}


static List<int> ReturnNumberList(int n)
{
    Console.Write("Lütfen {0} tane  sayıyı giriniz (Sayıları bir karakter boşluk bırakarak ayırınız) : ", n);
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


    while (arr.Count != n)
    {
        Console.Write("Lütfen {0} tane  sayı girdiğinizden emin olunuz : ", n);
        arr.Clear();
        arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    }

    return arr;
}
