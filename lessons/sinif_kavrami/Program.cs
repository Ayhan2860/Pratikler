using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            /*class SınıfAdı
            {
                property söz dizimi:
                [Erişim bildirgeci][VeriTipi] ÖzellikAdı;
                Metot Söz Dizimi:
                [Erişim bildigeci] [Geri dönüş tipi] MetotAdı([parametreler listesi])
                {
                  Metot komutları;
                }
            }
      
            Erişim Belirleyiciler
            * public
            * private
            * internal
            * protected
            */

            Employee employee1 = new Employee();
            employee1.Name = "Mehmet Can";
            employee1.Surname = "Aşçı";
            employee1.EmployeeId = 547898;
            employee1.Department = "Tasarım Uzmanı";
            employee1.EmployeeInfo();

            Console.WriteLine("\n*********************\n");

            Employee employee2 = new Employee();
            employee2.Name = "Gözde ";
            employee2.Surname = "Kanun";
            employee2.EmployeeId = 879147;
            employee2.Department = "Finans Muhasebe";
            employee2.EmployeeInfo();
        }
    }

    class Employee
   {
    public string Name;
    public string Surname;
    public int EmployeeId;
    public string Department;

  public void EmployeeInfo()
  {
    Console.WriteLine("Çalışan Adı : {0}", Name);
    Console.WriteLine("Çalışan Soyadı : {0}",Surname);
    Console.WriteLine("Çalışan Numarası : {0}", EmployeeId);
    Console.WriteLine("Çalışan Departmanı : {0}", Department);
}
  }
}
