
namespace AbstractExample
{
    public abstract class Otomobil
    {
        public int TekerSayisi() => 4;

        public virtual Renk Rengi() => Renk.Beyaz;
        public abstract Marka Markasi();
    }
}