using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety - c# ve java bu konuda çok sağlam
            // bool, javada boolean

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
       
                    
            }
            // if iki tab direkt blokları açıyor

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
