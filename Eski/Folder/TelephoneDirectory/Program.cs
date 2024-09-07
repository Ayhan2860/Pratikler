using System;
using System.Text.RegularExpressions;
using Business;
using Database;
using Entities;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
           
           DirectoryManager directoryManager = new DirectoryManager(new InMemoryDirectory());

           int vote = 0;
           
           while (vote == 0)
           {
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydet");
                Console.WriteLine("(2) Varolan Numarayı Sil");
                Console.WriteLine("(3) Varolan Numarayı Güncelle");
                Console.WriteLine("(4) Rehberi Listele");
                Console.WriteLine("(5) Rehberde Arama Yap");
                Console.WriteLine("\n(6) Çıkış Yap\n");
                vote = Convert.ToInt32(Console.ReadLine());
           switch(vote)
           {
               
               case 1 :
               Console.Clear();
               Directory directory = NewPhoneNumber();
               directoryManager.Add(directory);
               DirectoryListed(directoryManager);
               Console.WriteLine("İlerlemek için bir tuşa basın...");
               Console.ReadKey();
               vote = 0;
               break;
               case 2 :
               
               while (vote == 2)
            {
               Console.Clear();
               
               Directory deletedPerson = DeletePerson();
               var personInfo = directoryManager.GetByName(deletedPerson.FirstName,deletedPerson.LastName);
               char voteChar = ' ';
               
               if (personInfo !=null)
                {
                    DeletedResult(directoryManager, out vote, deletedPerson, personInfo, out voteChar);

                }

              else
                {
                    string terminationString = "Silmeyi sonlandırmak için";
                    string refreshString = "Yeniden denemek için";
                    vote = NotProcessResult(terminationString, refreshString,2);

                }

            }
               break;

               case 3:
               Console.Clear();
               while (vote == 3)
            {
                Directory checkPerson = CheckPerson();
               
               char voteChar = ' ';
               var personUpdateInfo = directoryManager.GetByName(checkPerson.FirstName,checkPerson.LastName);
               
               
               if (personUpdateInfo !=null)
                {
                    UpdatedDirectoryPerson(directoryManager, out vote, out voteChar, personUpdateInfo);
                }
                else
               {
                    string terminationString = "Güncellemeyi sonlandırmak için";
                    string refreshString = "Yeniden denemek için";
                    vote = NotProcessResult(terminationString, refreshString,3);
               }



            }    
               break;

               case 4:
                    Console.Clear();
                    DirectoryListed(directoryManager);
                    Console.WriteLine("\nAnasayfaya dönmek için bir tuşa basınız...");
                    Console.ReadKey();
                    vote =0;
               break;
               case 5:
                    Console.Clear();                   
                    Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                    int numSearch = Convert.ToInt32(Console.ReadLine());
                   
                   
                    if (numSearch == 1)
                    {   Console.Clear();
                        Console.WriteLine("İsim veya soyisime göre arama :");
                        string value = Console.ReadLine(); 
                        if (value != null)
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");
                            Console.WriteLine("**********************************************");
                            foreach (var item in directoryManager.GetByContainsName(value))
                          {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}\n-");
                          }
                          
                        }
                        else
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");
                            Console.WriteLine("**********************************************");
                              foreach (var item in directoryManager.GetList())
                          {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}\n-");
                          }
                          
                        }
                        
                    }
                    else if(numSearch == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Telefon numarasına göre arama: ");
                        string value = Console.ReadLine();

                        if (value != null)
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");
                            Console.WriteLine("**********************************************");
                            foreach (var item in directoryManager.GetByContainsPhoneNumber(value))
                          {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}\n-");
                          }
                          
                        }
                        else
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");
                            Console.WriteLine("**********************************************");
                              foreach (var item in directoryManager.GetList())
                          {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}\n-");
                          }

                          
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Yanlış bir tuşlama yaptınız...");
                        Console.WriteLine("\nAnasayfaya dönmek için bir tuşa basınız...");
                        Console.ReadKey();
                        vote =0;
                    }
                      
                    
                    Console.WriteLine("\nAnasayfaya dönmek için bir tuşa basınız...");
                    Console.ReadKey();
                    vote =0;
               break;


               case 6:
                    vote =-1;
               break;
               default :
               
                if (vote >6 || vote<-1)
                {
                   Console.Clear(); 
                   Console.WriteLine("Hatalı seçim yaptınız geri dönmek için bir tuşa basınız...");
                   Console.ReadKey();
                   vote = 0;
                }
               break;
           }
        

            
        }
           
           
             

           



          


           
        }

      

        private static void UpdatedDirectoryPerson(DirectoryManager directoryManager, out int vote, out char voteChar, Directory personUpdateInfo)
        {
            
            Directory updatedPerson = UpdatedPerson();
            Console.Write($"\n{personUpdateInfo.FirstName} {personUpdateInfo.LastName} isimli kişi rehberden güncellenmek üzere, onaylıyor musunuz ?(y/n) : ");
            voteChar = Convert.ToChar(Console.ReadLine());
            if (voteChar == 'y')
            {
                directoryManager.Update(updatedPerson);
                Console.Clear();
                DirectoryListed(directoryManager);
                Console.WriteLine($"\n{personUpdateInfo.FirstName} {personUpdateInfo.LastName} isimli kişi rehberde güncellendi ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;
            }
            else if (voteChar == 'n')
            {
                Console.Clear();
                Console.WriteLine("İşlem iptal edildi ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış bir seçim yaptınız ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;
            }
        }

        private static void DirectoryListed(DirectoryManager directoryManager)
        {
             Console.WriteLine("Telefon Rehberi");
             Console.WriteLine("**********************************************");
            foreach (var item in directoryManager.GetList())
            {
                Console.WriteLine($"İsim: {item.FirstName}\nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}\n- ");
            }
        }

        private static int NotProcessResult(string terminationString, string refreshString, int vetoNum)
        {
            int vote;
            Console.Clear();
            Console.Write($"*{terminationString} : (1)");
            Console.Write($"\n*{refreshString}     : (2)\n");
            vote = Convert.ToInt32(Console.ReadLine());
            switch (vote)
            {
                case 1:
                    vote = 0;
                    break;
                case 2:
                    vote = vetoNum;
                    break;
            }

            return vote;
        }

        private static void DeletedResult(DirectoryManager directoryManager, out int vote, Directory deletedPerson, Directory personInfo, out char voteChar)
        {
            Console.Write($"\n{personInfo.FirstName} {personInfo.LastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) : ");
            voteChar = Convert.ToChar(Console.ReadLine());
            if (voteChar == 'y')
            {
                directoryManager.Delete(deletedPerson);
                Console.Clear();
                DirectoryListed(directoryManager);
                Console.WriteLine($"\n{personInfo.FirstName} {personInfo.LastName} isimli kişi rehberden silindi ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;
            }
            else if (voteChar == 'n')
            {
                Console.Clear();
                Console.WriteLine("İşlem iptal edildi ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış bir seçim yaptınız ilerlemek için bir tuşa basın");
                Console.ReadKey();
                vote = 0;
            }
        }

        static Directory  NewPhoneNumber()
        {
           Console.Write("Lütfen Id giriniz : ");
           int inputId = Convert.ToInt32(Console.ReadLine());

           Console.Write("Lütfen isim giriniz : ");
           string inputFirstName = Console.ReadLine();

           Console.Write("Lütfen soyisim giriniz : ");
           string inputLastName = Console.ReadLine();

           Console.Write("Lütfen telefon numarası giriniz : ");
           string inputPhoneNumber = Console.ReadLine();
           Directory directory = new Directory 
             {
               Id = inputId,
               FirstName =inputFirstName,
               LastName =inputLastName,
               PhoneNumber = inputPhoneNumber
             };
           return directory;
     
        }
         static Directory  DeletePerson()
         {
               Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
               
               Console.Write("İsim : ");
               string firstName = Console.ReadLine();
               Console.Write("Soyisim : ");
               string lastName = Console.ReadLine();
               Console.ReadKey();
               var personDirectory = new Directory 
               { 
                 FirstName = firstName,
                 LastName = lastName
               };
               return personDirectory;
         }

          static Directory  CheckPerson()
         {
               Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
               
               Console.Write("İsim : ");
               string firstName = Console.ReadLine();
               Console.Write("Soyisim : ");
               string lastName = Console.ReadLine();
              
              
               var personDirectory = new Directory 
               { 
                 FirstName = firstName,
                 LastName = lastName,
                 
               };
               return personDirectory;
         }

         static Directory  UpdatedPerson()
         {
               Console.Write("Bilgileri güncellemek için bir tuşa basın...");
               Console.ReadKey();
               Console.Clear();
               Console.WriteLine($"Lütfen kişinin güncel bilgilerini giriniz : ");
               
               Console.Write("İsim : ");
               string firstName = Console.ReadLine();
               Console.Write("Soyisim : ");
               string lastName = Console.ReadLine();
               Console.Write("Telefon Numarası : ");
               string phoneNumber = Console.ReadLine();
               var personDirectory = new Directory 
               { 
                 FirstName = firstName,
                 LastName = lastName,
                 PhoneNumber =phoneNumber
                 
               };
               return personDirectory;
         }

    }
}

