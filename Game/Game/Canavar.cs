using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Canavar:Karakter
    {
        public Canavar(string a,int lvl)
        {
            //Lvl 3
            Guc = Level+5;     //8
            Cevik = Level+6;   //9
            Zeka = Level+1;    //4
            Yasam = Level+20;  //23
            Enerji = Level;    //3     
            Level = lvl;       //3     
            Deneyim = 100;
            Ad = a;
            Dirimi = true;
            EnvEkle(new Kilic(4));
        }
    }
}
