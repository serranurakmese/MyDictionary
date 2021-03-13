using System;

namespace odev5dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> names = new MyDictionary<string,string>();
            names.Add("1","Engin");

            Console.WriteLine(names.Length);
         

            names.Add("2","Kerem");

            Console.WriteLine(names.Length);
           
            //new bellekte referans oluştur demek. örnek oluştur.
        }
    }
}
