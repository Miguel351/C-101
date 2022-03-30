using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erişim belirteci , geri donus tipi , metot adi(parametreListesi/arguman)
            //{
            /////komutlar buraya yazılır;
            // return;
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlarr ornek = new Metotlarr();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }


    class Metotlarr
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }

}
