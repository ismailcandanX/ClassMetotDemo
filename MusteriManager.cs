using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Bankamızdaki mÜşterilerimizden : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadı);
        }
        public void MusteriEkle(string MusteriAdi, string MusteriSoyadi, string MusteriTcNo)
        {
            Console.WriteLine("Sayın :" +MusteriAdi + " "+ MusteriSoyadi + "Aramıza Hoşgeldiniz." );
        }
        public void MusteriSil(string MusteriAdi, string MusteriSoyadi, string MusteriTcNo)
        {
            Console.WriteLine(MusteriAdi + " " +MusteriSoyadi + " aramızdan ayrıldı.");
        }
    }
}
