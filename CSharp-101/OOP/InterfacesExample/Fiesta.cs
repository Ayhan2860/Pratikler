
namespace InterfacesExample
{
    public class Fiesta : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Ford;
        }

        public Renk Rengi()
        {
            return Renk.Beyaz;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}