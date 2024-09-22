// See https://aka.ms/new-console-template for more information
using TriangleDrawing;

int vote = 0;
vote = Menu.MenuListVote();
Console.Write("Yazdırmak İstediğiniz Karakter Sayısı : ");
int n = Convert.ToInt32(Console.ReadLine());
vote = Result.TriangleVarieties(vote, n);

Console.ReadKey();
