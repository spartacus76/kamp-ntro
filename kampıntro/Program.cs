using System;

namespace kampıntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //"kategoriEtiketi" değer tutucudur.

            string kategoriEtiketi = "kategori";
                
            int ogrenciSayisi = 3200;


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);

            // bool veri tipi; "doğru" ve "yanlış" olmak üzere iki değer alan veri tipidir.Uygulama içerisinde true yada false değer ataması yapılmaktadır.
            //kontrol işlemlerinde sık sık kullanılmaktadır.

            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");

            }
           
            else
            {

                Console.WriteLine("Giris yap butonu");


                //renkli yer "false" olsaydı ekrana "Giris yap butonu" basılırdı.

                
                //YENI ÖRNEK;
                
                
                bool condition = true;

                if (condition)
                {
                    Console.WriteLine("The variable is set to true.");
                }
                else
                {
                    Console.WriteLine("The variable is set to false.");
                }



                //if koşulu 

                double DolarDun = 7.40;
                double  DolarBugun = 7.45;

                if (DolarBugun<DolarDun)
                {
                    Console.WriteLine("azalış butonu");


                }

                else if (DolarBugun>DolarDun)
                {

                    Console.WriteLine("artış butonu");
                }

                else
                {

                    Console.WriteLine("Değişmedi butonu");
                }
 
















                



            }

        
           
        }
    }       
}
