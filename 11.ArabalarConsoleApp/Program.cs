namespace _11.ArabalarConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<car> cars = new();
        cars.Add(new car() { Marka = "BMW", Model = 2023, MotorGucu = 5000 });
        cars.Add(new car() { Marka = "Reno", Model = 2020, MotorGucu = 6000 });

        Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz!");
        Console.WriteLine("Size nasıl yardımcı olabilirim?");
        Console.WriteLine("İşlem Listesi:");
        Console.WriteLine("1-Araç Listesi");
        Console.WriteLine("2-Araç Sayısı");
        Console.WriteLine("3-Araç Ekle");
        Console.WriteLine("4-Listeyi Göster");
        Console.WriteLine("5-Araç Kirala");
        Console.WriteLine("6-Çıkış");

        while (true)
        {
            string cevap = Console.ReadLine();
           
            if(cevap.ToLower() == "Araç Listesi".ToLower()) // Araç listesini konsolda gösterme kodları
            {
                foreach (car car in cars)
                {
                    Console.WriteLine($". Marka: {car.Marka} - Model: {car.Model} - Motor Gücü: {car.MotorGucu}");
                }
            }
            else if(cevap. ToLower() == "Araç Sayısı".ToLower())
              Console.Write($"Toplam araç sayısı: {cars.Count()}");
            else if(cevap.ToLower() == "Araç Ekle".ToLower())
            {
                Console.WriteLine("Markayı yazın:");
                string marka = Console.ReadLine();

            tekrar1:;

                Console.WriteLine("Modeli yazın:");
                string modelString = Console.ReadLine();
                int model = 0;

                if (!int.TryParse(modelString, out model))
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
                Console.WriteLine("5-Araç Kirala");
                Console.WriteLine("6-Çıkış");
                
            }else if(cevap.ToLower() == "Araç Kirala".ToLower())
            {
                for(int x=0; x < cars.Count(); x++)
                {
                    Console.WriteLine($"{x + 1}. {cars[x].Marka}");
                }

                tekrar3:;
                Console.WriteLine("Araç seçimi yapın");
                Console.WriteLine("Araç numarası:");
                string secilenAracString = Console.ReadLine();
                int secilenArac = 0;
                if (!int.TryParse(secilenAracString, out secilenArac))
                {
                    Console.WriteLine("Sadece sayı ile araç seçebilirsiniz!");
                    goto tekrar3;
                }
                if(secilenArac>cars.Count()) 

                {
                Console.WriteLine("Seçtiğiniz araç filoda bulunmuyor!");
                    goto tekrar3;
                }
                Console.WriteLine("Kiralama Tarihi");
                string kiralamaTarihi = Console.ReadLine(); 

                Console.WriteLine("Kiralama Saati");
                string kiralamaSaati = Console.ReadLine();

                Console.WriteLine("Teslim Tarihi");
                 string teslimTarihi = Console.ReadLine();
                
                Console.WriteLine($"{cars[secilenArac-1].Marka} marka aracını {kiralamaTarihi} {kiralamaSaati} tarihinde kiralamak üzere işlem yaptınız.\n" +
                    $" Teslim tarihiniz:{teslimTarihi} {kiralamaSaati}.Aracı zamanında teslim etmezseniz cezai işlem uygulanacaktır. Bizi tercih etiğiniz için teşekkürler.");
            }
            else
            {
                Console.WriteLine("Sadece listedeki işlemleri yapabilirim!");
                
            }
            Console.WriteLine("Başka ne işlem yapmak istersiniz?");
        } // ctrl+k+d kodları düzgün sırasına yerleştirir
    }
}
public class car
{
    public string Marka;
    public int Model;
    public int MotorGucu;
}