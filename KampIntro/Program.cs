using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketleri = "Kategori";
            int kayitliOgrenci = 32000;
            double faizOrani = 1.75;
            double dolarDun = 7.54;
            double dolarBugun = 7.58;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Dolar Aynı");
            }
            
        }
    }
}
