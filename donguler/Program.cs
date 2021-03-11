using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donguler adından da anlaşılacağı gibi bir süreçtir."int"veri tipini kullanarak rakam aralıkları belirleriz
            // ve belirlenen rakamlar arasından çıkmadığı sürece döngü sorunsuz çalışır.
            //aşağıdaki döngü 1'den başlar 9'a kadar devam eder.


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(i);
            }

            //Aşağıdaki yeni örnekte 0 ile 20 sayısı arasındaki çift sayilari ekranda gösterir.


            for (int i = 0; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }


            //Array-Dizi

            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            Console.WriteLine (kurs1);
            Console.WriteLine (kurs2);
            Console.WriteLine (kurs3);
            
            
            //yukarıda görüldüğü gibi değişkenleri tek tek yazmak zorundasınız fakat arrayleri kullanarak 
            //daha pratik ve clean code yazabiliyoruz.



            //arraylerde bütün değişkenleri tek bir yerde toplamak mümkündür.


            string[] kurslar = new string[] { "Yazilim Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs" };


            // dizileri döngülerle beraber kullanmakta mümkün.

            
            string [] Kurslar = new string[] { "Galatasaray", "Beşiktaş", "Galatasaray" };

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(Kurslar[i]);
            }
            
            Console.WriteLine("Sayfa sonu");

            
            
            //NOT;İLAVE OLARAK BİR DATA DAHA EKLEMEK İSTEDİĞİNDE;

            string[] kurs= new string[] { "Galatasaray", "Beşiktaş", "Fenerbahçe", "Başakşehir" };


            for (int i = 0; i < Kurslar.Length; i++)

            {
                Console.WriteLine(Kurslar[i]);

            }

            // Length eleman sayısı demektir. 


            
            
            //FOREACH;dizi temelli yapıları tek tek dönmeye yarar.
            //SYNTAX aşağıdaki gibidir;

            //foreach (var item in collection)
            {

            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);


            }
            Console.WriteLine("For bitti");



            foreach (string Kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
                Console.WriteLine("sayfa sonu");

            //NOT:YUKARIDAKİ İKİ İŞLEMDE AYNIDIR.


            string[] isimler = { "Barış", "Deniz", "İrem", "Ezgi" };

              foreach (string eleman in isimler)

            {
                Console.WriteLine(eleman);

            }

             



           











        }
    }
}
