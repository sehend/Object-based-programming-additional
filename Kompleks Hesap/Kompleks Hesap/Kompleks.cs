using System;

namespace Kompleks_Hesap
{
    class Kompleks
    {
        private double _re;
        private double _im;

        public double Re { get; set; }
        public double Im { get; set; }

        public Kompleks()
        {
            _re = 0;
            _im = 0;
        }
        public Kompleks(double re, double im)
        {
            _re = re; //this._re=re;
            _im = im; //this._im=im;
        }

        public override string ToString()
        {
            if ((_re < 0 && _im < 0) || (_re > 0 && _im < 0))
            {
                return _re.ToString() + _im.ToString() + "i";
            }
            else if (_re > 0 && _im > 0)
            {
                return _re.ToString() + "+" + _im.ToString();
            }
            else if (_re == 0 && _im != 0)
            {
                return _im.ToString() + "i";
            }
            else if (_im == 0 && _re != 0)
            {
                return _re.ToString();
            }
            else if (_re == 0 && _im == 0)
            {
                return "0 ";
            }
            else
            {
                return "Reel kısım= " + _re.ToString() + "\nImajiner Kısım= " + _im.ToString();
            }
        }

        public static Kompleks operator +(Kompleks k1, Kompleks k2)
        {
            return new Kompleks(k1._re + k2._re, k1._im + k2._im);
        }
        public static Kompleks operator -(Kompleks k1, Kompleks k2)
        {
            return new Kompleks(k1._re - k2._re, k1._im - k2._im);
        }

        public static Kompleks operator -(Kompleks k1, int i)
        {
            return new Kompleks(k1._re + i, k1._im);
        }

        public static explicit operator Kompleks(int i)
        {
            return new Kompleks(i, i);
        }

        public static explicit operator Kompleks(double d)
        {
            return new Kompleks(d, 0);
        }

        public static Kompleks operator ++(Kompleks k)
        {
            return new Kompleks(k._re++, k._im++);
        }
    }
}
