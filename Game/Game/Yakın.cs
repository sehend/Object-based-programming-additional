using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Yakın:Silah
    {
        int mesafe;

        public int Mesafe
        {
            get
            {
                return mesafe;
            }

            set
            {
                mesafe = value;
            }
        }
    }
}
