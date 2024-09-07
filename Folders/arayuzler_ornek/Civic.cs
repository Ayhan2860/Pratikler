using System;

namespace arayuzler_ornek
{
    public class Civic : IOtomobil
    {
        public string HangiMarkaAraci()
        {
            return Marka.Civic;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public string StandartRenkNe()
        {
            return Renk.Gri;
        }
    }
}