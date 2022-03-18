using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 125;             //1 byte
            sbyte c = 45;            //1 byte
            Console.WriteLine("byte değerimiz, hafiza alani 1 byte: "+ b);
            Console.WriteLine("sbyte değerimiz, hafiza alani 1 byte: "+ c);

            short s = 16;            //2 byte
            ushort us = 9;          //2 byte
            Console.WriteLine("short değerimiz, hafiza alani 2 byte: "+ s);
            Console.WriteLine("ushort değerimiz, hafiza alani 2 byte: "+ us);

            Int16 i16 = 2;          //2 byte
            Console.WriteLine("int16 değerimiz, hafiza alani 2 byte: "+ i16);
            int i = 12;              //4 byte
            Console.WriteLine("int değerimiz, hafiza alani 4 byte: "+ i);
            Int32 i32 = 1024;          //4 byte
            Console.WriteLine("int32 değerimiz, hafiza alani 4 byte: "+ i32);
            Int64 i64 = 512;          //8 byte
            Console.WriteLine("int64 değerimiz, hafiza alani 8 byte: "+ i64);

            uint ui = 14;            //4 byte
            Console.WriteLine("uint değerimiz, hafiza alani 4 byte: "+ ui);
            long l = 64;             //8 byte
            Console.WriteLine("long değerimiz, hafiza alani 8 byte: "+ l);
            ulong ul = 4096;           //8 byte
            Console.WriteLine("ulong değerimiz, hafiza alani 8 byte: "+ ul);

            //Reel sayılar
            float f = 5.3f;            //4 byte
            Console.WriteLine("float değerimiz, hafiza alani 4 byte: "+ f);
            double d = 25;           //8 byte
            Console.WriteLine("double değerimiz, hafiza alani 8 byte: "+ d);
            decimal de = 1;         //16 byte
            Console.WriteLine("decimal değerimiz, hafiza alani 16 byte: "+ de);

            char ch = 'e';          //2 byte
            Console.WriteLine("char değerimiz, hafiza alani 2 byte: "+ ch);
            string str = "Mustafa Kemal Atatürk";   //sınırsız
            Console.WriteLine("string değerimiz, hafiza alani sinirsiz: "+ str);

            bool b1 = true;
            bool b2 = false;
            Console.WriteLine("bool değerlerimiz, ilk bool: "+ b1+" ikinci bool: "+b2);

            DateTime dt = DateTime.Now;
            Console.WriteLine("DateTime değerimiz: "+ dt);

            object o1 = "t";
            object o2 = 'q';
            object o3 = 48;
            object o4 = 9.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Mustafa İlker";
            string ad = "18 Mart Canakkale";
            string soyad = "Zaferi";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri
            int integer1 = 12;
            int integer2 = 8;
            int integer3 = integer1 * integer2;

            //boolean ifadeler
            bool bool1 = 10 < 2;
            Console.WriteLine("bu mantık sınaması sonucu: "+bool1);

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 22;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine("yeni değer: "+ yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine("int21, int20 ve convert edilen str20 den oluştu:"+int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine("int22, int20 ve parse edilen str20 den oluştu:"+int22);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Kodun çalıştığı tarih:"+ datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM");
            Console.WriteLine("Kodun çalıştığı tarih kısa mod:"+ datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("kodun çalıştığı saat: "+ hour);

        }
    }
}