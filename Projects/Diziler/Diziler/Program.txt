using System;
using System.Collections;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci("Cansu", "Cavuldak", "1", 3.2);
            Ogrenci o2 = new Ogrenci("Sehend", "Sina", "2", 3.4);
            Ogrenci o3 = new Ogrenci("Baran", "Oktay", "3", 1.7);
            Ogrenci o4 = new Ogrenci("Umut", "Atalay", "4", 0.87);

            Ogrenci[] ogrenciler = new Ogrenci[5];

            ogrenciler[0] = o1;
            ogrenciler[1] = o2;
            ogrenciler[2] = o3;
            ogrenciler[3] = o4;

            ogrenciler[4] = new Ogrenci("Dilara", "Işık", "5", 3.695);

            Console.WriteLine("Öğrencinin adı: {0}\nÖğrencinin ortalaması: {1}", ogrenciler[3].GetAd(), ogrenciler[3].GetOrtalama());
            Console.ReadLine();
        }
    }
}
