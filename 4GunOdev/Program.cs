using System;

namespace _4GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Türkiye'de Bulunan Bazı İllerin Plaka Numaraları
            
            MyDictionary<string, int> sehir = new MyDictionary<string, int>();

            sehir.Add("Adana", 01);
            sehir.Add("Bursa", 16);
            sehir.Add("Çorum", 19);
            sehir.Add("Denizli", 20);
            sehir.Add("Ankara", 06);
            sehir.Add("İstanbul", 34);
            sehir.Add("İzmir", 35);
            sehir.Add("Tokat", 60);
            

            foreach (var city in sehir.Items)
            {
                Console.WriteLine("Şehir : " + city.Item1 + "\tPlaka Kodu : (" + city.Item2 + ")");
            }

            Console.WriteLine("Toplam Plaka Kodu ve İsmi Yazılan İl Sayısı " + sehir.Items.Length);
        }

    }
}
