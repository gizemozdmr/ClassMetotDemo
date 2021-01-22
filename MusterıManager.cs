using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusterıManager
    {
        //naming convention
        public void Ekle(Musterı musterı)
        {
            Console.WriteLine("Teşekkürler. Kaydınız Alınmıştır! : " + musterı.Adi );
        }

        public void Ekle2(string Adi, double Yas, string TcNo, string Telefon)
        {
            Console.WriteLine("Teşekkürler. Kaydınız Alınmıştır! : " + Adi);
        }

        public void Sil(Musterı musterı)
        {
            Console.WriteLine("Kaydınız Silinmiştir! : " + musterı.Adi);
        }

        public void Sil2(string Adi, double Yas, string TcNo, string Telefon)
        {
            Console.WriteLine("Kaydınız Silinmiştir! : " + Adi);
        }

        public void Listele(Musterı musterı)
        {
            Console.WriteLine("Adı : " + musterı.Adi);
            Console.WriteLine("Yaş : " + musterı.Yas);
            Console.WriteLine("TcNo : " + musterı.TcNo);
            Console.WriteLine("Telefon : " + musterı.Telefon);
        }


    }
}
