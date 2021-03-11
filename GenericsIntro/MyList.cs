using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T [] items;
        //constructor; aslında bir metotdur.Class'ı newlersen otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T Item)
        {


            T[] tempArray = items;
            items = new T[items.Length+1];
            //T'ye yeni eleman eklemek istediğimizde .length kullanırız.Length eleman sayısı demektir.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = Item;

        }

    }
}
