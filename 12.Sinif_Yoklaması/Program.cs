using System;

public class Ogrenci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public int Numarasi { get; set; }
    public bool SiniftaMi { get; set; }



}

namespace _12.SınıfYoklamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci { Adi = "Ali", Soyadi = "Yılmaz", Numarasi = 1, SiniftaMi = true },
                new Ogrenci { Adi = "Ayşe", Soyadi = "Kara", Numarasi = 2, SiniftaMi = false },
                new Ogrenci { Adi = "Mehmet", Soyadi = "Demir", Numarasi = 3, SiniftaMi = true },
            };


            Console.WriteLine("Öğreci Yoklama Sistemine Hoşgeldiniz");
            Console.WriteLine("A.Öğrenci Listesini Göster");
            Console.WriteLine("B.Yoklama Al");
            Console.WriteLine("C.Gelmeyen Öğrenci Listesi");
            Console.WriteLine("D.Çıkış");

            while (true)
            {
                string cevap = Console.ReadLine();

                if (cevap == "A")
                {

                    foreach (var ogrenci in ogrenciler)
                    {
                        Console.WriteLine($" Öğrenci Adı: {ogrenci.Adi} - Öğrenci Soyadı: {ogrenci.Soyadi} - Öğrenci Numarası: {ogrenci.Numarasi} - {ogrenci.SiniftaMi}");

                    }
                }
                else if (cevap == "B")
                {
                    Console.WriteLine("Öğrenci numarasını yazın:"); // yoklama alma işlemi öğrenci numarası istesin
                    string NumarasiString = Console.ReadLine();

                    if (!int.TryParse(NumarasiString, out int Numarasi))
                    {
                        Console.WriteLine("Öğrenci Numarası bir sayı olmalıdır!");

                    }
                    else
                    {

                        Ogrenci ogrenci = ogrenciler.Find(o => o.Numarasi == Numarasi);

                        if (ogrenci == null)
                        {
                            Console.WriteLine("Geçersiz öğrenci numarası! Lütfen tekrar deneyin.");
                        }
                        else if (ogrenci.SiniftaMi)
                        {

                            Console.WriteLine($"{ogrenci.Adi} {ogrenci.Soyadi} isimli öğrenci sınıfta!");

                        }
                        else
                        {
                            ogrenci.SiniftaMi = false;
                            Console.WriteLine($"{ogrenci.Adi} {ogrenci.Soyadi} isimli öğrenci sınıfta değil!");
                        }
                        
                    }
                }

                else if (cevap == "C")
                {
                    Console.WriteLine("Gelmeyen Öğrenci Listesi");
                    foreach (var ogrenci in ogrenciler)
                    {
                        if (!ogrenci.SiniftaMi)
                        {
                            Console.WriteLine($"{ogrenci.Adi} {ogrenci.Soyadi}");
                            Console.WriteLine($"{ogrenci.Adi} {ogrenci.Soyadi} isimli öğrenci sınıfta değil.");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Geçersiz öğrenci numarası! Lütfen tekrar deneyin.");
                }

               
            }



        }

    }
}

















