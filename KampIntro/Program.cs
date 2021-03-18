using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety - Tip Güvenliği

            // Do not repeat yourself

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolatBugun = 7.45;

            if (dolarDun > dolatBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun < dolatBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
