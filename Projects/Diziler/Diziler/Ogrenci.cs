using System;

namespace Diziler
{
    class Ogrenci
    {
        private string _ad;
        private string _soyad;
        private string _no;
        private double _ort;

        #region Accesor ve Mutator
        public string GetAd()              //public string Ad {get; set; }
        {
            return _ad;
        }
        public void SetAd(string ad)
        {
            _ad = ad;
        }
        public string GetSoyad()           //public string Soyad {get; set; }
        {
            return _soyad;
        }
        public void SetSoyad(string soyad)
        {
            _soyad = soyad;
        }
        public string GetNo()              //public string No { get; set; }
        {
            return _no;
        }
        public void SetNo(string n)
        {
            _no = n;
        }
        public double GetOrtalama()
        {
            return _ort;
        }
        public void SetOrtalama(double o)
        {
            if (o >= 0 && o <= 4)
                _ort = o;
            else
                throw new Exception("Ortalama 0 ile 4 arasında olmalıdır!");
        }
        #endregion

        public Ogrenci(string ad, string soyad, string no)
        {
            _ad = ad;
            _soyad = soyad;
            _no = no;
            _ort = 0;
        }
        public Ogrenci(string ad, string soyad, string no, double ort)
        {
            _ad = ad;
            _soyad = soyad;
            _no = no;
            _ort = ort;
        }
    }
}
