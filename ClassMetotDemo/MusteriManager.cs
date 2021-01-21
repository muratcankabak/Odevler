using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public Musteri[] MusterileriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }
            return musteriler;
        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " isimli müşteri eklendi");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " isimli müşteri silindi.");
        }
    }
}
