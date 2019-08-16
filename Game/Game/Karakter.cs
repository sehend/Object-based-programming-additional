using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Karakter
    {
        int yasam;
        int enerji;
        int level;
        int guc;
        int cevik;
        int zeka;
        int deneyim;
        string ad;
        string cins;
        bool dirimi;

        List<Envanter> envanter = new List<Envanter>();

        public int Yasam
        {
            get
            {
                return yasam;
            }

            set
            {
                yasam = value;
            }
        }

        public int Enerji
        {
            get
            {
                return enerji;
            }

            set
            {
                enerji = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public int Guc
        {
            get
            {
                return guc;
            }

            set
            {
                guc = value;
            }
        }

        public int Cevik
        {
            get
            {
                return cevik;
            }

            set
            {
                cevik = value;
            }
        }

        public int Zeka
        {
            get
            {
                return zeka;
            }

            set
            {
                zeka = value;
            }
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public int Deneyim
        {
            get
            {
                return deneyim;
            }

            set
            {
                deneyim = value;
            }
        }

        public string Cins
        {
            get
            {
                return cins;
            }

            set
            {
                cins = value;
            }
        }

        public bool Dirimi
        {
            get
            {
                return dirimi;
            }

            set
            {
                dirimi = value;
            }
        }

        public void EnvEkle(Envanter e)
        {
            envanter.Add(e);
        }

        public void EnvCikar(Envanter e)
        {
            envanter.Remove(e);
        }

        public int Vur(Karakter hedef)
        {
            Random r = new Random();
            if (Cevik + r.Next(Level + 1) > hedef.Cevik)
            {
                return r.Next(1,((Kilic)envanter[0]).Darbe);
            }
            else
            {
                return 0;
            }
        }

        public void DarbeAl(int d)
        {
            Yasam -= d;
            if(yasam<1)
            {
                dirimi = false;
            }
        }
    }
}
