using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptan kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungeler:Hayvanlar
    {
        public Surungeler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
     public class Kuslar:Hayvanlar
     {
         public Kuslar()
         {
             base.Adaptasyon();
             base.Beslenme();
             base.Bosaltim();
             base.Solunum();
             base.UyaranlaraTepki();
         }
         public void Ucmak()
         {
             Console.WriteLine("kuşlar uçar.");
         }
     }
}