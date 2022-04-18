using System;

namespace kurucumetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            //  class SınıfAdı
            //  {
            //      [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
            //      {
            //          // Metot Komutları    
            //      }
            //  }

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
          
            // (1) Calisan calisan1 = new Calisan();
            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
            /*   
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Departman = "İnsan Kaynakları"; 
            */
            calisan1.CalisanBilgileri();
            Console.WriteLine("*******************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25632541;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri(); // nesneye ait tüm özellikleri metoda aktarmış oluyoruz.

            Console.WriteLine("*******************");
            Calisan calisan3=new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        // Aşağıdaki kurucu metotu yapınca main metotda new ile class örneği
        // yapmıştık o hata verdi çünkü artık içine parametre istiyor bkz.(1)
        // bu hatayı almamak için bir yöntemde kurucuya aşırı yükleme yapabilmektir (2)
        public Calisan(string ad, string soyad,int no, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

            public Calisan(string ad, string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }

        // (2)
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}






