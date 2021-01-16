using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            //Urun class ı yerine var yazabiliriz. var gidip veri tipini buluyor
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...................");
            }

            Console.WriteLine("........................");

            SepetManager sepetManager = new SepetManager();
            //encapsulation: metodları sınıflarla yaz. bir değişiklik olduğu zaman sınıfı değiştir.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Karpuz", "diyarbakır karpuz", 12, 8);
            sepetManager.Ekle2("Elma", "yeşil elma", 12, 9);












        }
    }
}

//do not repeat yourself!!! : DRY - Clean Code
