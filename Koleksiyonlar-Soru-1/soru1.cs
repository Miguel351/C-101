using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yirmi adet pozitif sayı giriniz: ");
                //kontrol.kontroller();
                int tur = 1;
                uint pozsayi = 0;
                ArrayList asal = new ArrayList();
                ArrayList asalDegil = new ArrayList(); /*{
                    115,50,30,40,160,90
                };*/

                while (tur <= 20)
                {
                    Console.WriteLine("{0}.sayı? ", tur);
                    pozsayi = uint.Parse(Console.ReadLine());
                    asalMI(pozsayi);
                    tur++;
                }

                void asalMI(uint pz)
                {
                    bool asalmis = true;

                    for (int i = 2; i < pz; i++)
                    {
                        if (pz % i == 0)
                        {
                            asalDegil.Add(pz);
                            asalmis = false;
                            break;
                        }
                    }
                    if (asalmis)
                        asal.Add(pz);
                }

                asalDegil.Sort();
                asalDegil.Reverse();
                asal.Sort();
                asal.Reverse();

                Console.Write("\tasal olmayan listesi: ");
                foreach (var item in asalDegil)
                {
                    Console.Write(item + " ");
                }

                Console.Write("\n\t\tasal listesi: ");
                foreach (var item in asal)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\nAsal dizinin eleman sayısı= " + asal.Count);
                Console.WriteLine("Asal olmayan dizinin eleman sayısı= " + asalDegil.Count);


                double asalDegilOrt = 0;
                double asalOrt = 0;

                for (int i = 0; i < asalDegil.Count; i++)
                {
                    asalDegilOrt += (uint)asalDegil[i];
                }
                asalDegilOrt /= asalDegil.Count;
                Console.WriteLine("\nAsal olmayan dizinin sayı ortalaması= " + asalDegilOrt);

                for (int i = 0; i < asal.Count; i++)
                {
                    asalOrt += (uint)asal[i];
                }
                asalOrt /= asal.Count;
                Console.WriteLine("Asal dizinin sayı ortalaması= " + asalOrt);

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

        public static void kontroller()
        {

        }
    }
}
