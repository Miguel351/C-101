using System;

namespace diziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5]; // string tipinde 5 elemanlı renkler dizisi tanımlandı

            string[] hayvanlar = {"kedi","köpek","kuş","Maymun"}; // Diziye direkt elemanları koyarak tanımlama

            int[] dizi;
            dizi = new int[5]; // boyutsuz tanımladık sonra başka satırda boyut verdik eleman yerleştirmedik

            // Dizilere değer atama ve erişim
            renkler[0]="Mavi";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle Dizi Kullanımı
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz.: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i+1); // {} işareti değişkene göre ekrana birşey basmak için tırnak sonrası , den sonrada o değişkenin ismini veririz.
                sayidizisi[i]=int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: "+ toplam/diziUzunlugu);

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine(i+1+".inci sayı= "+sayidizisi[i]);
            }


        }
    }
}
