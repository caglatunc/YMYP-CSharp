using System.Runtime.CompilerServices;

namespace _10.Methotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Hello, World!");
           // Metot(x, y);
           int r = Metot(x,y);
            Console.WriteLine($"Sonuç: {r}");
        }

        static void Metot() // geriye değer dönmeyen metot
        {
            int sonuc = 5+3;
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        static int Metot(int a, int b) // geriye değer dönen metot
        {
            int sonuc = a + b;
            return sonuc;
        }
        static int Metot(int a, int b, int c) // geriye değer dönen metot
        {
            int sonuc = a + b + c;
            return sonuc;
        }
    }
}