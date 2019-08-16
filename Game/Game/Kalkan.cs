using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Kalkan : Envanter
    {
        int defans;

        public int Defans
        {
            get
            {
                return defans;
            }

            set
            {
                defans = value;
            }
        }

        public Kalkan(int d)
        {
            defans = d;
        }
    }
}