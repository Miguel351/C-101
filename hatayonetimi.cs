using System;

namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
          // hata ihtimali olabilecek kodu try içine yaz
          try
          {
              Console.WriteLine("Bir sayı giriniz");
              int sayi=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
          }
          // hata yakalandığında yapılacaklar buraya yazılır
          catch (Exception ex)
          {
             Console.WriteLine("Hata: "+ ex.Message.ToString());

          }
          // Hata olsun olmasın bu blok çalışsın
          /*finally
          {
            Console.WriteLine("işlem tamamlandı: ");
          }
          */

          try
          {
              //int a=int.Parse(null);
              //int a= int.Parse("test");
              int a= int.Parse("-51200000000000");
          }
          catch (ArgumentNullException ex)
          {
              Console.WriteLine("Boş değer girdiniz");
              Console.WriteLine(ex);
          }

        catch (FormatException ex)
          {
              Console.WriteLine("Veri tipi uygun değil");
              Console.WriteLine(ex);
          }

          catch (OverflowException ex)
          {
              Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
              Console.WriteLine(ex);
          }

          finally{
               Console.WriteLine("ders bitmiştir :) ");
          }
        }
    }
}
