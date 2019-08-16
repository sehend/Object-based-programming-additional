using System;
using System.Collections.Generic;

namespace Nesne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            for (;;)
            {
                Console.WriteLine("1=> Kayıt Ekle\n2=> Kayıt Sil\n3=> Ders Ekle\n4=> Not Gir\n5=> Çıkış ");
                UInt16 secenek1, secenek2;
                secenek1 = UInt16.Parse(Console.ReadLine());
                switch (secenek1)
                {
                    case 1:
                        Console.Write("Öğrencinin adını giriniz: ");
                        string ad = Console.ReadLine();
                        Console.Write("Öğrencinin soyadını giriniz: ");
                        string soyad = Console.ReadLine();
                        Console.Write("Öğrencinin numarasını giriniz: ");
                        string no = Console.ReadLine();
                        ogrenciler.Add(new Ogrenci(ad, soyad, no));
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1=> Ada ve Soyada göre Sil\n2=> Numaraya Göre Sil\n3=> Geri Dön");
                        secenek2 = UInt16.Parse(Console.ReadLine());
                        if (secenek2 == 1)
                        {
                            //Ad ve soyada göre öğrenci sil
                        }
                        else if (secenek2 == 2)
                        {
                            //Numaraya göre öğrenci sil
                        }
                        else if (secenek2 == 3)
                        {
                            //Bir önceki menüye dön
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Bir tercih yaptınız!");
                        }
                        break;
                    case 3:
                        // Ders Ekleme
                        break;
                    case 4:
                        //Not Gir
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlış Bir tercih yaptınız!");
                        break;
                }
            }
        }
    }
}
