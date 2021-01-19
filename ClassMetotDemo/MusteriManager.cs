using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri, Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("Kaç Müşteri Eklenecek");
            int ekleAdet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ekleAdet; i++)
            {
                musteri.Id = i;
                Console.WriteLine(i + ". Müşterinin Adını Giriniz");
                musteri.Ad = Console.ReadLine();
                Console.WriteLine(i + ". Müşterinin Soyadını Giriniz");
                musteri.Soyad = Console.ReadLine();
                Console.WriteLine(i + ". Müşterinin Telefon Numarasını Giriniz");
                musteri.Tel = Console.ReadLine();
                Console.WriteLine(i + ". Müşteri Eklendi");
                Console.WriteLine("ID: " + musteri.Id + " - Ad: " + musteri.Ad + " - Soyad: " + musteri.Soyad + " - Tel: " + musteri.Tel);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
            
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }
        public void Listele(Musteri musteri, Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("Müşterinin - ID: " + musteri.Id + " - Ad: " + musteri.Ad + " - Soyad: " + musteri.Soyad + " - Tel: " + musteri.Tel);
            Console.WriteLine("Müşterinin - ID: " + musteri1.Id + " - Ad: " + musteri1.Ad + " - Soyad: " + musteri1.Soyad + " - Tel: " + musteri1.Tel);
            Console.WriteLine("Müşterinin - ID: " + musteri2.Id + " - Ad: " + musteri2.Ad + " - Soyad: " + musteri2.Soyad + " - Tel: " + musteri2.Tel);

        }
    }
}
