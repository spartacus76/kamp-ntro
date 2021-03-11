using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // string urunAdi = "Apple";
            //double fiyati = 1500;
            //string aciklamasi = "technology of future"; 



            //string[] teknoloji = new string[] { "apple", "huawei" }; BU OLMAK ZORUNDA DEĞİL

           

            urun urun1 = new urun();
            urun1.Adı = "Apple";
            urun1.Fiyati = 1500;
            urun1.Aciklama= "technology of future";

            urun urun2 = new urun();
            urun2.Adı = "Huawei";
            urun2.Fiyati = 1000;
            urun2.Aciklama = "Technology is rising";

            urun urun3 = new urun();
            urun3.Adı = "Samsung";
            urun3.Fiyati = 800;
            urun3.Aciklama = "New technology New Create";



            urun[] urunler = new urun[] { urun1, urun2, urun3 };




            //type safe - - tip güvenliği


            foreach (urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }


            Console.WriteLine("-------------------METOTLAR-------------");
            
            //instance-örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Samsung S10", "NEW SERİES", 750 , 25, "Kartal");
            sepetmanager.Ekle2("XİAOMİ", "REDMİ", 600 , 25, "Maltepe");
            sepetmanager.Ekle2("LG", "LG G5", 350, 23, "Beşiktaş");

            //yukarıda urunadi, aciklamasi , fiyati ve stok adedi görülmektedir.




        }


        public string Id { get; set; }
        public string Adı { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }


    }


 
}


//dont repeat yourself
