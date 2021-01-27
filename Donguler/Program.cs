using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Kurs1";
            string kurs2 = "Kurs2";
            string kurs3 = "Kurs3";

            string[] kurslar = new string[] {"Kurs1","Kurs2","Kurs3" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
