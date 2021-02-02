using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" " + musteri.Soyad);
            Console.WriteLine("Müşteri Eklendi.\n");

        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+ " " + musteri.Soyad);
            Console.WriteLine("Müşteri Silindi.\n");
        }
        public void List(Musteri [] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].Ad+ " " + musteriler[i].Soyad);
            }

        }
        

    }
}
