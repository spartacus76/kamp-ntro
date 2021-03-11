using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //aşşağıdaki işlemlerde değişkeni oluşturmak ve değer atama yapılır.
           

            Kurs kurs1 = new Kurs();
            

            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeorani = 68;
            
            Kurs kurs2 = new Kurs();


            kurs2.Kursadi = "C";
            kurs2.Egitmen = "Barış Demiroğ";
            kurs2.İzlenmeorani = 98;


            //Console.WriteLine(kurs1.Kursadi + "" + kurs1.Egitmen + "" + kurs1.İzlenmeorani);

            //Diyelim ki elimizdeki verilerden sadece birini bastırmak istiyorum örneğin eğitim verisini,bu veriyi aşşağıdaki gibi kodlarız.

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.Egitmen + ":" + kurs.Kursadi);
            }

            // Bilindiği gibi foreach sadece dizileri tek tek basar. 

        }
    }
     //Aşşağıdaki işlemlerde class tanımlanır.
    class Kurs
    {
        public string Kursadi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeorani { get; set; }
         
    }

    // arraylerde verileri; string [] kurslar = new string [] {}   şeklinde tutarız yani sadece stringler tutulur 
    // classlarda ise ;     kurs   [] kurslar = new kurslar[] {}   şeklinde tutarız değişken kurslar olarak belirlediğimiz için hepsini tutar.

    
   







}
