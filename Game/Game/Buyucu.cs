using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Buyucu : Karakter
    {
        public Buyucu(string a)
        {
            Guc = 10;
            Cevik = 10;
            Zeka = 14;
            Yasam = 15;
            Enerji = 40;
            Level = 1;
            Deneyim = 0;
            Ad = a;
            Dirimi = true;
            EnvEkle(new Kilic(4));
            EnvEkle(new Kalkan(4));
        }
    }
}
