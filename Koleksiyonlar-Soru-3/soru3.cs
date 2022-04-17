using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList sesliharfler = new ArrayList(){
                    'a','e','ı','i','o','ö','u','ü'
                };
                ArrayList sonucDizisi=new ArrayList();

                Console.WriteLine("Bir şeyler yazın: ");
                string cumle = Console.ReadLine();


                foreach (var item in sesliharfler)
                {
                    if(cumle.Contains((char)item)){
                        //Console.WriteLine(item);
                        sonucDizisi.Add(item);
                    }
                }

                sonucDizisi.Sort();
                Console.WriteLine("Cümlenizdeki sesli harfler şunlardır: ");
                foreach (var item in sonucDizisi)
                {
                    Console.Write(item + " ");
                }
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
        }
    }
}