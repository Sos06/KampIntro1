using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", "java", "Pyton" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            //Üsteki For İşlemi İle Alttaki Foreach Aynı İşlemi Yapar

            foreach (string buBirDegisken in kurslar)
            {
                Console.WriteLine(buBirDegisken);
            }

            Console.WriteLine("Foreach Bitti");

        }
    }
}
