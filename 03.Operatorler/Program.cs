Console.WriteLine("Hello, World!");

//Operatörler
// = eşittir operatörü => değer ataması yapar
// == kontrol operatörü => a ve b değerini konrol eder

int a = 0;
int b = 1;

var c = (a == b); // a ve b değerini birbirine eşitse true, değilse false.

// + - * / matematiksel operatörler

int r = ((5 * 2) + 5) - 0;

// +=  eşitirden sonraki değeri + işaretinden önceki değere ekler
// -= eşitirden sonraki değeri - işaretinden önceki değerden çıkarır

int z = 1;

z += 5; ===> z = z + 5;

//++; kullanılan değişkenin rakamını 1 artırır
//--; kullanılan değişkenin rakamını 1 azalır
int x = 1;
x++;
x--;

// + operatörü string değerlerde birleştirme işlemi yapar;

string name = "Çağla" + " " + "Tunç"; // Çağla Tunç
string name2 = $"{name2} 34 yaşında bir eğitmen";  // ==> Çağla Tunç 34 yaşında bir eğitmen

// @ operatör ters bölü işaretini kullanmamızı sağlıyor. ya da bu şekilde kullanılacak ==>\\
string url = "@http:"; //==> http:\ ya da "http:\\"



var result = name + 2; // Rakam + string birliştirme işlemi yapar ==>Çağla Tunç2

// % => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder.

var r2 = ( x % r2);
