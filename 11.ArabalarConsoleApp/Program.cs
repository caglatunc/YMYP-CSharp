using System;

namespace _11.ArabalarConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<car> cars = new();

        Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz!");
        Console.WriteLine("Size nasıl yardımcı olabilirim?");
        Console.WriteLine("İşlem Listesi:");
        Console.WriteLine("1-Araç Listesi");
        Console.WriteLine("2-Araç Sayısı");
        Console.WriteLine("3-Araç Ekle");
        Console.WriteLine("4-Listeyi Göster");
        Console.WriteLine("5-Çıkış");

        while (true)
        {
            string cevap = Console.ReadLine();
           
            if(cevap.ToLower() == "Araç Listesi".ToLower())
            {
                foreach (car car in cars)
                {
                    Console.WriteLine($"Marka: {car.Marka} - Model: {car.Model} - Motor Gücü: {car.MotorGucu}");
                }
            }else if(cevap. ToLower() == "Araç Sayısı".ToLower())
              Console.Write($"Toplam araç sayısı: {cars.Count()}");
            else if(cevap.ToLower() == "Araç Ekle".ToLower())
            
            {
                 Console.WriteLine("Markayı yazın:");
                string marka = Console.ReadLine();

            tekrar1:;

                Console.WriteLine("Modeli yazın:");
                string modelString = Console.ReadLine();
                int model = 0;

                if(!int.TryParse(modelString, out model))
                {
                    Console.WriteLine("Model bir sayı olmalıdır!");
                    goto tekrar1;
                  
          
                }
            tekrar2:;
                Console.WriteLine("Motor gücünü yazın:");
                string motorGucuString = Console.ReadLine();
                int motorGucu = 0;
                if (!int.TryParse(motorGucuString, out motorGucu))
                {
                    Console.WriteLine("Motor gücü bir sayı olmalıdır!");
                    goto tekrar2;
                }

                car car = new();
                car.Marka = marka;
                car.Model = model;
                car.MotorGucu = motorGucu;

                cars.Add(car);
                Console.WriteLine("Arabanız başarıyla eklenmiştir");

            }else if (cevap.ToLower() == "Çıkış".ToLower())
            {
                Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
                break;
            }
            else if(cevap.ToLower() == "Listeyi göster".ToLower())
            {
                Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz!");
                Console.WriteLine("Size nasıl yardımcı olabilirim?");
                Console.WriteLine("İşlem Listesi:");
                Console.WriteLine("1-Araç Listesi");
                Console.WriteLine("2-Araç Sayısı");
                Console.WriteLine("3-Araç Ekle");
                Console.WriteLine("4-Listeyi Göster");
                Console.WriteLine("5-Çıkış");
                
            }
            else
            {
                Console.WriteLine("Sadece listedki işlemleri yapabilirim!");
                
            }
            Console.WriteLine("Başka ne iş yapmak istersiniz?");
        }
    }
}
public class car
{
    public string Marka;
    public int Model;
    public int MotorGucu;
}