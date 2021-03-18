using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Phyton Kursu";

            //  Array - Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java Kursu",
                "Phyton Kursu",
                "C# Kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("İlk döngü bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
