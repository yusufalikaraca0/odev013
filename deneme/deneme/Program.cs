using System;

namespace deneme
{
    class Program
    {
        class ogr
        {
            public string numara;
            public void yazdir() { Console.WriteLine(numara); }
        }
        class islemturleri
        {
            object tumturler = new object();
        }
        static void Main(string[] args)
        {
            ogr deneme = new ogr();
            deneme.numara = "jıffjasd";
            deneme.yazdir();
        }
    }
}
