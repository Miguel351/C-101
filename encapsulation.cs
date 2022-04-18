using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 331;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 96, -2);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        // fields
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        // constructors
        public Ogrenci()
        {
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            // bu sayede ilk new ile değerleri verip instance yaratılabiliyor
            this.isim = isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }

        // getter and setters
        // bu sayede ilk anda değer atama yapılmadıysa sonradan değer vermek için 
        // setter kullanıyoruz
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        // alternatif yazım şekilleriyle
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;

            set
            {
                if (value <= 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }

        }

        // öğrenci bilgilerini getiren metot
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bilgileri ***********");
            Console.WriteLine("Öğrenci Adı        :{0}", this.isim);
            Console.WriteLine("Öğrenci Soyadı     :{0}", this.soyisim);
            Console.WriteLine("Öğrenci No         :{0}", this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıfı     :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif++;
        }

        public void SinifDusur()
        {
            this.Sinif--;
        }

    }
}
