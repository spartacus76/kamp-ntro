using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics yapısında hangi veri tipiyle çalıştığını belirtmek zorundasın.

            MyList<string> isimler = new MyList <string>();
            isimler.Add("Hozan");

            List<string> liste = new list<string>();
            Console.WriteLine(liste.count);


            
        }
    }
}
