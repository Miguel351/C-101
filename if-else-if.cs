using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;

            if(time>=6 && time<11){
                Console.WriteLine("Günaydın! " + DateTime.Now);
            } else if (time<=18){
                Console.WriteLine("İyi Günler! " + DateTime.Now);
            } else {
                Console.WriteLine("İyi Geceler! " + DateTime.Now);
            }

            // ternany kullanımı -1
            // ? işareti ise anlamında kullanılıyor
            string sonuc= time<=18 ? "iyi günler!" : "iyi geceler";
            Console.WriteLine(sonuc);

            // ternany kullanımı -2
            // : işareti değilse anlamında kullanılıyor
            // iç içe if kullanımı gibi kullanmak gerekirse

            sonuc = time >=6 && time <11 ? "Günaydın" : time <=18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);


        }
    }
}
