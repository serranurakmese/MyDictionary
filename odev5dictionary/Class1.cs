using System;
using System.Collections.Generic;
using System.Text;

namespace odev5dictionary
{
    class MyDictionary <I,S>
    {
        S[] items;
        I[] items2;
       

        public MyDictionary()
        {
            items = new S[0];
            items2 = new I[0];
            
        }

        public void Add(S item, I item2)
        {
            S[] tempArray = items; //geçici dizinin referansı burada tutuluyor.
            I[] tempArray2 = items2;
            items = new S[items.Length + 1];
            items2 = new I[items2.Length + 1];
            //yeni ref oluşturunca adres uçmasın
            //diye tempArray var.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                items2[i] = tempArray2[i];
            }

            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;
        }
        public int Length
        {
            get { return items.Length; }
            
        }

    }
}
