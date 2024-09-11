// See https://aka.ms/new-console-template for more information
//List<T> class
//System.Collection.Generic
// T-> object türündedir
List<int> numberList = new List<int>();
numberList.Add(23);
numberList.Add(10);
numberList.Add(4);
numberList.Add(5);
numberList.Add(92);
numberList.Add(34);

List<string> colorList = new List<string>();
colorList.Add("Kırmızı");
colorList.Add("Mavi");
colorList.Add("Turuncu");
colorList.Add("Sarı");
colorList.Add("Yeşil");

//Count
Console.WriteLine(colorList.Count);
Console.WriteLine(numberList.Count);

//Foreach ve List.Foreach ile elemanlar erişim
foreach (var number in numberList)
    Console.WriteLine(number);

foreach (var color in colorList)
    Console.WriteLine(color);


numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));


// Listeden eleman çıkarma
numberList.Remove(4);
colorList.Remove("Yeşil");

// İndex ile eleman çıkarma
colorList.RemoveAt(0);
numberList.RemoveAt(1);

numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

//Liste içerisinde eleman arama
if (numberList.Contains(10))
    Console.WriteLine("10 Liste içerisinde mevcut!");
else
    Console.WriteLine("10 Liste içerisinde bulunamadı!");


//Eleman ile index'e erişim
Console.WriteLine(colorList.BinarySearch("Sarı"));

//Diziyi listeye çevirme
string[] animals = { "Kedi", "Köpek", "Kuş", "İnek", "Koyun", "At", "Zürafa" };
List<string> animalList = new List<string>(animals);

//Listeyi temizleme
animalList.Clear();


// List içinde nesne tutmak
List<User> users = new List<User>();
User user1 = new User();
user1.Id = 1;
user1.Name = "Ayhan Karaman";
user1.Age = 33;


User user2 = new User();
user2.Id = 2;
user2.Name = "Aydın Gürsoy";
user2.Age = 30;

users.Add(user1);
users.Add(user2);


List<User> newUserList = new List<User>();
newUserList.Add(new User()
{
    Id = 3,
    Name = "Mustafa Karaağaç",
    Age = 42
});

foreach (User user in users)
{
    Console.WriteLine($"Kullanıcı Id'si : {user.Id}");
    Console.WriteLine($"Kullanıcı Adı : {user.Name}");
    Console.WriteLine($"Kullanıcı Yaşı : {user.Age}");
}

newUserList.Clear();


public class User
{
    public int id;
    public string name;

    public int age;

    public int Id { get => id; set => id = value; }

    public string Name { get => name; set => name = value; }

    public int Age { get => age; set => age = value; }


}
