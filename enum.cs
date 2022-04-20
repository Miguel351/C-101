using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin");
            }
            else if (sicaklik >= (int)HavaDurumu.sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (sicaklik >= (int)HavaDurumu.normal && sicaklik < (int)HavaDurumu.cokSicak)
                Console.WriteLine("Haydi dışarıya çıkalım!");
        }
    }

    enum Gunler
    {
        //Pazartesi=1, şeklinde de alternatif kullanımı var
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sicak = 25,
        cokSicak = 35
    }
}
