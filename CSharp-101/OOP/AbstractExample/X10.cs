
namespace AbstractExample
{
    public class X10 : Otomobil
    {
        public override Marka Markasi()
        => Marka.Togg;

        public override Renk Rengi()
        {
            return Renk.Mavi;
        }
    }
}