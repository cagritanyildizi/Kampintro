using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.UrunAdi = "Telefon";
            urun1.Marka = "Xiaomi";
            urun1.SatisOrani = 68;

            Product urun2 = new Product();
            urun2.UrunAdi = "Araba";
            urun2.Marka = "Opel Insigna";
            urun2.SatisOrani = 95;

            Product urun3 = new Product();
            urun3.UrunAdi = "Buzdolabi";
            urun3.Marka = "Siemens";
            urun3.SatisOrani = 80;


            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.Marka + " " + urun.SatisOrani);
            }
        }

    }
    class Product
        {
            public string UrunAdi { get; set; }

            public string Marka { get; set; }

            public int SatisOrani { get; set; }
        }





        /* Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOrani = 80;

        //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen); bu şekilde yazılabilir.

        Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " " + kurs.IzlenmeOrani);
        }

    }
}

class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int IzlenmeOrani { get; set; }
}*/
    } 
