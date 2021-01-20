using System;

namespace EnBuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;
            int sayi3 = 5;

            if (sayi1>sayi2 && sayi1>sayi3)
            {
                Console.WriteLine("Sayi1 Büyüktür Bütün Sayılardan");
            }
            else if (sayi2>sayi1 && sayi2>sayi3)
            {
                Console.WriteLine("Sayi2 Büyüktür Bütün Sayılardan");
            }
            else
            {
                Console.WriteLine("Sayi3 Büyüktür Bütün Sayılardan");
            }
           
        }
    }
}
