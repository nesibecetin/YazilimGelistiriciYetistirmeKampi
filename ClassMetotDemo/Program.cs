using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = Menu();
            }
        }
        static bool Menu()
        {
            Musteri musteri = new Musteri();
            musteri.MusteriId = 1;
            musteri.Ad = "Nesibe";
            musteri.Soyad = "Çetin";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.Ad = "Büşra";
            musteri2.Soyad = "Pekuslu";

            Musteri[] musteriler = new Musteri[] { musteri, musteri2 };

            Console.WriteLine("Bir seçenek seçin");
            Console.WriteLine("1-Müşteri Ekle");
            Console.WriteLine("2-Müşteri Sil");
            Console.WriteLine("3-Müşteri Listele");
            Console.WriteLine("Bir seçenek seçin:");
            var sonuc=Console.ReadLine();
            MusteriManager musteriManager = new MusteriManager();
            if(sonuc=="1")
            {
                musteriManager.Add(musteri);
                return true;
            }
            else if (sonuc == "2")
            {
                musteriManager.Delete(musteri2);
                return true;
            }
            else if (sonuc == "3")
            {
                musteriManager.List(musteriler);
                return true;
            }
            else
            {
                Console.WriteLine("Böyle bir işlem yok");
                return true;
            }
           
              
        }
    }
}
