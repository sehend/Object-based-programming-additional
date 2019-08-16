using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Uzak:Silah
    {
        int menzil;
        List<Cephane> cephane = new List<Cephane>();

        public int Menzil
        {
            get
            {
                return menzil;
            }

            set
            {
                menzil = value;
            }
        }

        public void CephaneEkle(Cephane c)
        {
            cephane.Add(c);
        }

        public void CephaneCikar(Cephane c)
        {
            cephane.Remove(c);
        }
    }
}
