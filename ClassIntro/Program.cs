using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            int a = 0;

            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Çağrı Civelek";
            kurs2.IzlenmeOrani = 70;

            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Alper Civelek";
            kurs3.IzlenmeOrani = 75;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " " + kurs.IzlenmeOrani);
            }

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

            // -----------------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            Urunler urun1 = new Urunler();
            Urunler urun2 = new Urunler();
            Urunler urun3 = new Urunler();
            Urunler urun4 = new Urunler();

            urun1.UrunAdi = "Cep Telefonu";
            urun1.UrunTur = "Teknoloji";
            urun1.UrunFiyat = 3000;

            urun2.UrunAdi = "Bilgisayar";
            urun2.UrunTur = "Teknoloji";
            urun2.UrunFiyat = 10000;

            urun3.UrunAdi = "Gömlek";
            urun3.UrunTur = "Giysi";
            urun3.UrunFiyat = 300;

            urun4.UrunAdi = "Takım Elbise";
            urun4.UrunTur = "Giysi";
            urun4.UrunFiyat = 2000;

            Urunler[] liste = new Urunler[] { urun1, urun2, urun3, urun4 };

            foreach (Urunler urun in liste)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunTur + " " + urun.UrunFiyat + " TL ");
            }

            Console.WriteLine();

            for (int i = 0; i < liste.Length; i++)
            {
                Console.WriteLine(liste[i].UrunAdi + " " + liste[i].UrunTur + " " + liste[i].UrunFiyat + " TL ");
            }

            Console.WriteLine();

            while (a < liste.Length)
            {

                Console.WriteLine(liste[a].UrunAdi + " " + liste[a].UrunTur + " " + liste[a].UrunFiyat + " TL ");
                a++;
            }

            Console.WriteLine();

            // -----------------------------------------------------------------------------------------------------------------------

            int sayi1 = 7;

            string durum = sayi1 == 0 ? "Doğru" : "Yanlış";

            Console.WriteLine(durum);

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }


    class Urunler
    {
        public string UrunAdi { get; set; }
        public string UrunTur { get; set; }
        public int UrunFiyat { get; set; }
    }
}
