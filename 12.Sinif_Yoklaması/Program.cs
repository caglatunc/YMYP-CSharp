namespace _12.SınıfYoklaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif sinif = new Sinif();

            //Öğrenci listesini ve öğrenci numaralarını giriyoruz.
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
            {
                new Ogrenci("Ali","1001");
                new Ogrenci("Yılmaz", "Türk", "1002");
                new Ogrenci("Merve", "Ses", "1010");
                new Ogrenci("Murat", "Keskin", "1211");
                new Ogrenci("Burak", "Yılmaz", "1275");
                new Ogrenci("Neslihan", "Han", "2139");
                new Ogrenci("Şahin", "Pek", "1486");
                new Ogrenci("Melisa", "Tanık", "1943");
                new Ogrenci("Gamze", "Yıldız", "2031");
                new Ogrenci("Alihan", "Dertli", "1221");
          
            }



            while(true)
            {
                Console.WriteLine("1.Öğrenci Listesi ve Öğrenci Numrası");
                Console.WriteLine("2.Yoklama Al");
                Console.WriteLine("3.Yoklamayı Göster");
                Console.WriteLine("5.Gelmeyen Öğrenci Listesi");
                Console.WriteLine("Çıkış");


                string OgrenciAdi= Console.ReadLine();
                if(OgrenciAdi != null)
                {
                    Console.WriteLine("Öğrenci adını giriniz");
                    string ad = Console.ReadLine();
                    Console.WriteLine("Öğrenci numarasını giriniz");
                    string numara = Console.ReadLine();
                   

               
                    
                        
                }


                
            }
          

          

           
         

        }
    }
}

public class Ogrenci
{
    public string OgrenciAdi;
    public bool evetCevabi=true;
    public bool hayırCevabi = false;
}