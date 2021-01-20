using System;

namespace _2DersOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            urun urun1 = new urun();
            urun1.urunAdi = "iPhone 11 Cep Telefonu";
            urun1.urunFiyati = 7500;

            urun urun2 = new urun();
            urun2.urunAdi = "Xiaomi Note 9 Pro Cep Telefonu";
            urun2.urunFiyati = 3500;

            urun urun3 = new urun();
            urun3.urunAdi = "Kaan 1 Cep Telefonu";
            urun3.urunFiyati = 1500;

            urun urun4 = new urun();
            urun4.urunAdi = "iPhone 4s Cep Telefonu";
            urun4.urunFiyati = 500;


            urun[] urunler = new urun[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("*****FOREACH*****");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " : " + urun.urunFiyati);

            }

            Console.WriteLine("*****FOR*****");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " - " + urunler[i].urunFiyati);
            }

            
            Console.WriteLine("*****WHILE*****");

            int say = 0;
            while (say < urunler.Length)
            {
                Console.WriteLine(urunler[say].urunAdi + " - " + urunler[say].urunFiyati);
                say++;
            }

        }
    }

    class urun
    {
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
    }
}
