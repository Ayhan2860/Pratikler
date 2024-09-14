
namespace PolymorphismAndSealedClass
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapabilirler.");
        }
        protected override void UyaranlarTepki()
        {
            base.UyaranlarTepki(); // Base sınıfın metotdunu kullanmaktadır.
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            Solunum();
            Beslenme();
            Bosaltim();
            Adaptasyon();
            UyaranlarTepki();
        }

        public void SurunerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            Solunum();
            Beslenme();
            Bosaltim();
            Adaptasyon();
            UyaranlarTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçarak hareket ederler.");
        }
    }
}