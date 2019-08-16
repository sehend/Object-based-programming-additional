using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Kilic:Yakın
    {
        int boy;

        public int Boy
        {
            get
            {
                return boy;
            }

            set
            {
                boy = value;
            }
        }

        public Kilic(int d)
        {
            Darbe = d;
        }
    }
}
