using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;


            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Emre Yaprakci";
            kurs1.IzlenmeOrani = 72;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Pyhton";
            kurs2.Egitmen = "Apoş Yaprakci";
            kurs2.IzlenmeOrani = 63;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Esra Yaprakci";
            kurs3.IzlenmeOrani = 45;

            // Console.WriteLine(kurs1.KursAdi+ " "+ kurs1.Egitmen);
            // kurs arrayin içinde doğrudan kurs(egitmen, izlenme oranı, kurs adi) tutuyoruz.
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
                
            }

            Console.ReadLine();
        }
    }
    //klas tanımlama >> int , string gibi tip tanımlıyoruz. Kurs tipinin ne tuttugunu belirtip
    //yukarda getirdik.
    public class Kurs
    {// stoklarda ürün tanımı için klass yaz
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}