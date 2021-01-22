using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gizem";
            string soyAdi = "Özdemir";
            double yas = 28;
            string tcNo = "11111111111";
            string telefon = "0555 555 55 55";


            Musterı musterı1 = new Musterı();
            musterı1.Adi = "Gizem Özdemir";
            musterı1.Yas = 28;
            musterı1.TcNo = "11111111111";
            musterı1.Telefon = "0555 555 55 55";

            Musterı musterı2 = new Musterı();
            musterı2.Adi = "Eren Özdemir";
            musterı2.Yas = 27;
            musterı2.TcNo = "22222222222";
            musterı2.Telefon = "0555 555 55 55";

            Musterı[] musterıler = new Musterı[] {musterı1, musterı2 };

            foreach (Musterı musterı in musterıler)
            {
                Console.WriteLine(musterı.Adi); 
                Console.WriteLine(musterı.Yas);
                Console.WriteLine(musterı.TcNo);
                Console.WriteLine(musterı.Telefon);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------Metotlar---------------");

            //Yeni müşteri ekleme metodu
            MusterıManager musterıManager = new MusterıManager();
            musterıManager.Ekle(musterı1);
            musterıManager.Ekle(musterı2);

            Console.WriteLine("-------------------Ekle Bitti--------------------");

            //Yeni müşteri ekleme metodu: uzun işlem
            musterıManager.Ekle2("Gizem Özdemir", 28, "11111111111", "0555 555 55 55");
            musterıManager.Ekle2("Eren Özdemir", 27, "22222222222", "0555 555 55 55");
            musterıManager.Ekle2("Gülcan Akın", 45, "33333333333", "0555 555 55 55");

            Console.WriteLine("-------------------Ekle2 Bitti--------------------");

            //Müşteri silme metodu
            musterıManager.Sil(musterı1);
            musterıManager.Sil(musterı2);

            Console.WriteLine("-------------------Sil Bitti--------------------");

            //Müşteri silme metodu: uzun işlem
            musterıManager.Sil2("Gizem Özdemir", 28, "11111111111", "0555 555 55 55");
            musterıManager.Sil2("Eren Özdemir", 27, "22222222222", "0555 555 55 55");
            musterıManager.Sil2("Gülcan Akın", 45, "33333333333", "0555 555 55 55");

            Console.WriteLine("-------------------Sil2 Bitti--------------------");


            //Müşteri isimlerini listeleme metodu
            musterıManager.Listele(musterı1);
            musterıManager.Listele(musterı2);

            Console.WriteLine("-------------------Listele Bitti--------------------");

            
            //Müşterilerin tüm bilgilerini listeleme metodu ( Adı, Yaşı, TcNo, Telefon)
            
            
        }
    }
}
