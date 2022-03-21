using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1 den başlayarak consol dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("Lütfen bir sayı girin");
            double sayi = double.Parse(Console.ReadLine());
            int sayac=1;
            double toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri consola a yazdır.
            char character='a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine();
            Console.WriteLine("***** foreach *****");
            string[]arabalar={"BWM","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
