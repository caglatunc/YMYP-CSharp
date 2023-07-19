namespace _06.Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> names = new();
            names.Add("Taner");//0
            names.Add("Tugay");//1
            names.Add("Tahir");//2
            names.Add("Toprak");//3
            names.Add("Türkan");//4
            names.Add("Seval");//5

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]);

            //for, foreach, while


            //for (int x = 0; x < names.Count(); x++)
            //{
            //    Console.WriteLine(names[x]);
            //}

            //foreach var x in names)  //liste kadar dönderir.
            //{
            //Console.WriteLine(x);
            //}
            //int x = 0;
            while(names.Count > 0) //while Sonsuz döngü oluşturur ya da şartlı hali var.
            {
               // x++;
                //if (x == 5) break;

               Console.WriteLine("Çalışıyor!");

                for (int x = 0; x < names.Count(); x++)
                {
                    if(x==4)
                    {
                        break;//bu döngüyü sonlandırır.
                    }
                    if(x==2)
                    {
                        continue;//bu da döngüde kalan kısmı atar.
                    }
                }
            }
        }
    }
}