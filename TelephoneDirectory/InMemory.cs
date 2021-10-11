using System.Collections.Generic;
namespace TelephoneDirectory
{
    public class InMemory
    {
         List<Directory> _directory;
         public InMemory()
         {
             _directory = new List<Directory>
             {
                 new Directory{Id =1,FirstName ="Ahmet",LastName="Yavuz",PhoneNumber ="05417874756"},
                 new Directory{Id =2,FirstName ="Berna",LastName="Kızılerik",PhoneNumber ="05358554836"},
                 new Directory{Id =1,FirstName ="Deniz",LastName="Kılıçarslan",PhoneNumber ="05552133258"},
                 new Directory{Id =1,FirstName ="Cengiz",LastName="Türkmen",PhoneNumber ="05364749850"},
                 new Directory{Id =1,FirstName ="Nadir",LastName="Demir",PhoneNumber ="05382142525"}
             };
         }

         public List<Directory> GetAll()
        {
            return _directory;
        }

    }
}