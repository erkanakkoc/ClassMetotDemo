using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Emre Demir";
            musteri1.DogumYili = 1999;
            musteri1.KartNo = "12345";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Bilinmeyen Kişi";
            musteri2.DogumYili = 1998;
            musteri2.KartNo = "54321";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("İşlem Seçiniz" + "\n1 - Müşterileri Listele \n2 - Müşteri Ekle \n3 - Müşteri Sil\n4 - Çıkış");
            int secim = Convert.ToInt16(Console.ReadLine());

            if (secim == 1)
            {
                foreach (var musteri in musteriler)
                {
                    musteriManager.MusteriListele(musteri);
                }
            }

            else if (secim == 2)
            {
                musteriManager.MusteriEkle();
            }
            else if (secim == 3)
            {
                musteriManager.MusteriSil();
            }
            else
            {
                if (secim == 4)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                }
            }
        }
    }
}