using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "121212122";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1356656";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);







            //Gerçek-Tüzel olmak üzere iki nesne var
            //sırf birbirine benziyor, müşteri diye birbirleri yerine kullanılamazlar

        }
    }
}
