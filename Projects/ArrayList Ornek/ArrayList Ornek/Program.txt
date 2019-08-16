using System;
using System.Collections;

namespace ArrayList_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci o1 = new Ogrenci("Cansu", "Cavuldak", "1", 3.2);
            Ogrenci o2 = new Ogrenci("Sehend", "Sina", "2", 3.4);
            Ogrenci o3 = new Ogrenci("Baran", "Oktay", "3", 1.7);
            Ogrenci o4 = new Ogrenci("Umut", "Atalay", "4", 0.87);

            ArrayList ogrenciler = new ArrayList();

            //ogrenciler.Add("Umut");   //Nesne Ekler
            //ogrenciler.Add("Cansu");
            //ogrenciler.Add(8);

            ////ogrenciler.Clear(); //Tüm diziyi siler.

            //ogrenciler.Remove("Cansu"); //Nesneye göre siler
            //ogrenciler.RemoveAt(0);     //İndise göre siler

            //if (ogrenciler.Contains("Cansu"))
            //{
            //    ogrenciler.Remove("Cansu");
            //}
            //else
            //{
            //    throw new Exception("Nesne bulunamadı!");
            //}

            ogrenciler.Add(o1);
            ogrenciler.Add(o2);
            ogrenciler.Add(o3);
            ogrenciler.Add(o4);

            foreach (object item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
