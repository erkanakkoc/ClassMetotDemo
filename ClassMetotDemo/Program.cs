using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Test1";
            musteri1.Soyad = "Deneme1";
            musteri1.Tel = "123456789";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Test2";
            musteri2.Soyad = "Deneme2";
            musteri2.Tel = "987654321";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Test3";
            musteri3.Soyad = "Deneme3";
            musteri3.Tel = "123987456";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id);
            //    Console.WriteLine(musteri.Ad);
            //    Console.WriteLine(musteri.Soyad);
            //    Console.WriteLine(musteri.Tel);
            //    Console.WriteLine("-------------");
            //}


            Console.WriteLine("----------Müşteri Yönetim Sistemine Hoşgeldiniz----------");
            MusteriManager musteriManager = new MusteriManager();
            SecimEkrani:
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1-Ekle / 2-Sil / 3-Listele");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    musteriManager.Ekle(musteri1, musteri2, musteri3);
                    Console.WriteLine("Başka bir işlem yapmak istiyor musunuz?(Evet için 1'e basınız)");
                    secim = Convert.ToInt32(Console.ReadLine());
                    if(secim == 1)
                    {
                        goto SecimEkrani;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler Dileriz");
                        break;
                    }
                case 2:
                    musteriManager.Sil(musteri3);
                    Console.WriteLine("Başka bir işlem yapmak istiyor musunuz?(Evet için 1'e basınız)");
                    secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        goto SecimEkrani;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler Dileriz");
                        break;
                    }
                case 3:
                    musteriManager.Listele(musteri1, musteri2, musteri3);
                    Console.WriteLine("Başka bir işlem yapmak istiyor musunuz?(Evet için 1'e basınız)");
                    secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        goto SecimEkrani;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler Dileriz");
                        break;
                    }
            }


        }
    }
}
