using System;
using System.Collections.Generic;
using System.IO;

namespace Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string ad, soyad, musteriNo, IBAN;
            UInt16 bankaNo, subeNo;
            bool vade;
            double faiz; ;
            List<Musteri> Musteriler = new List<Musteri>();
            for (;;)
            {
                Console.WriteLine("Müşteri Ekle    => 1");
                Console.WriteLine("Müşteri Sil     => 2");
                Console.WriteLine("Müşteri Listele => 3");
                Console.WriteLine("Hesap Ekle      => 4");
                Console.WriteLine("Hesap Sil       => 5");
                Console.WriteLine("Ekranı Temizle  => 6");
                Console.WriteLine("Çıkış           => 7");

                Console.Write("Seçiminizi yapın: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //Müşteri ekleme
                        Console.Write("Müşteri adı: ");
                        ad = Console.ReadLine();
                        Console.Write("Müşteri soyadı: ");
                        soyad = Console.ReadLine();
                        Console.Write("Müşteri no: ");
                        musteriNo = Console.ReadLine();
                        Musteri m = new Musteri(ad, soyad, musteriNo);
                        Musteriler.Add(m);
                        break;
                    case 2:
                        //Müşteri silinecek
                        Console.Write("Silinecek müşterinin müşteri numarası: ");
                        musteriNo = Console.ReadLine();

                        //Önce müşteri no'ya sahip olan müşteriyi bulalım.
                        bool silindimi = false;

                        foreach (Musteri musteri in Musteriler)
                        {
                            if (musteri.MusteriNo == musteriNo)
                            {
                                Musteriler.Remove(musteri);
                                silindimi = true;
                                break; // Crucial
                            }
                        }
                        if (silindimi)
                        {
                            Console.WriteLine("Müşteri silindi");
                        }
                        else
                        {
                            Console.WriteLine("Müşteri bulunamadı!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("-----------MUSTERİLER------------");
                        foreach (Musteri musteri in Musteriler)
                        {
                            Console.WriteLine(musteri.ToString());
                            //Console.Write(musteri.Ad);
                            //Console.Write(" " + musteri.Soyad);
                            Console.WriteLine("\nHesap Bilgileri:");
                            foreach (Hesap hesap in musteri.Hesaplar)
                            {
                                Console.WriteLine(hesap.ToString());
                                //Console.Write("IBAN: {0}", hesap.IBAN);
                                //Console.Write(", Banka No: {0}", hesap.BankaNo);
                                //Console.Write(", Hesap No: {0}", hesap.SubeNo);
                                //Console.Write(", {0}", hesap.Vade ? "Vadeli" : "Vadesiz");
                                //Console.Write("\n Miktar: {0}, Faiz: {1}", hesap.Nakit, hesap.Faiz);
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Müşteri hesap numarası: ");
                        musteriNo = Console.ReadLine();

                        foreach (Musteri musteri in Musteriler)
                        {
                            if (musteri.MusteriNo == musteriNo)
                            {
                                Console.Write("IBAN: ");
                                IBAN = Console.ReadLine();
                                Console.Write("Banka No: ");
                                bankaNo = UInt16.Parse(Console.ReadLine());
                                Console.Write("Şube No: ");
                                subeNo = UInt16.Parse(Console.ReadLine());
                                Console.Write("Vadeli mi: ");
                                vade = bool.Parse(Console.ReadLine());
                                Console.Write("Faiz: ");
                                faiz = double.Parse(Console.ReadLine());
                                Hesap h = new Hesap(IBAN, bankaNo, subeNo, vade, faiz);
                                musteri.Hesaplar.Add(h);
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Hesabı silinecek müşterinin müşteri numarası: ");
                        musteriNo = Console.ReadLine();

                        foreach (Musteri musteri in Musteriler)
                        {
                            if (musteri.MusteriNo == musteriNo)
                            {
                                Console.Write("Silinecek hesabın IBAN numarası: ");
                                IBAN = Console.ReadLine();
                                foreach (Hesap hesap in musteri.Hesaplar)
                                {
                                    if (hesap.IBAN == IBAN)
                                    {
                                        musteri.Hesaplar.Remove(hesap);
                                        // int indis=musteri.Hesaplar.Indexof(hesap)
                                        //musteri.Hesaplar.Remove(musteri.Hesaplar[indis]);
                                    }
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Menüde bulunmayan bir seçim yaptınız!");
                        break;
                }
            }
        }
    }
}
