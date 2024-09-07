using System;

namespace arayuzler_ornek
{
    public class Focus : IOtomobil
    {
        public string HangiMarkaAraci()
        {
            return Marka.Focus;
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