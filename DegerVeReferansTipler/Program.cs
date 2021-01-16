using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int, decimal, float, double, bool vb sayısal değerler değer tipi
            // array, class, interface referans tip
            //bellekte stack ve heap isimli iki bellek var.
            //değer tipler sadece stack bellekte tutuluyor.
            //sayi1= 10 yazıldığında; sayi1 in değeri 10 diye okunur.
            //sayi1= sayi2 dediğinde sayi2nin değerini alır. sadece değeri alır!!
            // int[] sayilar yazdığımızda stackte sayilar1 açar
            // = new.... yazdığında heap tarafında diziyi açar.
            //new ile heap açıp adresle stack ve heap bağlanıyor.
            //sayilar1[]=sayilar2[] dediğinde adresi atıyorsun. 
            //yani sayilar1 in referans numarası değişiyor.
            //heap tarafındaki bir dizi stack tarafında tutulmuyorsa
            //mesela sayilar2 adresi sayilar1e atsandığında
            //sayilar1in ilk dizisi heapte hiçbir yerde stack tarafında yok
            //garbage collector ile temizleniyor bu tip durumlar

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 60;


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

        }
    }
}
