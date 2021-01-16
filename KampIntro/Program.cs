using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {    // değişken tanımlama sürekli olacak. Değişiklik olacağı zaman bir değiştirmek için.   
            string kategoriEtiketi = "Kategori";
            string egitmenEtiketi = "Eğitmen";

            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; // burada true yazılmaz sistemde. bi fonksiyon yapılır o kontrol eder. giriş yapılıp yapılmadığını
            // misal bool sistemeGirisYapmisMi = girisKontrol >> fonksiyon
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            // üç durumlu şart
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            // iki durumlu şart
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            
 
            Console.ReadLine();
        }
    }
}
