using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManagement musteriManagement = new MusteriManagement();
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Ümmühan";
            musteri1.soyad = "Kurt";
            musteriManagement.MusteriEkle(musteri1);
            musteriManagement.MusteriListele(musteri1);
            musteriManagement.MusteriSil(musteri1);
        }
        public class Musteri
        {
            public int id { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
        }

        public class MusteriManagement
        {
            public void MusteriEkle(Musteri musteriEkle)
            {
                Console.WriteLine("Musteri sisteme eklenmistir." + " id : " + musteriEkle.id +" Ad : " + musteriEkle.ad + "Soyad : "+ musteriEkle.soyad);
            }
            public void MusteriListele(Musteri musteriListele)
            {
                Console.WriteLine("Museri listelenmiştir" + " id :" +musteriListele.id +" Ad : "+ musteriListele.ad +"Soyad : "+ musteriListele.soyad);
            }
            public void MusteriSil(Musteri musteriSil)
            {
                Console.WriteLine("Müşteri sistemden silinmiştir." + " id : " +musteriSil.id +" Ad : " +musteriSil.ad + "Soyad : " +musteriSil.soyad);
            }
        }
       
    }
    

}
