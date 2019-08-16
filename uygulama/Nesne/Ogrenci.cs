using System;
using System.Collections.Generic;

namespace Nesne
{
    class Ogrenci
    {
        string _ad;
        string _soyad;
        string _no;
        List<Ders> Dersler = new List<Ders>();

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

        public string No
        {
            get
            {
                return _no;
            }

            set
            {
                _no = value;
            }
        }

        public Ogrenci(string ad, string soyad, string no)
        {
            this._ad = ad;
            this._soyad = soyad;
            this._no = no;
        }

        public void DersEkle(Ders d)
        {
            if (Dersler.Contains(d))
            {
                throw new Exception("Bu dersi zaten alıyorsunuz!");
            }
            else
            {
                Dersler.Add(d);
            }
        }

        public void DersCikar(Ders d)
        {
            if (!Dersler.Contains(d))
            {
                throw new Exception("Bu dersi zaten almıyorsunuz!");
            }
            else
            {
                Dersler.Remove(d);
            }
        }

        public void NotGir(Ders ders, Int16 not)
        {
            if (Dersler.Contains(ders))
            {
                //Ders[3].Not = not;

                //Dersler.IndexOf(ders)

                Dersler[Dersler.IndexOf(ders)].Not = not;
            }
            else
            {
                throw new Exception("Öğrenci bu dersi almıyor!");
            }

        }

        public double Ortalama()
        {
            UInt16 toplamkredi = 0;
            Int16 toplamnot = 0;

            foreach (Ders item in Dersler)
            {
                if (item.Not != -1)
                {
                    toplamnot += item.Not;
                }
                toplamkredi += item.Kredi;
            }

            return (double)(toplamnot / toplamkredi);
        }
    }
}
