using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reküsif - öz yinelemeli (kendi kendini çağıran fonksiyon)
            // 3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result *3;
                Console.WriteLine(result);
            }
            Console.WriteLine("Metot Sonucu");
            Islemler intance = new();
            Console.WriteLine(intance.Expo(3,4));

            //Extension metotlar
            string ifade = "Ayhan Karaman";
            var result2 = ifade.ChecSpaces();
            var result3= ifade.RemoveWhiteSpaces();
           Console.WriteLine(result2);
           if (result2)
           {
               Console.WriteLine(result3); 
               Console.WriteLine(ifade.MakeUpperCase());
               Console.WriteLine(ifade.MakeLowerCase());
           }

           int[] array = {9,7,5,3,2,1,4};
          array.SortArray();
          array.WhiterResult();
          int sayi1 = 5;
           Console.WriteLine( sayi1.IsEvenNumber());

           Console.WriteLine(ifade.GetFirstCharactet());
         
        }
    }

    class Islemler
    {
        public int  Expo(int sayi, int us)
        {
            if(us<2)
            return sayi;
           return Expo(sayi,us-1) *sayi;

           //Expo(3,4)
           //Expo(3,3) * 3;
           //Expo(3,2) * 3 * 3;
           //Expo(3,1) * 3 * 3 * 3;
           // 3*3*3*3 =3^4
        }
    }

    public static class Extension
    {
       public static bool ChecSpaces(this string param) {
           return param.Contains(" ");
       }

       public static string RemoveWhiteSpaces(this string param){
           string[] dizi = param.Split(" ");
           return string.Join("*",dizi);
       }

       public static string MakeUpperCase(this string param){
           return param.ToUpper();
       }
        public static string MakeLowerCase(this string param){
           return param.ToLower();
       }
       public static int[] SortArray(this int[] param){
           Array.Sort(param);
           return param;
       }
       public static void WhiterResult(this int[] param){
           foreach (var item in param)
           {
               Console.WriteLine(item);
           }
       }
       public static bool IsEvenNumber(this int param)
       {
           return param%2 == 0;
       } 
       public static string GetFirstCharactet(this string param)
       {
           return param.Substring(0,1);
       }
       
    }
}
