using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);
            Calisan calisan1=new Calisan("deniz","özen","IK");
            // calisan1. denilince özellikler private olduğundan bize menüde
            // açılmadı bile ama public kurucu üzerinden ilk değerleri atayabildik
            // ve de çalışan sayısı kurucudaki koddan dolayı kendiliğinden arttı
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);
            Calisan calisan2=new Calisan("banu","cengiz","Satın Alma");
            Calisan calisan3=new Calisan("Pınar","elmor","Finans");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);

            Console.WriteLine(Islemler.Topla(90,6));

        }
    }

    // static olan bir class içindeki field ve metotlar da artık static olmak zorunda
    class Calisan{
        private static int calisansayisi;

        // public static int Calisansayisi { get => calisansayisi; set => calisansayisi = value; }
        public static int Calisansayisi { get => calisansayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan(){
            calisansayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisansayisi++;
        }
    }
    static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
    }
}
