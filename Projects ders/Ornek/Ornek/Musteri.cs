using System;
using System.Collections;
using System.Collections.Generic;

namespace Ornek
{
    class Musteri
    {
        string _ad;
        string _soyad;
        string _musteriNo;
        public List<Hesap> Hesaplar = new List<Hesap>(); //Aslında attribute olduğu için private olmalı
        // Hesap Ekle ve Hesap Çıkar metotları ile kapsüllenmeli
        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string MusteriNo
        {
            get
            {
                return _musteriNo;
            }

            set
            {
                _musteriNo = value;
            }
        }
        // Hesap[] Hesaplar = new Hesap[100];
        //ArrayList

        // Hesapların kapsüllenmesi için bir örnek
        //public void HesapEkle(Hesap h)
        //{
        //    Hesaplar.Add(h);
        //}


        public Musteri(string ad, string soyad, string musteriNo)
        {
            this._ad = ad;
            this._soyad = soyad;
            this._musteriNo = musteriNo;
        }

        public override string ToString()
        {
            return "Müşteri No: " + _musteriNo + "\nAdı ve Soyadı: " + _ad + " " + _soyad + "\n";
        }

    }
}
