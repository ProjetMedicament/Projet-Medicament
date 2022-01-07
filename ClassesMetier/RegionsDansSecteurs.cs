using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class RegionsDansSecteurs
    {
        string LibSecteur;
        int NbrRegions;

        public RegionsDansSecteurs(string unLib,int uneRegion)
        {
            LibSecteur1 = unLib;
            NbrRegions1 = uneRegion;
        }

        public string LibSecteur1 { get => LibSecteur; set => LibSecteur = value; }
        public int NbrRegions1 { get => NbrRegions; set => NbrRegions = value; }
    }
}
