// See https://aka.ms/new-console-template for more information
//erişim_berlirteci geri_dönüş_tipi metot_adı(parametre listesi/arguman)
// {
// komutlar
// geri dönüşlerde "return" kullanmak gerekir
// }


int a = 22;
int b = 3;
Console.WriteLine(a + b);
Console.WriteLine("*************");



int result = Topla(a, b);
Console.WriteLine(result);


Console.WriteLine("****Metotlar Sınıfı****");
Metotlar metotlar = new Metotlar();
metotlar.EkranaYazdir(Convert.ToString(result));

int result2 = metotlar.ArttirVeTopla(ref a, ref b);

metotlar.EkranaYazdir(Convert.ToString(result2));
metotlar.EkranaYazdir(Convert.ToString(a + b));


static int Topla(int x, int y)
{
    return x + y;
}


class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int x, ref int y)
    {
        x += 1;
        y += 1;
        return (x + y);
    }
}
