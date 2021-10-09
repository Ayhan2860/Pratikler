using System;

namespace collections_question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız.");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();
            string soundLetters = "aeıiuüoö";
            char[] letter = sentence.ToCharArray();
            char[] soundLetter = soundLetters.ToCharArray();
            string items = "";
           
             

            for (int i = 0; i <= soundLetter.Length-1; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    
                     if(letter[j] == soundLetter[i])
                     {
                         items += letter[j].ToString();
                     }
                    
                }
                   
            }
             
            char[] soundLettersOut = items.ToCharArray();
             
            foreach (var item in soundLettersOut)
            {
                    Console.Write(item +" ");
            }
          
            
          


            Console.ReadKey();
        }
    }
}
