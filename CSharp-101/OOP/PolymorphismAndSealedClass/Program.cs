// See https://aka.ms/new-console-template for more information
using PolymorphismAndSealedClass;

// Polymorphism:
//              Base sınıfımızda tanımladığımız bir metot'un erişim belirleyicisinden sonra  <<virtual>> anahtar kelimesini ekleriz (Bkz: Canlilar.cs-satır:21/23)
//              Base sınıfmızı miras alan bir sınıfta bu metotdu kullanabilmemiz için erişim belirleyiciden sonra <<override>> anahtar kelimesini kullanırız. Kullandığımız bu metotdu sınıfın kendine özgü nitelikleri özelleştirebilir veya base sınıfın içerisindeki metot yapısı ilede kullanabiliriz.(Bkz: Hayvanlar.cs- satır:11/14 veya Bitkiler.cs - satır:12/15)
// Yukarıda anlatılan işleme Polymorphism diyoruz.
TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
tohumluBitkiler.TohumlaCogalma();

Console.WriteLine("\n**********************\n");

Kuslar marti = new Kuslar();
marti.Ucmak();

