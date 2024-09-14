
namespace PolymorphismAndSealedClass
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenirler.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yaparlar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yaparlar.");
        }

        protected virtual void UyaranlarTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}