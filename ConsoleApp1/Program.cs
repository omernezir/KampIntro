using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "masa";
            urun1.UrunAciklamasi = "özel tasarım";
            urun1.UrunFiyati = 320;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "masa lambası";
            urun2.UrunAciklamasi = "pilli";
            urun2.UrunFiyati = 50;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "koltuk";
            urun3.UrunAciklamasi = "tek kişilik";
            urun3.UrunFiyati = 500;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + "\t" + urunler[i].UrunAciklamasi + "\t" + urunler[i].UrunFiyati + "\n");
            }

            Console.WriteLine("for bitti, foreach başladı");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + "\t" + urun.UrunAciklamasi + "\t" + urun.UrunFiyati + "\n");
            }

            Console.WriteLine("foreach bitti, while başladı");
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + "\t" + urunler[a].UrunAciklamasi + "\t" + urunler[a].UrunFiyati + "\n");
                a++;
            }

        }


        class Urun
        {
            public string UrunAdi { get; set; }
            public string UrunAciklamasi { get; set; }
            public int UrunFiyati { get; set; }
        }
    }
}

