using System;

namespace odev5dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> names = new MyDictionary<int,string>();
            names.Add("1","Serra");

            Console.WriteLine(names.Length);
         

            names.Add("2","Nur");

            Console.WriteLine(names.Length);
           
            //new bellekte referans oluştur demek. örnek oluştur.
        }
    }
}
