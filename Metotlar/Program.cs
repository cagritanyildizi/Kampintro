﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";
           string[] meyveler = new string[]{};*/

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");


            }

            
            
            
            Console.WriteLine("---------METOTLAR--------");

            //instance - class örneği
            
            //encapsulation

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut","Yeşil armut",12, 100);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 100);
            sepetmanager.Ekle2("Elma", "Amasya Elması", 12, 500);
        }
    }
}
//Don't Repeat Yourself - DRY