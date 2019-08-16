using System;
using System.Collections.Generic;


namespace Nesne
{
    class Ders
    {
        //attributes
        private string _kod;
        private string _ad;
        private UInt16 _kredi; //ushort
        private UInt16 _saat; //ushort
        private Int16 _not;

        public string Kod
        {
            get
            {
                return _kod;
            }

            set
            {
                _kod = value;
            }
        }

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

        public UInt16 Kredi
        {
            get
            {
                return _kredi;
            }

            set
            {
                if(value>0 && value<10)
                {
                    _kredi = value;
                }
                else
                {
                    throw new Exception("Kredi 1 ile 10 arası olmalıdır!");
                }
            }
        }

        public UInt16 Saat
        {
            get
            {
                return _saat;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    _saat = value;
                }
                else
                {
                    throw new Exception("Saat 1 ile 6 arası olmalıdır!");
                }
            }
        }

        public Int16 Not
        {
            get
            {
                return _not;
            }

            set
            {
                if (value >= -1 && value <= 100)
                {
                    _not = value;
                }
                else
                {
                    throw new Exception("Not 0 ile 100 arasında girilmelidir!\nÖğrenci sınava girmediyse notunu -1 olarak giriniz.");

                }
            }
        }

        public Ders(string kod, string ad, UInt16 kredi, UInt16 saat)
        {
            this._kod = kod;
            this._ad = ad;
            this._kredi = kredi;
            this._saat = saat;
            this._not = -1;
        }
    }
}
