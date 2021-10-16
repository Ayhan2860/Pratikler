using System;

namespace arayuzler_ornek
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual string StandartRenkNe()
        {
            return Renk.Beyaz;
        }

        public abstract string HagiMarkaAraci();
    }
}