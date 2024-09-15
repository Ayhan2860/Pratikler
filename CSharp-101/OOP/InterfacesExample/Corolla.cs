
namespace InterfacesExample
{
    public class Corolla : IOtomobil
    {
        public Marka Markasi()
        => Marka.Toyota;

        public Renk Rengi()
        => Renk.Mavi;

        public int TekerSayisi()
        => 4;
    }
}