using System;

namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public string HangiMarkaAraci()
        {
            return Marka.Corolla;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public string StandartRenkNe()
        {
            return Renk.Beyaz;
        }
    }
}