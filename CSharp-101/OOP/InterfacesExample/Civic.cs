
namespace InterfacesExample
{
    public class Civic : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Honda;
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