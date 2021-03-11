using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        // naming convention
        //normal parantez görürseniz metotu ifade eder.
        

        // aşşağıdaki publicvoidekle'nin yanında belirtilen değişkenleri eklemek zorundayız.Bunun sebebi
        // program senin neyi eklemek istediğini bilmiyor buna sen karar veriyorsun.
        public void Ekle(urun urun)
        {
            Console.WriteLine(" Sepete eklendi :" + urun.Adı);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi,string lokasyon)

        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);

        }

        
        
     
    }
}
