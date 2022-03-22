using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[]sayidizisi={23,38,96,16,74,25,44,69};

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*** Sıralanmış Dizi ***");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayidizisi,2,2);
            // sayı Dizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı sıfırlar
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayidizisi,23));
  
            // Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayidizisi,9);
            sayidizisi[8]=99;
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}
