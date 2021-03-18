using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 70;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 25;

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("-----------------Metotlar-----------------");

            // Instance
            // Encapsulation

            SepetManager sepetManeger = new SepetManager();

            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManeger.Ekle2("Karpuz", "Diyarbakır Karpuz", 12);


        }
    }
}

// Dont repeat yourself - DRY - Clean Code - Best Practice