using System;
using System.Collections.Generic;
using System.Linq;

namespace odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ödev no giriniz (1-4): ");
            int secenek = int.Parse(Console.ReadLine());

            odevler hangisi = new odevler();

            switch (secenek)
            {
                case 1:
                    hangisi.odev_1();
                    break;

                case 2:
                    hangisi.odev_2();
                    break;

                case 3:
                    hangisi.odev_3();
                    break;

                case 4:
                    hangisi.odev_4();
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }

        }
    }

    class odevler
    {
        public void odev_1()
        {
            try
            {
                Console.WriteLine("İstek 1: \n--------");
                Console.Write("Pozitif bir sayı giriniz: ");
                uint pozsayi = uint.Parse(Console.ReadLine());

                Console.WriteLine("\nİstek 2: \n--------");
                Console.Write("Aralarında boşluk vererek {0} adet Pozitif sayı giriniz: ", pozsayi);
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                if (arr.Count != pozsayi)
                    throw new ArgumentException();

                KontrolSinifi.kontrolodev1(arr);
            }

            catch (ArgumentException) // listede fazla sayı girilmiş
            {
                Console.WriteLine("Hata: Eksik yada Çok fazla veri adedi");
            }

            catch (FormatException) // boş veya string kontrol
            {
                Console.WriteLine("Veri tipi uygun değil");
            }

            catch (OverflowException) // negatif değer kontrol
            {
                Console.WriteLine("Pozitif bir sayı girmeniz gerekmektedir.");
            }

        }

        public void odev_2()
        {
            try
            {
                Console.WriteLine("İstek 1: \n--------");
                Console.Write("Pozitif birinci sayıyı giriniz: ");
                uint pozsayi1 = uint.Parse(Console.ReadLine());

                Console.Write("\nPozitif ikinci sayıyı giriniz: ");
                uint pozsayi2 = uint.Parse(Console.ReadLine());

                Console.WriteLine("\nİstek 2: \n--------");
                Console.Write("Aralarında boşluk vererek {0} adet Pozitif sayı giriniz: ", pozsayi1);
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                if (arr.Count != pozsayi1)
                    throw new ArgumentException();

                KontrolSinifi.kontrolodev2(arr, pozsayi2);
            }

            catch (ArgumentException) // listede fazla sayı girilmiş
            {
                Console.WriteLine("Hata: Eksik yada Çok fazla veri adedi");
            }

            catch (FormatException) // boş veya string kontrol
            {
                Console.WriteLine("Veri tipi uygun değil");
            }

            catch (OverflowException) // negatif değer kontrol
            {
                Console.WriteLine("Pozitif bir sayı girmeniz gerekmektedir.");
            }
        }

        public void odev_3()
        {
            try
            {
                Console.WriteLine("İstek 1: \n--------");
                Console.Write("Pozitif bir sayı giriniz: ");
                uint pozsayi = uint.Parse(Console.ReadLine());

                Console.WriteLine("\nİstek 2: \n--------");
                Console.WriteLine("Sırayla {0} adet kelime giriniz: ", pozsayi);

                string[] kelimeler = new string[pozsayi];

                for (int i = 0; i < pozsayi; i++)
                {
                    Console.WriteLine("{0}. kelimeyi girin: ",i+1);
                    kelimeler[i] = Console.ReadLine();
                }
                Console.WriteLine("\n");
                KontrolSinifi.kontrolodev3(kelimeler);
            }

            catch (ArgumentException) // listede fazla sayı girilmiş
            {
                Console.WriteLine("Hata: Eksik yada Çok fazla veri adedi");
            }

            catch (FormatException) // boş veya string kontrol
            {
                Console.WriteLine("Veri tipi uygun değil");
            }

            catch (OverflowException) // negatif değer kontrol
            {
                Console.WriteLine("Pozitif bir sayı girmeniz gerekmektedir.");
            }
        }

        public void odev_4()
        {
            try
            {
                Console.WriteLine("İstek 1: \n--------");
                Console.Write("Bir cümle yazınız: ");
                string cumle = Console.ReadLine();

                KontrolSinifi.kontrolodev4(cumle);
            }

            catch (ArgumentException) // listede fazla sayı girilmiş
            {
                Console.WriteLine("Hata: Eksik yada Çok fazla veri adedi");
            }

            catch (FormatException) // boş veya string kontrol
            {
                Console.WriteLine("Veri tipi uygun değil");
            }

            catch (OverflowException) // negatif değer kontrol
            {
                Console.WriteLine("Pozitif bir sayı girmeniz gerekmektedir.");
            }
        }

    }

    class KontrolSinifi
    {
        public static void kontrolodev1(List<int> arr)
        {
            foreach (var liste in arr)
            {
                if (liste % 2 == 0)
                    Console.WriteLine(liste);
            }
        }

        public static void kontrolodev2(List<int> arr, uint pozsayi2)
        {
            foreach (var liste in arr)
            {
                if (liste % pozsayi2 == 0)
                    Console.WriteLine(liste);
            }
        }

        public static void kontrolodev3(string[] param)
        {
            Array.Reverse(param);
            foreach (var item in param)
            {
                Console.Write(item + " , ");
            }
        }

        public static void kontrolodev4(string param)
        {
            string[] arr = param.Split(' ');
            int toplamharf=0;

            foreach (var item in arr)
            {
                // Console.WriteLine(item);
                toplamharf +=item.Length;
            }

            Console.WriteLine("Cümledeki toplam kelime sayısı: "+arr.Length);
            Console.WriteLine("Cümledeki toplam harf sayısı: "+toplamharf);
        }
    }
}

