using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "ömer";
            int yas = 33;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "c";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "j";
            kurs2.Egitmen = "ali";
            kurs2.IzlenmeOranı = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "p";
            kurs3.Egitmen = "ahmet";
            kurs3.IzlenmeOranı = 85;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "react";
            kurs4.Egitmen = "halil";
            kurs4.IzlenmeOranı = 95;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };  
            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public  int IzlenmeOranı { get; set; }
    }
}
