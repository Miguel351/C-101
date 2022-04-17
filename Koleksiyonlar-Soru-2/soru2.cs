using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yirmi adet pozitif sayı giriniz: ");
                int tur = 1;
                uint pozsayi = 0;
                ArrayList asal = new ArrayList();

                while (tur <= 5)
                {
                    //Console.WriteLine("{0}.sayı? ", tur);
                    pozsayi = uint.Parse(Console.ReadLine());
                    asal.Add(pozsayi);
                    tur++;
                }

                Console.Write("Girilen sayıların karışık listesi: ");
                foreach (var item in asal)
                {
                    Console.Write(item + " ");
                }

                kontrol.enbuyukenkucukbul(asal);

            }

            catch (ArgumentException) // listede fazla sayı girilmiş
            {
                Console.WriteLine("Hata: Eksik yada Çok fazla veri adedi");
            }
            catch (FormatException) // boş veya string kontrol
            {
                Console.WriteLine("Girilen değer nümerik olmalıdır.");
            }
            catch (OverflowException) // negatif değer kontrol
            {
                Console.WriteLine("Pozitif bir sayı girmeniz gerekmektedir.");
            }
        }
    }

    class kontrol
    {
        public static void enbuyukenkucukbul(ArrayList myList)
        {
            double enkucukOrt=0;
            double enbuyukOrt;
            double ortTop;

            myList.Sort();
            Console.Write("\nEn küçük 3 sayı: "+myList[0]+" "+myList[1]+" "+myList[2]+" ");
            enkucukOrt=((uint)myList[0]+(uint)myList[1]+(uint)myList[2]);
            enkucukOrt /=3;
            Console.WriteLine("\nEn küçük sayıların ortalaması: "+enkucukOrt);
            
            myList.Reverse();
            Console.Write("\nEn büçük 3 sayı: "+myList[0]+" "+myList[1]+" "+myList[2]+" ");
            enbuyukOrt=((uint)myList[0]+(uint)myList[1]+(uint)myList[2]);
            enbuyukOrt /=3;
            Console.WriteLine("\nEn büyük sayıların ortalaması: "+enbuyukOrt);

            ortTop=enkucukOrt+enbuyukOrt;
            Console.WriteLine("En küçük ve en büyük sayılarının ortalamalarının toplamı: "+ortTop);
        }
    }
}
