
namespace PolymorphismAndSealedClass
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar.");

        }
        protected override void UyaranlarTepki()
        {
            //base.UyaranlarTepki(); // Burada base sınıfın metotdu kullanılmamaktadır.
            Console.WriteLine("Bitkeler güneşe tepki verir");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Fotosentez();
            UyaranlarTepki();
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalırlar.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Fotosentez();
            UyaranlarTepki();
        }

        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalırlar.");
        }
    }
}