using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Silah:Envanter
    {
        int darbe;
        int mod;
        bool kritik;

        public int Darbe
        {
            get
            {
                return darbe;
            }

            set
            {
                darbe = value;
            }
        }

        public int Mod
        {
            get
            {
                return mod;
            }

            set
            {
                mod = value;
            }
        }

        public bool Kritik
        {
            get
            {
                return kritik;
            }

            set
            {
                kritik = value;
            }
        }
    }
}
