using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Kırmızı Elma";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            //urun1.Id = 1;
            urun1.UrunAdi = "Karpuz";
            urun1.Aciklama = "Diyarbakır";
            urun1.Fiyati = 15;
            urun1.StokAdedi = 25;


            Urun urun2 = new Urun();
            //urun2.Id = 2;
            urun2.UrunAdi = "Muz";
            urun2.Aciklama = "Alanya";
            urun2.Fiyati = 9;
            urun2.StokAdedi = 325;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Elma";
            urun3.Aciklama = "Amasya";
            urun3.Fiyati = 18;
            urun3.StokAdedi = 265;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati + ",00 TL");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("Stokda " + urun.StokAdedi + " Adet Var");
                Console.WriteLine("/////////////////////");
            }

            Console.WriteLine("-------------Metotlar-------------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun3);

            //Ekle2 metodu kullanma. problemli.
            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 100);
            




            Console.ReadKey();
        }
    }
}
