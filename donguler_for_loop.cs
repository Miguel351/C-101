using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac=int.Parse(Console.ReadLine());

            for (int i = 1; i <=sayac; i++)
            {
                // komutlar
                if(i%2==1){
                    Console.WriteLine(i);
                }

            }

            Console.Write("Lütfen bir sayı giriniz:");
            int sayac2=int.Parse(Console.ReadLine());
            int teksayilar=0;
            int ciftsayilar=0;

            for (int i = 1; i <= sayac2; i++)
            {
                if(i%2==1){
                    teksayilar +=i;
                } else {
                    ciftsayilar +=i;
                }
            }

            Console.WriteLine("tek sayılar toplamı: "+ teksayilar);
            Console.WriteLine("çift sayılar toplamı: "+ ciftsayilar);

            // break 
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }

            // continue
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            }
        }
    }
}
