using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "Bilal", "Meryem", "Hira Nur", "Ömer Asaf" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Hüsamettin");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            
        }
    }
}
