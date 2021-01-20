using System;

namespace KampInto1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
