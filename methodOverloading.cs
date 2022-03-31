using System;

namespace MetotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";
            int outsayi;

            bool sonuc = int.TryParse(sayi, out outsayi);
            // bool sonuc = int.TryParse(sayi, out int outsayi); diyerek de direkt olarak 
            // tanımlayabilirdik 11.satırda tanımlamak yerine
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Metot Aşırı Yükleme (Overloading)
            int ifade =999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Mustafa", "Emre");

            // Metot İmzası; yani hangi şartlarda aşırı yükleme yapmana izin verir
            // metot adı , parametre sayisi + parametre    bunları ile

        }
    }

    class Metotlar{
        public void Topla(int a , int b , out int toplam){
            toplam=a+b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri, int veri2){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2){
            Console.WriteLine(veri1 + veri2);
        }
    }
}
