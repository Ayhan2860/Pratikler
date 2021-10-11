using System;

namespace statik_sinif_ve_üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Çalışan Sayısı :{0}",Employee.NumberOfEmployees);
            Employee employee1 = new Employee("Özhan","Eken","Bakım");
            Console.WriteLine ("Çalışan Sayısı :{0}",Employee.NumberOfEmployees);
            Employee employee2 = new Employee("Tuğba","Seren","Muhasebe");
            Employee employee3 = new Employee("Fikret","Demirtopçu","Kalıphane");
            Console.WriteLine ("Çalışan Sayısı :{0}",Employee.NumberOfEmployees);


            Console.WriteLine("Toplama işlemi sonucu :{0}",Transactions.Gather(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu :{0}",Transactions.Extraction(400,50));
        }
    }

    class Employee
{
  private static int numberOfEmployees;

  public static int NumberOfEmployees{get => numberOfEmployees;set=>numberOfEmployees = value;}

  private string FirstName;
  private string LastName;
  private string Department;

  static Employee()
  {
    numberOfEmployees = 0;
  }
 
  public Employee(string firstName, string lastName, string department)
  {
    this.FirstName = firstName;
    this.LastName = lastName;
    this.Department = department;
    numberOfEmployees ++;
  }
}

static class Transactions
{
  
  public static long Gather(int num1,int num2)
  {
    return num1 + num2;
  }
  public static long Extraction(int num1,int num2)
  {
    return num1 - num2;
  }
}
}
