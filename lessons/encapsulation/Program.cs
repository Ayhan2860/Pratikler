using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
             Student student1 = new Student();
             student1.FirstName = "Cihat";
             student1.LastName = "Çevik";
             student1.StudentNo = 0202;
             student1.ClassNo=3;
             student1.GetStudentInfo();
             student1.RaiseClass();
             student1.GetStudentInfo();

             Student student2 = new Student("Cüneyt","Altunoğlu",991,1);
             student2.DropItClass();
             student2.DropItClass();
             student2.GetStudentInfo();
        }
    }

    public class Student
{
  private string firstName;
  private string lastName;
  private int studentNo;
  private int classNo;

  public string FirstName
  {
    get{return firstName;}
    set{firstName=value;}
    
  }
  public string LastName{get=> lastName; set=>lastName=value;}
  public int StudentNo{ get=> studentNo; set=>studentNo=value;}
  public int ClassNo
  {
    get=> classNo; 
    set
    {
      if(value<1)
      {
        Console.WriteLine("Sınıf en az 1 olabilir!");
        classNo = 1;
      }
      else
        classNo=value;
      
      
    }
  }

  public Student(string firstName, string lastName, int studentNo, int classNo)
  {
    FirstName = firstName;
    LastName = lastName;
    StudentNo = studentNo;
    ClassNo = classNo;
  }

  public Student(){}

  public void GetStudentInfo()
  {
    Console.WriteLine("\n***** Öğrenci Bilgileri *****");
    Console.WriteLine("Öğrencinin Adı       : {0}",this.FirstName);
    Console.WriteLine("Öğrencinin Soyadı    : {0}",this.LastName);
    Console.WriteLine("Öğrencinin Numarası  : {0}",this.StudentNo);
    Console.WriteLine("Öğrencinin Sınıfı    : {0}",this.ClassNo);
  }

  public void RaiseClass()
  {
    this.ClassNo = this.ClassNo+1;
  }
  public void DropItClass()
  {
    this.ClassNo = this.ClassNo-1;
  }
}
}
