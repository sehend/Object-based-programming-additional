using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Savasci : Karakter
    {
        public Savasci(string a)
        {
            Guc = 12;
            Cevik = 11;
            Zeka = 10;
            Yasam = 30;
            Enerji = 10;
            Level = 1;
            Deneyim = 0;
            Ad = a;
            Dirimi = true;
            EnvEkle(new Kilic(8));
        }
    }
}
