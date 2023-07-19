Console.WriteLine("Hello, World!");

//[ ] => Listeleri temsil eder => array işareti

//string[] names = { "afsgag", "hshs" };
string[] names = new string[3]; //içerisine kaç değer atacağımızı belirtmek gerekiyor
names[0] = "Çağla";
names[1] = "Çağla";
names[2] = "Çağla";

List<string> names = new (); // örneğe dönüştürmek için new kelimesini kullanıyoruz. Örneğe dönüşürme işleminde yazılımda "instance" üretme deniyor.OOP'de sınıfın nesneye dönüştürme manasına gelir.

names.Add("Çağla");
names.Add("Çağla");
names.Add("Çağla");
names.Add("Çağla");
names.Add("Çağla");

//class User
//{
//    public string Name;
//}
//var user1 = new User();
//var user2 = new User();
//var user3 = new User();
//List<User> users = new List<User>();
//List<User> users = new();
