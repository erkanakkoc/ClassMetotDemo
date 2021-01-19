using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID : " + musteri.Id);
            Console.WriteLine("Müşteri Ad Soyad : " + musteri.AdSoyad);
            Console.WriteLine("Müşteri Doğum Yılı : " + musteri.DogumYili);
            Console.WriteLine("Müşteri Kart Numarası : " + musteri.KartNo);
        }
        public void MusteriEkle()
        {
            int mId;
            string aS;
            int dY;
            string kN;

            Console.WriteLine("Kullanıcı ID girin : ");
            mId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kullanıcı Ad Soyad girin : ");
            aS = Console.ReadLine();
            Console.WriteLine("Kullanıcı Doğum Yılı girin : ");
            dY = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kullanıcı Kart No girin : ");
            kN = Console.ReadLine();
            Console.WriteLine("Müşteri Ekledi ! \nID = {0}\nAd Soyad {1}\nDoğum Yılı = {2}\nKart No = {3}", mId, aS, dY, kN);
        }

        public void MusteriSil()
        {
            Console.WriteLine("Silinecek Müşteri ID : ");
            string girID = Console.ReadLine();
            Console.WriteLine(girID + " = ID sahibi müşteri silindi");
        }
    }
}