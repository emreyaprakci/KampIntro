using System;
using System.Collections.Generic;
using System.Text;


namespace Metotlar
{
    public class SepetManager
    {
        //naming concention
        // BU BİR METODDUR >>> FONKSİYONDUR..
        public void Ekle(Urun urun)
        {
            Console.WriteLine("SEPETE EKLENDİ : "+ urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("SEPETE EKLENDİ : " + urunAdi);
        } 
    }
}
