namespace _12.SınıfYoklamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Cagla", OgrenciSoyadi = "Tunc", OgrenciNumarasi = 5000, SiniftaMi = false });
            ogrenciListesi.Add(new Ogrenci() { OgrenciAdi = "Ercan", OgrenciSoyadi = "Savas", OgrenciNumarasi = 5000, SiniftaMi = true });
            Console.WriteLine("Öğreci Yoklama Sistemi");
            Console.WriteLine("İşlem Listesi: Seçim yapınız");
            Console.WriteLine("1.Öğrenci Listesini Göster");
            Console.WriteLine("2.Yoklama Al");
            Console.WriteLine("3.Gelmeyen Öğrenci Listesi");
            Console.WriteLine("4.Çıkış");

            while (true)
            {
                string cevap = Console.ReadLine();

                if (cevap == "Listeyi Göster")
                {

                    foreach (Ogrenci ogrenci in ogrenciListesi)
                    {
                        Console.WriteLine($" Öğrenci Adı: {ogrenci.OgrenciAdi} - Öğrenci Soyadı: {ogrenci.OgrenciSoyadi} - Öğrenci Numarası: {ogrenci.OgrenciNumarasi} - {ogrenci.SiniftaMi}");
                    }
                }
                else if (cevap == "Yoklama Al")
                {
                    Console.WriteLine("Öğrenci numarasını yazın:"); // yoklama alma işlemi öğrenci numarası istesin
                    string ogrenciNumarasiString = Console.ReadLine();

                    int ogrenciNumarasi = 0;
                    if (!int.TryParse(ogrenciNumarasiString, out ogrenciNumarasi))
                    {
                        Ogrenci ogrenci = ogrenciListesi.Find(o => o.OgrenciNumarasi == ogrenciNumarasi);
                        if (ogrenci != null)
                        {
                            ogrenci.SiniftaMi = true;
                            Console.WriteLine($"{ogrenci.OgrenciAdi} adlı öğrenci yoklama alındı ve sınıfta.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz öğrenci numarası! Lütfen tekrar deneyin.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci Numarası bir sayı olmalıdır.");
                    }

                }





            }









        }
    }
}

public class Ogrenci
{
    public string OgrenciAdi;
    public string OgrenciSoyadi;
    public int OgrenciNumarasi;
    public bool SiniftaMi = false;

}