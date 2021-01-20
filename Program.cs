using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111111;
            musteri1.MusteriAdi = "Şeyhmus";
            musteri1.MusteriSoyadı = "Atlı";
            musteri1.MusteriTcNo = "12345678901";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 111112;
            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyadı = "Ersoy";
            musteri2.MusteriTcNo = "12345678902";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 111113;
            musteri3.MusteriAdi = "Fahri";
            musteri3.MusteriSoyadı = "Parlak";
            musteri3.MusteriTcNo = "12345678903";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 111114;
            musteri4.MusteriAdi = "Özge";
            musteri4.MusteriSoyadı = "Özel";
            musteri4.MusteriTcNo = "12345678904";

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3,musteri4
            };

            foreach(var musteri in musteriler)
            {
                Console.WriteLine("Bankamızdaki Müşterilerimiz : " + musteri.MusteriAdi+ " " +musteri.MusteriSoyadı);
            }

            Console.WriteLine("----------------------------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriEkle("Aysel", "Günay", "1111112222555");
            musteriManager.MusteriSil("Şeyhmus","Atlı","123456789011");


        }
    }
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadı { get; set; }
        public string MusteriTcNo { get; set; }

    }
}
