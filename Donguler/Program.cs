using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array >> diziler
            // tek tek kurs1, kurs2 ... tanımlamak yerine arraylerde tek seferde tanımlama yapılır.
            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı", "Programlamaya Giriş", "Java","Python" };

            // Console.WriteLine(kurslar[1]);

            // donguler ekrana birden fazla nesne eklemek için var
            // i nin max değerini doğrudan vermek yerine kursların eleman sayısına bağlanır. kurslar.Lenght >> bu saytede yeni kurs eklendiğinde
            // işlem yapılması gerekmez.
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for sonu");
            //dizi temelli yapıları döngüye almaya yarar kurslar >> arraysin adı >> kurs ise kendi verdiğmiz rastgele isim.
            // for döngüsü yerine arrayler için foreach daha kolay. kendi i kadar sayıyor.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");





            Console.ReadLine();
        }
    }
}
