using System;

namespace hazır_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2="CSharp";

            // Length;
            Console.WriteLine(degisken.Length);

            // ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            // CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); 
            // ilk değişkenin karakter sayısı büyükse 1
            // ilk değişkenin karakter sayısı küçükse -1
            // ilk değişkenin karakter sayısı aynı ise 0

            // Compare
            Console.WriteLine(String.Compare(degisken,degisken2,true)); 
            Console.WriteLine(String.Compare(degisken,degisken2,false)); 
            // String ifadesi ile birlikte kullanmak gerekir
            // Büyük küçük harf duyarlı olsun istenirse True, istenmezse False parametresi kullanılır

            // Contains -> true yada false döner
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            // IndexOf ve LastIndexOf
            // verdiğimiz karakter katarını değişken içinde arar. İlk bulduğu yerin index numarasını döner
            // bulamazsa -1 döner
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("XS"));
            Console.WriteLine(degisken.LastIndexOf("i"));


            // insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            // PadLeft, PadRight
            // soluna boşluk ekleyeceğimiz kelim 5 harfse ve biz padleft 9 dersek
            // sonuçta 9-5=4 yani sola 4 karakter boşluk basar
            Console.WriteLine(degisken + degisken2.PadLeft(9));
            Console.WriteLine(degisken + degisken2.PadLeft(9,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'$') + degisken2);

            // Remove , verilen değerden sonrasını siler
            Console.WriteLine(degisken.Remove(10));
            // 5.karakterden başlayarak 3 karakter sil
            Console.WriteLine(degisken.Remove(5,3));
            // en başı silmenin yolu
            Console.WriteLine(degisken.Remove(0,1));

            // Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

           // Split ör: boşluklara göre parçala ve diziye ata
           // ve bana o dizinin 1. indexteki verisini getir
           Console.WriteLine(degisken.Split(' ')[1]);

           // Substring
           // 4.indexten başlayarak sonuna kadar getirdi
           // 4.indexten başlayarak 6 karakter getirdi
           Console.WriteLine(degisken.Substring(4));
           Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
