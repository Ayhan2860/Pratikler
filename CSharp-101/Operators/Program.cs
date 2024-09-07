// See https://aka.ms/new-console-template for more information
// Atama ve işlemli atama
Console.WriteLine("********** Atama ve işlemli atama **********");
int x = 3;
int y = 3;
y = y + 2;
Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
x += 2;
Console.WriteLine(x);

// Mantıksal operatorler
Console.WriteLine("\n********** Mantıksal operatorler **********");
// || =VEYA; && = VE; ! = DEĞİLDİR;
bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect");

if (isSuccess || isCompleted)
    Console.WriteLine("Great");

if (isSuccess && !isCompleted)
    Console.WriteLine("Fine");


// İlişkisel oparetorler 
// <,>,<=,>=,==,!=
Console.WriteLine("\n********** İlişkisel operatorler **********");
int a = 3;
int b = 4;
bool sonuc = a < b;

Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);


//Arıtmatik operatorler  
Console.WriteLine("\n********** Arıtmatik operatorler **********");
// +, -, *, /
int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 + sayi2;

Console.WriteLine(sonuc1);
sonuc1 = sayi1 - sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);
sonuc1 = ++sayi1 /*++ değişkenin önünde iken çalışıyor..*/  ;
Console.WriteLine(sonuc1);

// % : Mod alma operatorü
int sonuc2 = 20 % 3;
Console.WriteLine(sonuc2);

Console.ReadKey();
