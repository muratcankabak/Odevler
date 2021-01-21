using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[]
            {
                new Musteri{MusteriId = 1, MusteriAdi = "Peyami", MusteriSoyadi = "Safa"},
                new Musteri{MusteriId = 2, MusteriAdi = "Cengiz", MusteriSoyadi = "Aytmatov"},
                new Musteri{MusteriId = 3, MusteriAdi = "Oğuz", MusteriSoyadi = "Atay"},
                new Musteri{MusteriId = 4, MusteriAdi = "Sabahattin", MusteriSoyadi = "Ali"}
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusterileriListele(musteriler);
            musteriManager.Add(new Musteri { MusteriId = 5, MusteriAdi = "Yusuf", MusteriSoyadi = "Atılgan" });
            musteriManager.Delete(new Musteri { MusteriId = 6, MusteriAdi = "Cahit Sıtkı", MusteriSoyadi = "Tarancı" });
        }
    }
}
