using System;
using System.Collections;
using System.Collections.Generic;

namespace List_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci o = new Ogrenci("", "", "", 0);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. oğrencinin adını giriniz: ", i);
                o.SetAd(Console.ReadLine());
                Console.WriteLine("{0}. oğrencinin soyadını giriniz: ", i);
                o.SetSoyad(Console.ReadLine());
                Console.WriteLine("{0}. oğrencinin numarasını giriniz: ", i);
                o.SetNo(Console.ReadLine());
                Console.WriteLine("{0}. oğrencinin not ortalamasını giriniz: ", i);
                o.SetOrtalama(double.Parse(Console.ReadLine()));

                ogrenciler.Add(o);
            }

            foreach (Ogrenci item in ogrenciler)
            {
                item.ToString();
            }

            Console.ReadLine();


        }
    }
}
