using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    class Hesap
    {
        string _IBAN;
        UInt16 _bankaNo;
        UInt16 _subeNo;
        bool _vade;
        double _faiz;
        double _nakit;

        public string IBAN
        {
            get
            {
                return _IBAN;
            }

            set
            {
                _IBAN = value;
            }
        }

        public ushort BankaNo
        {
            get
            {
                return _bankaNo;
            }

            set
            {
                _bankaNo = value;
            }
        }

        public ushort SubeNo
        {
            get
            {
                return _subeNo;
            }

            set
            {
                _subeNo = value;
            }
        }

        public bool Vade
        {
            get
            {
                return _vade;
            }

            set
            {
                _vade = value;
            }
        }

        public double Faiz
        {
            get
            {
                return _faiz;
            }

            set
            {
                _faiz = value;
            }
        }

        public double Nakit
        {
            get
            {
                return _nakit;
            }

            set
            {
                _nakit = value;
            }
        }

        public Hesap(string IBAN, UInt16 bankaNo, UInt16 subeNo, bool vade, double faiz)
        {
            this._IBAN = IBAN;
            this._bankaNo = bankaNo;
            this._subeNo = subeNo;
            this._vade = vade;
            this._faiz = faiz;
            this._nakit = 0;
        }

        public void ParaYatir(double miktar)
        {
            _nakit += miktar;
        }

        public void ParaCek(double miktar)
        {
            if (miktar <= _nakit)
            {
                _nakit -= miktar;
            }
            else
            {
                throw new Exception("Yetersiz bakiye");
            }
        }

        public override string ToString()
        {
            return "IBAN: " + _IBAN + ", Banka No: " + _bankaNo + ", Şube No: " + _subeNo + _vade.ToString() + "\n" + "Faiz: " + _faiz + ", Miktar: " + _nakit;
        }
    }
}
